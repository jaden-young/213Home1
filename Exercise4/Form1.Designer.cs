namespace Exercise4
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
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnChooseFile = new System.Windows.Forms.Button();
            this.grpBoxEditor = new System.Windows.Forms.GroupBox();
            this.txtBoxHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.lblFailure = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttnViewList = new System.Windows.Forms.Button();
            this.grpBoxEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnClear
            // 
            this.bttnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.Location = new System.Drawing.Point(26, 364);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(115, 37);
            this.bttnClear.TabIndex = 13;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.Location = new System.Drawing.Point(26, 315);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(115, 37);
            this.bttnAdd.TabIndex = 12;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnChooseFile
            // 
            this.bttnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChooseFile.Location = new System.Drawing.Point(282, 315);
            this.bttnChooseFile.Name = "bttnChooseFile";
            this.bttnChooseFile.Size = new System.Drawing.Size(115, 37);
            this.bttnChooseFile.TabIndex = 11;
            this.bttnChooseFile.Text = "Choose File";
            this.bttnChooseFile.UseVisualStyleBackColor = true;
            this.bttnChooseFile.Click += new System.EventHandler(this.bttnChooseFile_Click);
            // 
            // grpBoxEditor
            // 
            this.grpBoxEditor.Controls.Add(this.txtBoxHours);
            this.grpBoxEditor.Controls.Add(this.label1);
            this.grpBoxEditor.Controls.Add(this.txtBoxRate);
            this.grpBoxEditor.Controls.Add(this.lblFailure);
            this.grpBoxEditor.Controls.Add(this.lblSuccess);
            this.grpBoxEditor.Controls.Add(this.lblName);
            this.grpBoxEditor.Controls.Add(this.txtBoxNumber);
            this.grpBoxEditor.Controls.Add(this.txtBoxName);
            this.grpBoxEditor.Controls.Add(this.lblPayRate);
            this.grpBoxEditor.Controls.Add(this.lblNumber);
            this.grpBoxEditor.Location = new System.Drawing.Point(12, 12);
            this.grpBoxEditor.Name = "grpBoxEditor";
            this.grpBoxEditor.Size = new System.Drawing.Size(418, 282);
            this.grpBoxEditor.TabIndex = 10;
            this.grpBoxEditor.TabStop = false;
            this.grpBoxEditor.Text = "Add an Employee to the file";
            // 
            // txtBoxHours
            // 
            this.txtBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHours.Location = new System.Drawing.Point(179, 202);
            this.txtBoxHours.Name = "txtBoxHours";
            this.txtBoxHours.Size = new System.Drawing.Size(206, 26);
            this.txtBoxHours.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hours Worked";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRate.Location = new System.Drawing.Point(179, 150);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(206, 26);
            this.txtBoxRate.TabIndex = 8;
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Location = new System.Drawing.Point(22, 255);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(107, 13);
            this.lblFailure.TabIndex = 7;
            this.lblFailure.Text = "Employee not added.";
            this.lblFailure.Visible = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(22, 255);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(196, 13);
            this.lblSuccess.TabIndex = 6;
            this.lblSuccess.Text = "Employee has been added successfully!";
            this.lblSuccess.Visible = false;
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
            // txtBoxNumber
            // 
            this.txtBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(179, 96);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(206, 26);
            this.txtBoxNumber.TabIndex = 5;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(179, 46);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(206, 26);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(21, 153);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(74, 20);
            this.lblPayRate.TabIndex = 4;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(21, 99);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(86, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "ID Number";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "EmployeeList.txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            this.saveFileDialog1.Title = "Choose a file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // bttnViewList
            // 
            this.bttnViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnViewList.Location = new System.Drawing.Point(282, 364);
            this.bttnViewList.Name = "bttnViewList";
            this.bttnViewList.Size = new System.Drawing.Size(115, 37);
            this.bttnViewList.TabIndex = 14;
            this.bttnViewList.Text = "View List";
            this.bttnViewList.UseVisualStyleBackColor = true;
            this.bttnViewList.Click += new System.EventHandler(this.bttnViewList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 419);
            this.Controls.Add(this.bttnViewList);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnChooseFile);
            this.Controls.Add(this.grpBoxEditor);
            this.Name = "FormMain";
            this.Text = "Employee Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpBoxEditor.ResumeLayout(false);
            this.grpBoxEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnChooseFile;
        private System.Windows.Forms.GroupBox grpBoxEditor;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtBoxHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bttnViewList;

    }
}

