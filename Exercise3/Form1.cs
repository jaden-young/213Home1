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

namespace Exercise3
{
    public partial class FormMain : Form
    {
        private string filePath;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void bttnChooseFile_Click(object sender, EventArgs e)
        {
            // actually sets the FileName property for the dialog
            DialogResult result = saveFileDialog1.ShowDialog();        
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = saveFileDialog1.FileName;
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            // If the user has not selected a file, prompt them to do so
            if (String.IsNullOrEmpty(filePath))
            {
                bttnChooseFile.PerformClick();
            }

            // Create a person object and write its fields to the file
            try
            {
                Person myPerson = new Person(txtBoxName.Text, 
                                             txtBoxEmail.Text, 
                                             mTxtBoxPhoneNumber.Text);
                TextWriter writer = new StreamWriter(filePath, true);
                
                writer.WriteLine(myPerson.Name + ", " +
                                 myPerson.Email + ", " +
                                 myPerson.PhoneNumber);
                writer.Close();
                bttnClear.PerformClick();
                lblSuccess.Visible = true;
                lblFailure.Visible = false;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                lblSuccess.Visible = false;
                lblFailure.Visible = true;
            }           
        }

        // Clears all fields on the form
        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxEmail.Clear();
            mTxtBoxPhoneNumber.Clear();
            lblSuccess.Visible = false;
            lblFailure.Visible = false;
        }

        private void lblSuccess_Click(object sender, EventArgs e)
        {

        }
    }
}
