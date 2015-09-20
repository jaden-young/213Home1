namespace Exercise3
{
    partial class FormMain
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.mTxtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.grpBoxEditor = new System.Windows.Forms.GroupBox();
            this.bttnChooseFile = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.grpBoxEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(179, 46);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(206, 26);
            this.txtBoxName.TabIndex = 0;
            // 
            // mTxtBoxPhoneNumber
            // 
            this.mTxtBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxPhoneNumber.Location = new System.Drawing.Point(179, 160);
            this.mTxtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.mTxtBoxPhoneNumber.Name = "mTxtBoxPhoneNumber";
            this.mTxtBoxPhoneNumber.Size = new System.Drawing.Size(120, 26);
            this.mTxtBoxPhoneNumber.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(21, 160);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(179, 99);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(206, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // grpBoxEditor
            // 
            this.grpBoxEditor.Controls.Add(this.lblFailure);
            this.grpBoxEditor.Controls.Add(this.lblSuccess);
            this.grpBoxEditor.Controls.Add(this.lblName);
            this.grpBoxEditor.Controls.Add(this.txtBoxEmail);
            this.grpBoxEditor.Controls.Add(this.txtBoxName);
            this.grpBoxEditor.Controls.Add(this.lblPhoneNumber);
            this.grpBoxEditor.Controls.Add(this.mTxtBoxPhoneNumber);
            this.grpBoxEditor.Controls.Add(this.lblEmail);
            this.grpBoxEditor.Location = new System.Drawing.Point(12, 12);
            this.grpBoxEditor.Name = "grpBoxEditor";
            this.grpBoxEditor.Size = new System.Drawing.Size(418, 233);
            this.grpBoxEditor.TabIndex = 6;
            this.grpBoxEditor.TabStop = false;
            this.grpBoxEditor.Text = "Add a person to the file";
            // 
            // bttnChooseFile
            // 
            this.bttnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChooseFile.Location = new System.Drawing.Point(168, 261);
            this.bttnChooseFile.Name = "bttnChooseFile";
            this.bttnChooseFile.Size = new System.Drawing.Size(115, 37);
            this.bttnChooseFile.TabIndex = 7;
            this.bttnChooseFile.Text = "Choose File";
            this.bttnChooseFile.UseVisualStyleBackColor = true;
            this.bttnChooseFile.Click += new System.EventHandler(this.bttnChooseFile_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.Location = new System.Drawing.Point(12, 310);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(115, 37);
            this.bttnAdd.TabIndex = 8;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.Location = new System.Drawing.Point(315, 310);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(115, 37);
            this.bttnClear.TabIndex = 9;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "PersonList";
            this.saveFileDialog1.Filter = "Text Files|.txt";
            this.saveFileDialog1.Title = "Save As";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(22, 208);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(183, 13);
            this.lblSuccess.TabIndex = 6;
            this.lblSuccess.Text = "Person has been added successfully!";
            this.lblSuccess.Visible = false;
            this.lblSuccess.Click += new System.EventHandler(this.lblSuccess_Click);
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Location = new System.Drawing.Point(22, 208);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(94, 13);
            this.lblFailure.TabIndex = 7;
            this.lblFailure.Text = "Person not added.";
            this.lblFailure.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 359);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnChooseFile);
            this.Controls.Add(this.grpBoxEditor);
            this.Name = "FormMain";
            this.Text = "Person Editor";
            this.grpBoxEditor.ResumeLayout(false);
            this.grpBoxEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.MaskedTextBox mTxtBoxPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.GroupBox grpBoxEditor;
        private System.Windows.Forms.Button bttnChooseFile;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Label lblSuccess;

    }
}

