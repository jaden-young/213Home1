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
            this.rTextBoxUnder = new System.Windows.Forms.RichTextBox();
            this.groupBoxGraduate = new System.Windows.Forms.GroupBox();
            this.rTextBoxGrad = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUndergraduateClear = new System.Windows.Forms.Button();
            this.buttonGraduateClear = new System.Windows.Forms.Button();
            this.groupBoxUndergraduate.SuspendLayout();
            this.groupBoxGraduate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUndergraduate
            // 
            this.groupBoxUndergraduate.Controls.Add(this.rTextBoxUnder);
            this.groupBoxUndergraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUndergraduate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUndergraduate.Name = "groupBoxUndergraduate";
            this.groupBoxUndergraduate.Size = new System.Drawing.Size(303, 366);
            this.groupBoxUndergraduate.TabIndex = 0;
            this.groupBoxUndergraduate.TabStop = false;
            this.groupBoxUndergraduate.Text = "Undergraduate Students";
            // 
            // rTextBoxUnder
            // 
            this.rTextBoxUnder.Location = new System.Drawing.Point(6, 25);
            this.rTextBoxUnder.Name = "rTextBoxUnder";
            this.rTextBoxUnder.Size = new System.Drawing.Size(289, 335);
            this.rTextBoxUnder.TabIndex = 0;
            this.rTextBoxUnder.Text = "";
            // 
            // groupBoxGraduate
            // 
            this.groupBoxGraduate.Controls.Add(this.rTextBoxGrad);
            this.groupBoxGraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGraduate.Location = new System.Drawing.Point(415, 12);
            this.groupBoxGraduate.Name = "groupBoxGraduate";
            this.groupBoxGraduate.Size = new System.Drawing.Size(302, 366);
            this.groupBoxGraduate.TabIndex = 1;
            this.groupBoxGraduate.TabStop = false;
            this.groupBoxGraduate.Text = "Graduate Students";
            // 
            // rTextBoxGrad
            // 
            this.rTextBoxGrad.Location = new System.Drawing.Point(6, 25);
            this.rTextBoxGrad.Name = "rTextBoxGrad";
            this.rTextBoxGrad.Size = new System.Drawing.Size(289, 335);
            this.rTextBoxGrad.TabIndex = 1;
            this.rTextBoxGrad.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(321, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 31);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUndergraduateClear
            // 
            this.buttonUndergraduateClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndergraduateClear.Location = new System.Drawing.Point(123, 384);
            this.buttonUndergraduateClear.Name = "buttonUndergraduateClear";
            this.buttonUndergraduateClear.Size = new System.Drawing.Size(90, 31);
            this.buttonUndergraduateClear.TabIndex = 4;
            this.buttonUndergraduateClear.Text = "Clear";
            this.buttonUndergraduateClear.UseVisualStyleBackColor = true;
            this.buttonUndergraduateClear.Click += new System.EventHandler(this.buttonUndergraduateClear_Click);
            // 
            // buttonGraduateClear
            // 
            this.buttonGraduateClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraduateClear.Location = new System.Drawing.Point(537, 384);
            this.buttonGraduateClear.Name = "buttonGraduateClear";
            this.buttonGraduateClear.Size = new System.Drawing.Size(90, 31);
            this.buttonGraduateClear.TabIndex = 5;
            this.buttonGraduateClear.Text = "Clear";
            this.buttonGraduateClear.UseVisualStyleBackColor = true;
            this.buttonGraduateClear.Click += new System.EventHandler(this.buttonGraduateClear_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 429);
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
        private System.Windows.Forms.GroupBox groupBoxGraduate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUndergraduateClear;
        private System.Windows.Forms.Button buttonGraduateClear;
        private System.Windows.Forms.RichTextBox rTextBoxUnder;
        private System.Windows.Forms.RichTextBox rTextBoxGrad;




    }
}

