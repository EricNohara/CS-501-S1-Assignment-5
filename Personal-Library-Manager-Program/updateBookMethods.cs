using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Personal_Library_Manager_Program
{
    public partial class form_libraryManager : Form
    {
        //method to clear the inputs of the update book tab
        private void clearUpdateFields()
        {
            textBox_authorUpdate.Text = string.Empty;
            textBox_titleUpdate.Text = string.Empty;
            //reset search status message
            label_updateSearchStatus.Text = string.Empty;
            //make the controls for the search result disappear
            groupBox_updateResult.Visible = false;
            //clear the update status message in advance
            label_performUpdateStatus.Text = string.Empty;
            
            
        }

        private void button_performUpdate_Click(object sender, EventArgs e)
        {
            //get the input values for the update
            string oldTitle = textBox_titleUpdate.Text;
            string oldAuthor = textBox_authorUpdate.Text;
            BookData bookData = new BookData();
            bookData.author = textBox_authorUpdateResult.Text;
            bookData.title = textBox_titleUpdateResult.Text;
            bookData.genre = textBox_genreUpdateResult.Text;
            bookData.year = (int)nup_yearUpdateResult.Value;
            bookData.status = comboBox_statusUpdateResult.SelectedItem.ToString();
            bool delete = checkBox_deleteBook.Checked;

            //make the update
            try
            {
                BooksTableSingleUpdate(oldTitle, oldAuthor, delete, bookData);
                //update status text
                label_performUpdateStatus.Text = delete? "Entry deleted" : "Entry updated.";
            }
            catch (Exception)
            {
                //on an error, set status text
                label_performUpdateStatus.Text = "Update failed.";
            }

        }

        private void button_clearUpdate_Click(object sender, EventArgs e)
        {
            //clear the update fields
            clearUpdateFields();
            //make the update fields editable
            textBox_authorUpdate.ReadOnly = false;
            textBox_titleUpdate.ReadOnly = false;
        }

        private void button_searchUpdate_Click(object sender, EventArgs e)
        {
            //get the search values and perform a search for a book
            string title = textBox_titleUpdate.Text;
            string author = textBox_authorUpdate.Text;
            BookData result = new BookData();
            try
            {
                BooksTableSingleSearch(result, title, author);
                //on successful search, update status and input values into edit fields
                label_updateSearchStatus.Text = "Book found.";
                textBox_titleUpdateResult.Text = result.title;
                textBox_authorUpdateResult.Text = result.author;
                textBox_genreUpdateResult.Text = result.genre;
                nup_yearUpdateResult.Value = result.year;
                comboBox_statusUpdateResult.SelectedItem = result.status;
                //always put the delete option off by default
                checkBox_deleteBook.Checked = false;
                //make sure the results group is visible
                groupBox_updateResult.Visible = true;
                //on successful search, make the search inputs read only until
                // a cancellation is done
                textBox_authorUpdate.ReadOnly = true;
                textBox_titleUpdate.ReadOnly = true;

            }
            catch (Exception)
            {
                //if the search fails for any reason, indicate this with a notification
                label_updateSearchStatus.Text = "Error finding book.";
                groupBox_updateResult.Visible = false;
                //since there's no editing to be done, let them change the search parameters
                textBox_authorUpdate.ReadOnly = false;
                textBox_titleUpdate.ReadOnly = false;
            }
        }
    }
}