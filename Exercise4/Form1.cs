using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class FormMain : Form
    {

        private string filePath;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            // If the user has not selected a file, prompt them to do so
            if (String.IsNullOrEmpty(filePath))
            {
                bttnChooseFile.PerformClick();
            }

            // Create a person object and write its fields to the file
            try
            {
                Employee myEmployee = new Employee(txtBoxName.Text,
                                             Convert.ToInt32(txtBoxNumber.Text),
                                             Convert.ToDecimal(txtBoxRate.Text),
                                             Convert.ToDecimal(txtBoxHours.Text));

                // using statement provides automatic resource management, 
                // no need to manually close the stream
                using (TextWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(myEmployee.Name + "," +
                                 myEmployee.Number + "," +
                                 myEmployee.Rate + "," +
                                 myEmployee.Hours + "," +
                                 String.Format("{0:C}", myEmployee.Pay));
                    bttnClear.PerformClick();
                    lblSuccess.Visible = true;
                    lblFailure.Visible = false;
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                lblSuccess.Visible = false;
                lblFailure.Visible = true;
            }           
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxNumber.Clear();
            txtBoxRate.Clear();
            txtBoxHours.Clear();
            lblSuccess.Visible = false;
            lblFailure.Visible = false;
        }

        private void bttnChooseFile_Click(object sender, EventArgs e)
        {
            // actually sets the FileName property for the dialog
            DialogResult result = saveFileDialog1.ShowDialog();
        }

        private void bttnViewList_Click(object sender, EventArgs e)
        {
            FormList listForm = new FormList(filePath);
            listForm.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = saveFileDialog1.FileName;
        }
    }
}
