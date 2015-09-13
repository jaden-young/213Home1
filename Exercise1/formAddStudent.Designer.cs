namespace Exercise1
{
    partial class formAddStudent
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
            this.radioButtonUndergraduate = new System.Windows.Forms.RadioButton();
            this.radioButtonGraduate = new System.Windows.Forms.RadioButton();
            this.groupBoxUndergraduate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUnderName = new System.Windows.Forms.TextBox();
            this.textBoxGuardName = new System.Windows.Forms.TextBox();
            this.textBoxGuardAddress = new System.Windows.Forms.TextBox();
            this.comboBoxClassification = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxGraduate = new System.Windows.Forms.GroupBox();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.textBoxInstitution = new System.Windows.Forms.TextBox();
            this.textBoxGradName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxUndergraduate.SuspendLayout();
            this.groupBoxGraduate.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonUndergraduate
            // 
            this.radioButtonUndergraduate.AutoSize = true;
            this.radioButtonUndergraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUndergraduate.Location = new System.Drawing.Point(53, 39);
            this.radioButtonUndergraduate.Name = "radioButtonUndergraduate";
            this.radioButtonUndergraduate.Size = new System.Drawing.Size(196, 24);
            this.radioButtonUndergraduate.TabIndex = 0;
            this.radioButtonUndergraduate.TabStop = true;
            this.radioButtonUndergraduate.Text = "Undergraduate Student";
            this.radioButtonUndergraduate.UseVisualStyleBackColor = true;
            this.radioButtonUndergraduate.CheckedChanged += new System.EventHandler(this.radioButtonUndergraduate_CheckedChanged);
            // 
            // radioButtonGraduate
            // 
            this.radioButtonGraduate.AutoSize = true;
            this.radioButtonGraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGraduate.Location = new System.Drawing.Point(351, 39);
            this.radioButtonGraduate.Name = "radioButtonGraduate";
            this.radioButtonGraduate.Size = new System.Drawing.Size(156, 24);
            this.radioButtonGraduate.TabIndex = 1;
            this.radioButtonGraduate.TabStop = true;
            this.radioButtonGraduate.Text = "Graduate Student";
            this.radioButtonGraduate.UseVisualStyleBackColor = true;
            this.radioButtonGraduate.CheckedChanged += new System.EventHandler(this.radioButtonGraduate_CheckedChanged);
            // 
            // groupBoxUndergraduate
            // 
            this.groupBoxUndergraduate.Controls.Add(this.comboBoxClassification);
            this.groupBoxUndergraduate.Controls.Add(this.textBoxGuardAddress);
            this.groupBoxUndergraduate.Controls.Add(this.textBoxGuardName);
            this.groupBoxUndergraduate.Controls.Add(this.textBoxUnderName);
            this.groupBoxUndergraduate.Controls.Add(this.label4);
            this.groupBoxUndergraduate.Controls.Add(this.label3);
            this.groupBoxUndergraduate.Controls.Add(this.label2);
            this.groupBoxUndergraduate.Controls.Add(this.label1);
            this.groupBoxUndergraduate.Location = new System.Drawing.Point(12, 84);
            this.groupBoxUndergraduate.Name = "groupBoxUndergraduate";
            this.groupBoxUndergraduate.Size = new System.Drawing.Size(581, 299);
            this.groupBoxUndergraduate.TabIndex = 2;
            this.groupBoxUndergraduate.TabStop = false;
            this.groupBoxUndergraduate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guardian\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Guardian\'s Address";
            // 
            // textBoxUnderName
            // 
            this.textBoxUnderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnderName.Location = new System.Drawing.Point(339, 34);
            this.textBoxUnderName.Name = "textBoxUnderName";
            this.textBoxUnderName.Size = new System.Drawing.Size(203, 40);
            this.textBoxUnderName.TabIndex = 4;
            // 
            // textBoxGuardName
            // 
            this.textBoxGuardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuardName.Location = new System.Drawing.Point(339, 166);
            this.textBoxGuardName.Name = "textBoxGuardName";
            this.textBoxGuardName.Size = new System.Drawing.Size(203, 40);
            this.textBoxGuardName.TabIndex = 5;
            // 
            // textBoxGuardAddress
            // 
            this.textBoxGuardAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuardAddress.Location = new System.Drawing.Point(339, 234);
            this.textBoxGuardAddress.Name = "textBoxGuardAddress";
            this.textBoxGuardAddress.Size = new System.Drawing.Size(203, 40);
            this.textBoxGuardAddress.TabIndex = 6;
            // 
            // comboBoxClassification
            // 
            this.comboBoxClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassification.FormattingEnabled = true;
            this.comboBoxClassification.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.comboBoxClassification.Location = new System.Drawing.Point(339, 98);
            this.comboBoxClassification.Name = "comboBoxClassification";
            this.comboBoxClassification.Size = new System.Drawing.Size(203, 41);
            this.comboBoxClassification.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(225, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 37);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxGraduate
            // 
            this.groupBoxGraduate.Controls.Add(this.comboBoxDegree);
            this.groupBoxGraduate.Controls.Add(this.textBoxInstitution);
            this.groupBoxGraduate.Controls.Add(this.textBoxGradName);
            this.groupBoxGraduate.Controls.Add(this.label6);
            this.groupBoxGraduate.Controls.Add(this.label7);
            this.groupBoxGraduate.Controls.Add(this.label8);
            this.groupBoxGraduate.Location = new System.Drawing.Point(12, 84);
            this.groupBoxGraduate.Name = "groupBoxGraduate";
            this.groupBoxGraduate.Size = new System.Drawing.Size(581, 299);
            this.groupBoxGraduate.TabIndex = 8;
            this.groupBoxGraduate.TabStop = false;
            this.groupBoxGraduate.Visible = false;
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Items.AddRange(new object[] {
            "B.A.",
            "B.S."});
            this.comboBoxDegree.Location = new System.Drawing.Point(339, 98);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new System.Drawing.Size(203, 41);
            this.comboBoxDegree.TabIndex = 7;
            this.comboBoxDegree.ValueMember = "Classification";
            // 
            // textBoxInstitution
            // 
            this.textBoxInstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstitution.Location = new System.Drawing.Point(339, 166);
            this.textBoxInstitution.Name = "textBoxInstitution";
            this.textBoxInstitution.Size = new System.Drawing.Size(203, 40);
            this.textBoxInstitution.TabIndex = 5;
            // 
            // textBoxGradName
            // 
            this.textBoxGradName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGradName.Location = new System.Drawing.Point(339, 34);
            this.textBoxGradName.Name = "textBoxGradName";
            this.textBoxGradName.Size = new System.Drawing.Size(203, 40);
            this.textBoxGradName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Institution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Degree";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // formAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 444);
            this.Controls.Add(this.groupBoxGraduate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxUndergraduate);
            this.Controls.Add(this.radioButtonGraduate);
            this.Controls.Add(this.radioButtonUndergraduate);
            this.Name = "formAddStudent";
            this.Text = "Student Editor";
            this.groupBoxUndergraduate.ResumeLayout(false);
            this.groupBoxUndergraduate.PerformLayout();
            this.groupBoxGraduate.ResumeLayout(false);
            this.groupBoxGraduate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonUndergraduate;
        private System.Windows.Forms.RadioButton radioButtonGraduate;
        private System.Windows.Forms.GroupBox groupBoxUndergraduate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClassification;
        private System.Windows.Forms.TextBox textBoxGuardAddress;
        private System.Windows.Forms.TextBox textBoxGuardName;
        private System.Windows.Forms.TextBox textBoxUnderName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxGraduate;
        private System.Windows.Forms.ComboBox comboBoxDegree;
        private System.Windows.Forms.TextBox textBoxInstitution;
        private System.Windows.Forms.TextBox textBoxGradName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}