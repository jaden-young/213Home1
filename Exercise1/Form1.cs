using System;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void treeUndergraduate_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Pass this form to the student editor form to
            // allow it to change the contents of this forms
            // student rosters
            formAddStudent addForm = new formAddStudent(this);
            addForm.Show(this);
        }


        public void addUnderGraduate(UnderGraduate newStudent)
        {
            rTextBoxUnder.AppendText(newStudent.toString() + "\n");
            rTextBoxUnder.Visible = true;
        }

        public void addGraduateStudent(GraduateStudent newStudent)
        {
            rTextBoxGrad.AppendText(newStudent.toString() + "\n");
            rTextBoxGrad.Visible = true;
        }

        private void buttonUndergraduateClear_Click(object sender, EventArgs e)
        {
            rTextBoxUnder.Clear();
            rTextBoxUnder.Visible = false;
        }

        private void buttonGraduateClear_Click(object sender, EventArgs e)
        {
            rTextBoxGrad.Clear();
            rTextBoxGrad.Visible = false;
        }

        private void rTextBoxUnder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
