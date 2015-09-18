using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class FormConfirmation : Form
    {
        private FormMain mainForm;

        public FormConfirmation(FormMain starterForm) 
        {
            InitializeComponent();
            mainForm = starterForm;
            
            lblSelections.Text = mainForm.Selections;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mainForm.clearSelections();
            this.Hide();
            MessageBox.Show("Your reservations have been saved!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
