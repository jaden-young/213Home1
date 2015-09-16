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
        
        
        public formAddStudent()
        {
            InitializeComponent();
        }

        public formAddStudent(formMain starterForm) : this()
        {
            mainForm = starterForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
           
        }

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
