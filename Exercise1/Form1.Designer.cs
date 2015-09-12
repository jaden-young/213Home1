namespace Exercise1
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUndergraduate = new System.Windows.Forms.GroupBox();
            this.groupBoxGraduate = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUndergraduateClear = new System.Windows.Forms.Button();
            this.buttonGraduateClear = new System.Windows.Forms.Button();
            this.treeUndergraduate = new System.Windows.Forms.TreeView();
            this.treeGraduate = new System.Windows.Forms.TreeView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxUndergraduate.SuspendLayout();
            this.groupBoxGraduate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUndergraduate
            // 
            this.groupBoxUndergraduate.Controls.Add(this.treeUndergraduate);
            this.groupBoxUndergraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUndergraduate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUndergraduate.Name = "groupBoxUndergraduate";
            this.groupBoxUndergraduate.Size = new System.Drawing.Size(309, 366);
            this.groupBoxUndergraduate.TabIndex = 0;
            this.groupBoxUndergraduate.TabStop = false;
            this.groupBoxUndergraduate.Text = "Undergraduate Students";
            // 
            // groupBoxGraduate
            // 
            this.groupBoxGraduate.Controls.Add(this.treeGraduate);
            this.groupBoxGraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGraduate.Location = new System.Drawing.Point(415, 12);
            this.groupBoxGraduate.Name = "groupBoxGraduate";
            this.groupBoxGraduate.Size = new System.Drawing.Size(301, 366);
            this.groupBoxGraduate.TabIndex = 1;
            this.groupBoxGraduate.TabStop = false;
            this.groupBoxGraduate.Text = "Graduate Students";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(327, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 31);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUndergraduateClear
            // 
            this.buttonUndergraduateClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndergraduateClear.Location = new System.Drawing.Point(18, 384);
            this.buttonUndergraduateClear.Name = "buttonUndergraduateClear";
            this.buttonUndergraduateClear.Size = new System.Drawing.Size(90, 31);
            this.buttonUndergraduateClear.TabIndex = 4;
            this.buttonUndergraduateClear.Text = "Clear";
            this.buttonUndergraduateClear.UseVisualStyleBackColor = true;
            // 
            // buttonGraduateClear
            // 
            this.buttonGraduateClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraduateClear.Location = new System.Drawing.Point(421, 384);
            this.buttonGraduateClear.Name = "buttonGraduateClear";
            this.buttonGraduateClear.Size = new System.Drawing.Size(90, 31);
            this.buttonGraduateClear.TabIndex = 5;
            this.buttonGraduateClear.Text = "Clear";
            this.buttonGraduateClear.UseVisualStyleBackColor = true;
            // 
            // treeUndergraduate
            // 
            this.treeUndergraduate.Location = new System.Drawing.Point(6, 25);
            this.treeUndergraduate.Name = "treeUndergraduate";
            this.treeUndergraduate.Size = new System.Drawing.Size(295, 335);
            this.treeUndergraduate.TabIndex = 1;
            this.treeUndergraduate.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeUndergraduate_AfterSelect);
            // 
            // treeGraduate
            // 
            this.treeGraduate.Location = new System.Drawing.Point(6, 25);
            this.treeGraduate.Name = "treeGraduate";
            this.treeGraduate.Size = new System.Drawing.Size(289, 335);
            this.treeGraduate.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(327, 223);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(82, 31);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 430);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonGraduateClear);
            this.Controls.Add(this.buttonUndergraduateClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxGraduate);
            this.Controls.Add(this.groupBoxUndergraduate);
            this.Name = "formMain";
            this.Text = "Student Roster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUndergraduate.ResumeLayout(false);
            this.groupBoxGraduate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUndergraduate;
        private System.Windows.Forms.TreeView treeUndergraduate;
        private System.Windows.Forms.GroupBox groupBoxGraduate;
        private System.Windows.Forms.TreeView treeGraduate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUndergraduateClear;
        private System.Windows.Forms.Button buttonGraduateClear;
        private System.Windows.Forms.Button buttonRemove;




    }
}

