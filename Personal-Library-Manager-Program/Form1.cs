using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Library_Manager_Program
{
    public partial class form_libraryManager : Form
    {
        public form_libraryManager()
        {
            InitializeComponent();
            //set year value to initially be now
            nup_yearAdd.Value = DateTime.Now.Year;
            nup_yearSearch.Value = DateTime.Now.Year;
        }

        //a simple data class to be used when searching for individual books
        private class BookData
        {
            public int id;
            public string title;
            public string author;
            public string genre;
            public int year;
            public string status;
        }

        //method to alter/delete a single book entry
        private void BooksTableSingleUpdate(
            string title,
            string author,
            bool delete,
            BookData newData
            )
        {
            //connect to db
            string connString = Properties.Settings.Default.LibraryDBConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //create command string based on if delete is true or not
            StringBuilder update;
            SqlCommand cmd;

            if (delete)
            {
                //make delete command
                update = new StringBuilder(
                    "DELETE FROM Books WHERE Title = @oldTitle AND Author = @oldAuthor"
                    );
                //add parameters
                cmd = new SqlCommand(update.ToString(), conn);
                cmd.Parameters.AddWithValue("@oldTitle", title);
                cmd.Parameters.AddWithValue("@oldAuthor", author);
            } else
            {
                //make update command
                update = new StringBuilder(
                     "UPDATE Books SET Title = @title, Author = @author, Genre = @genre, "
                     + "Year = @year, Status = @status WHERE Title = @oldTitle AND "
                     + "Author = @oldAuthor"
                    );
                //add parameters
                cmd = new SqlCommand(update.ToString(), conn);
                cmd.Parameters.AddWithValue("@title", newData.title);
                cmd.Parameters.AddWithValue("@author", newData.author);
                cmd.Parameters.AddWithValue("@genre", newData.genre);
                cmd.Parameters.AddWithValue("@year", newData.year);
                cmd.Parameters.AddWithValue("@status", newData.status);
                cmd.Parameters.AddWithValue("@oldTitle", title);
                cmd.Parameters.AddWithValue("@oldAuthor", author);

            }
            //execute and close
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        //method to search for a single book; table constrictions ensure that
        // only one book can have a certain title/author combo
        private void BooksTableSingleSearch(BookData result, string title, string author)
        {
            //connect to db
            string connString = Properties.Settings.Default.LibraryDBConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //create search string
            var search = new StringBuilder(
                "SELECT * FROM BOOKS WHERE Title = @title AND Author = @author" 
                );

            //add parameters to string
            SqlCommand cmd = new SqlCommand(search.ToString(), conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);

            //make reader to get results and read the first/only row
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //if the book is found, write its info to the given bookData object
                result.title = reader["title"].ToString();
                result.author = reader["author"].ToString();
                result.genre = reader["genre"].ToString();
                result.status = reader["status"].ToString();
                result.year = (int) reader["year"];
                result.id = (int) reader["BookID"];

            } else
            {
                //if no results came back, throw an exception so the search shows up
                // as erroneous
                throw new Exception();
            }
            conn.Close();

        }

        //method to search for a set of books and store the results in a table
        private void BooksTableSearch(
            DataTable results,
            string title = "",
            string author = "",
            string genre = "",
            int year = 0,
            string status = ""
            )
        {
            //establish connection to db
            string connString = Properties.Settings.Default.LibraryDBConnectionString;
            SqlConnection conn = new SqlConnection( connString );
            conn.Open();

            //create initial search string
            var search = new StringBuilder("SELECT * FROM BOOKS");

            //create string with filters for search based on arguments
            var filters = new StringBuilder();
            bool firstFilter = true;   //all but the first filter need an "AND" before them
            if (!string.IsNullOrEmpty(title)) {
                if (!firstFilter) { filters.Append(" AND"); }
                else { firstFilter = false; }
                filters.Append(" Title LIKE @title"); 
            }
            if (!string.IsNullOrEmpty(author)) {
                if (!firstFilter) { filters.Append(" AND"); }
                else { firstFilter = false; }
                filters.Append(" Author LIKE @author"); 
            }
            if (!string.IsNullOrEmpty(genre)) {
                if (!firstFilter) { filters.Append(" AND"); }
                else { firstFilter = false; }
                filters.Append(" Genre LIKE @genre"); 
            }
            if (year != 0) {
                if (!firstFilter) { filters.Append(" AND"); }
                else { firstFilter = false; }
                filters.Append(" Year = @year"); 
            }
            if (!string.IsNullOrEmpty(status)) {
                if (!firstFilter) { filters.Append(" AND"); }
                else { firstFilter = false; }
                filters.Append(" Status = @status"); 
            }

            //if filters were applied, add the filters string to the search string
            if (!string.IsNullOrEmpty(filters.ToString()))
            {
                search.Append(" WHERE" + filters.ToString());
            }

            //add parameters to the command depending on the arguments given
            SqlCommand cmd = new SqlCommand(search.ToString(), conn);
            if (!string.IsNullOrEmpty(title)) {cmd.Parameters.AddWithValue("@title", wc(title)); }
            if (!string.IsNullOrEmpty(author)) { cmd.Parameters.AddWithValue("@author", wc(author)); }
            if (!string.IsNullOrEmpty(genre)) { cmd.Parameters.AddWithValue("@genre", wc(genre)); }
            if (year != 0) { cmd.Parameters.AddWithValue("@year", year); }
            if (!string.IsNullOrEmpty(status)) { cmd.Parameters.AddWithValue("@status", status); }
            
            //Make a data adpater to read the query results and populate the given table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(results);

            //close connection
            conn.Close();
        }
        //helper method that adds wildcard symbols to a given string
        private string wc(string s)
        {
            return "%" + s + "%";
        }

        //method to insert a new book into the table
        private void BooksTableInsert(
            String title, 
            String author,
            String genre,
            int year
            )
        {
            //connect to db
            String connString = Properties.Settings.Default.LibraryDBConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //construct command string
            String insert =
                "INSERT INTO Books (Title, Author, Genre, [Year], Status)"
                + " VALUES (@title, @author, @genre, @year, @status)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            //add data to string as parameters
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@year", year);
            //New books start as available to take out
            cmd.Parameters.AddWithValue("@status", "available");
            //execute command
            cmd.ExecuteNonQuery();
            //close connection
            conn.Close();
        }

        
    }
}
