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

namespace Textbook_Problem_13_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // set the error if no name is provided
            if (string.IsNullOrEmpty(tbEnterName.Text))
            {
                lbSearchError.Text = "Please enter a name to search.";
                return;
            }

            // if we got to here, input is valid so remove error line
            lbSearchError.Text = "";

            // create the connection and make the query
            string connectionString = Properties.Settings.Default.PersonnelConnectionString;
            string query = "SELECT * FROM Employee WHERE [Name] LIKE @name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", "%" + tbEnterName.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                employeeDataGridView.DataSource = dt; // directly bind rows to grid
            }
        }
    }
}
