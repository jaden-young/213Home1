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

        // Require an object of FormMain to construct
        // no point in showing this form without access to 
        // user selections
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
            // They aren't actually saved in any sort of data structure.
            // Not part of the assignment.
            MessageBox.Show("Your reservations have been saved!\n"
                            + "Ready for next user.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
