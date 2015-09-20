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
    public partial class FormList : Form
    {
        public FormList(string filePath)
        {
            InitializeComponent();
            
            // Much more efficient than concatenation
            StringBuilder builder = new StringBuilder();

            // The using statement allows automatic cleanup of resources,
            // don't need to manually close stream.
            using (TextReader reader = new StreamReader(filePath))
            {
                string line;

                // Stops when reaching the end of the file
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    builder.Append("Name: ");
                    builder.AppendLine(fields[0]);
                    builder.Append("Number: ");
                    builder.AppendLine(fields[1]);
                    builder.Append("Pay Rate: ");
                    // Format currency
                    builder.AppendLine(String.Format("{0:C}", fields[2]));
                    builder.Append("Hours Worked: ");
                    builder.AppendLine(fields[3]);
                    builder.Append("Pay Recieved: ");
                    // Format currency
                    builder.AppendLine(String.Format("{0:C}", fields[4]));
                    builder.AppendLine();
                }
            }            
            rTxtBoxList.Text = builder.ToString();                               
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void rTxtBoxList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
