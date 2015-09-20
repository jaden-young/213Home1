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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        // Shows an additional option to select the size of Ski Boots when
        // a user opts to reserve them
        private void chkBoxSkiBoots_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSkiBoots.Checked)
            {
                lblSize.Visible = true;
                upDownSize.Visible = true;
            }
            else
            {
                lblSize.Visible = false;
                upDownSize.Visible = false;
            }
        }

        private string selections;
        public string Selections
        {
            get
            {
                return selections;
            }
            // setter is private to prevent changes being made
            // from confirmation form
            private set
            {
                selections = value;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // reset resultant string to empty
            Selections = "";

            // StringBuilder, while not as pretty as concatenation, is 
            // much more efficient.
            StringBuilder selectionsB = new StringBuilder();
            if (chkBoxSkiBoots.Checked)
            {
                selectionsB.AppendLine();
                selectionsB.Append("Size ");
                selectionsB.Append(upDownSize.Text);
                selectionsB.AppendLine(" Ski boots");
                selectionsB.AppendLine();
            }
            if (chkBoxSkis.Checked)
            {
                selectionsB.AppendLine("Skis");
                selectionsB.AppendLine();
            }
            if (chkBoxGoggles.Checked)
            {
                selectionsB.AppendLine("Goggles");
                selectionsB.AppendLine();
            }
            if (chkBoxEarmuffs.Checked)
            {
                selectionsB.AppendLine("Earmuffs");
                selectionsB.AppendLine();
            }
            if (chkBoxSnowGloves.Checked)
            {
                selectionsB.AppendLine("Snow Gloves");
            }
            Selections = selectionsB.ToString();

            // Show a confirmation form, passing this form as an argument
            // to allow the new form to read which boxes are checked
            FormConfirmation confForm = new FormConfirmation(this);
            confForm.Show();
        }

        // Uncheckes all boxes
        public void clearSelections()
        {
            chkBoxSkiBoots.Checked = false;
            chkBoxSkis.Checked = false;
            chkBoxGoggles.Checked = false;
            chkBoxEarmuffs.Checked = false;
            chkBoxSnowGloves.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearSelections();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
