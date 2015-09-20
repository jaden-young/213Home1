namespace Exercise2
{
    partial class FormConfirmation
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
            this.lblOK = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxSelections = new System.Windows.Forms.GroupBox();
            this.lblSelections = new System.Windows.Forms.Label();
            this.grpBoxSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Location = new System.Drawing.Point(169, 188);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(76, 13);
            this.lblOK.TabIndex = 1;
            this.lblOK.Text = "Is this correct?";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(327, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBoxSelections
            // 
            this.grpBoxSelections.Controls.Add(this.lblSelections);
            this.grpBoxSelections.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSelections.Name = "grpBoxSelections";
            this.grpBoxSelections.Size = new System.Drawing.Size(390, 173);
            this.grpBoxSelections.TabIndex = 8;
            this.grpBoxSelections.TabStop = false;
            this.grpBoxSelections.Text = "You have selected:";
            // 
            // lblSelections
            // 
            this.lblSelections.AutoSize = true;
            this.lblSelections.Location = new System.Drawing.Point(157, 16);
            this.lblSelections.Name = "lblSelections";
            this.lblSelections.Size = new System.Drawing.Size(0, 13);
            this.lblSelections.TabIndex = 0;
            // 
            // FormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 264);
            this.Controls.Add(this.grpBoxSelections);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOK);
            this.Name = "FormConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grpBoxSelections.ResumeLayout(false);
            this.grpBoxSelections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBoxSelections;
        private System.Windows.Forms.Label lblSelections;
    }
}