using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Personal_Library_Manager_Program
{
    public partial class form_libraryManager : Form
    {
        //method to clear the inputs of the update book tab
        private void clearSearchInputs()
        {
            textBox_authorSearch.Text = string.Empty;
            textBox_genreSearch.Text = string.Empty;
            textBox_titleSearch.Text = string.Empty;
            //set year to current, and deactivate the year filter
            nup_yearSearch.Value = DateTime.Now.Year;
            checkBox_filterByYear.Checked = false;
            comboBox_statusSearch.SelectedIndex = 0;
            //clear out the results grid
            dgv_searchResults.DataSource = null;
            //clear the error label
            label_searchBookResult.Text = string.Empty;
        }

        private void button_clearSearch_Click(object sender, EventArgs e)
        {
            //clear all search inputs
            clearSearchInputs();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //gather the filter values
            string title = textBox_titleSearch.Text;
            string author = textBox_authorSearch.Text;
            string genre = textBox_genreSearch.Text;
            bool filterByYear = checkBox_filterByYear.Checked;
            int year = filterByYear? (int)nup_yearSearch.Value : 0; //set year to null if its value is not being filtered for
            string status = comboBox_statusSearch.Text;

            DataTable results = new DataTable();
            try
            {
                BooksTableSearch(results, title, author, genre, year, status);
                //set the gridview to show the results table
                dgv_searchResults.DataSource = results;
                //clear the error label in case it is set
                label_searchBookResult.Text = string.Empty;
            }
            catch (Exception ex)
            {
                //if the search fails, let the user know through a label
                label_searchBookResult.Text = "Error searching for books.";
            }

        }

        private void checkBox_filterByYear_CheckedChanged(object sender, EventArgs e)
        {
            //Only when the checkbox is checked, allow the  number to be changed.
            if(checkBox_filterByYear.Checked == false)
            {
                nup_yearSearch.ReadOnly = true;
            } else
            {
                nup_yearSearch.ReadOnly = false;
            }
        }


    }
}