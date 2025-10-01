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
using System.Configuration;

namespace BMI_Calculator_3
{
    public partial class Form1 : Form
    {
        // field to store the current BMI to avoid recalcuations
        private decimal currentBMI;
        private readonly int AVERAGE_COUNT = 10;

        public Form1()
        {
            InitializeComponent();
            currentBMI = -1; // set it to initial invalid state
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            // calculate the BMI and display the output
            decimal weight = nudWeight.Value;
            decimal height = nudHeight.Value;
            this.currentBMI = (703 * weight) / (height * height);

            tbBMIOutput.Text = this.currentBMI.ToString();
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager
                .ConnectionStrings["BMI_Calculator_3.Properties.Settings.BMIDatabaseConnectionString"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // if there is a valid BMI value, save to DB
                if (this.currentBMI > 0)
                {
                    string sql = "INSERT INTO BmiCalculations (Bmi) VALUES (@Bmi)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Bmi", this.currentBMI);

                        int rows = cmd.ExecuteNonQuery();

                        // validate the execution of the query worked
                        if (rows > 0)
                        {
                            // Refill the DataSet so the DataGridView updates
                            this.bmiCalculationsTableAdapter.Fill(this.bMIDatabaseDataSet.BmiCalculations);

                            lbSaveStatus.Text = "BMI saved and grid updated!";
                        }
                        else
                        {
                            lbSaveStatus.Text = "BMI was not saved. Please try again.";
                        }
                    }
                }
                else
                {
                    lbSaveStatus.Text = "Please calculate a valid BMI before saving.";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill the DataSet from the database
            this.bmiCalculationsTableAdapter.Fill(this.bMIDatabaseDataSet.BmiCalculations);
        }

        private void btnDisplayAverageBMI_Click(object sender, EventArgs e)
        {
            // if there are at least 10 entries, give the average of the last 10
            DataTable dt = this.bMIDatabaseDataSet.BmiCalculations;

            if (dt.Rows.Count == 0)
            {
                tbAverageBMI.Text = "No data available!";
            } else if (dt.Rows.Count < AVERAGE_COUNT)
            {
                tbAverageBMI.Text = $"More Data Needed ({AVERAGE_COUNT - dt.Rows.Count} More)";
            } else
            {
                // get the last 10 entries based on Date
                var last10Rows = dt.AsEnumerable()
                                   .OrderByDescending(r => r.Field<DateTime>("Date"))
                                   .Take(AVERAGE_COUNT);

                // calculate the average BMI
                decimal average = last10Rows.Average(r => r.Field<decimal>("Bmi"));

                // display the average
                tbAverageBMI.Text = average.ToString();
            }
        }
    }
}
