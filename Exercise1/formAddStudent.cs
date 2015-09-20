using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class formAddStudent : Form
    {
        private formMain mainForm;
        
        // No default constructor is provided because this form
        // is useless without the ability to add to the contents
        // of the main form's student roster
        public formAddStudent(formMain starterForm)
        {
            InitializeComponent();
            mainForm = starterForm;
        }


        // I really wish visual studio didn't yell at me
        // for removing useless auto implemented code like this
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Changes which editor is visible based on which radio button
        // is checked. Both graduate and undergraduate are handled by
        // a change in the undergraduate button.
        private void radioButtonUndergraduate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUndergraduate.Checked)
            {
                groupBoxUndergraduate.Visible = true;
                groupBoxGraduate.Visible = false;
            }
            else 
            {
                groupBoxUndergraduate.Visible = false;
                groupBoxGraduate.Visible = true;
            }
        }
        
        private void radioButtonGraduate_CheckedChanged(object sender, EventArgs e)
        {
           // do nothing
           // code here would be redundant, handled by Undergraduate radio button
        }

        // Adds the student to the roster on the main form
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonUndergraduate.Checked)
            {
                UnderGraduate myStudent = new UnderGraduate(textBoxUnderName.Text,
                                                                  comboBoxClassification.Text,
                                                                  textBoxGuardName.Text,
                                                                  textBoxGuardAddress.Text);
                mainForm.addUnderGraduate(myStudent);
            }
            else
            {
                GraduateStudent myStudent = new GraduateStudent(textBoxGradName.Text,
                                                                    comboBoxDegree.Text,
                                                                    textBoxInstitution.Text);
                mainForm.addGraduateStudent(myStudent);
            }
            this.Hide();

        }
    }
}
