﻿using System;
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
            formAddStudent addForm = new formAddStudent(this);
            addForm.Show(this);
        }

        public void addUnderGraduate(UnderGraduate newStudent)
        {
            rTextBoxUnder.AppendText(newStudent.toString());
        }

        public void addGraduateStudent(GraduateStudent newStudent)
        {
            rTextBoxGrad.AppendText(newStudent.toString());
        }

        private void buttonUndergraduateClear_Click(object sender, EventArgs e)
        {
            rTextBoxUnder.Clear();
        }

        private void buttonGraduateClear_Click(object sender, EventArgs e)
        {
            rTextBoxGrad.Clear();
        }
    }
}
