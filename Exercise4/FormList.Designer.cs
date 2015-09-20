namespace Exercise4
{
    partial class FormList
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
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.rTxtBoxList = new System.Windows.Forms.RichTextBox();
            this.bttnClose = new System.Windows.Forms.Button();
            this.grpBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxList
            // 
            this.grpBoxList.Controls.Add(this.rTxtBoxList);
            this.grpBoxList.Location = new System.Drawing.Point(12, 12);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(327, 353);
            this.grpBoxList.TabIndex = 0;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "Employee List";
            // 
            // rTxtBoxList
            // 
            this.rTxtBoxList.Location = new System.Drawing.Point(7, 20);
            this.rTxtBoxList.Name = "rTxtBoxList";
            this.rTxtBoxList.Size = new System.Drawing.Size(314, 327);
            this.rTxtBoxList.TabIndex = 0;
            this.rTxtBoxList.Text = "";
            this.rTxtBoxList.TextChanged += new System.EventHandler(this.rTxtBoxList_TextChanged);
            // 
            // bttnClose
            // 
            this.bttnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.Location = new System.Drawing.Point(113, 371);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(115, 37);
            this.bttnClose.TabIndex = 13;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 420);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.grpBoxList);
            this.Name = "FormList";
            this.Text = "Employee List";
            this.grpBoxList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxList;
        private System.Windows.Forms.RichTextBox rTxtBoxList;
        private System.Windows.Forms.Button bttnClose;
    }
}