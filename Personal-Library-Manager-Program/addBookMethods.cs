using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Personal_Library_Manager_Program
{
    public partial class form_libraryManager : Form
    {
        //method to clear the inputs of the add book tab
        private void clearAddInputs()
        {
            textBox_authorAdd.Text = string.Empty;
            textBox_genreAdd.Text = string.Empty;
            textBox_titleAdd.Text = string.Empty;
            nup_yearAdd.Value = DateTime.Now.Year;
            //also clears the status message
            label_addBookResult.Text = string.Empty;
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            String title = textBox_titleAdd.Text;
            String author = textBox_authorAdd.Text;
            String genre = textBox_genreAdd.Text;
            int year = (int)nup_yearAdd.Value;

            try
            {
                BooksTableInsert(title, author, genre, year);
                //if the insert succeeds, let the user know through a label
                label_addBookResult.Text = "New book added successfully.";
            }
            catch (Exception ex)
            {
                //if the insert fails, let the user know through a label
                label_addBookResult.Text = "Error adding new book";
            }
        }

        private void button_clearAddBook_Click(object sender, EventArgs e)
        {
            clearAddInputs();
        }
    }
}