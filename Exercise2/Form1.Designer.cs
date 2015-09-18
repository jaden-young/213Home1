namespace Exercise2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.upDownSize = new System.Windows.Forms.NumericUpDown();
            this.chkBoxSkiBoots = new System.Windows.Forms.CheckBox();
            this.chkBoxEarmuffs = new System.Windows.Forms.CheckBox();
            this.chkBoxGoggles = new System.Windows.Forms.CheckBox();
            this.chkBoxSkis = new System.Windows.Forms.CheckBox();
            this.chkBoxSnowGloves = new System.Windows.Forms.CheckBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Flyers Sports Club";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // grpEquipment
            // 
            this.grpEquipment.Controls.Add(this.lblSize);
            this.grpEquipment.Controls.Add(this.upDownSize);
            this.grpEquipment.Controls.Add(this.chkBoxSkiBoots);
            this.grpEquipment.Controls.Add(this.chkBoxEarmuffs);
            this.grpEquipment.Controls.Add(this.chkBoxGoggles);
            this.grpEquipment.Controls.Add(this.chkBoxSkis);
            this.grpEquipment.Controls.Add(this.chkBoxSnowGloves);
            this.grpEquipment.Controls.Add(this.lblEquipment);
            this.grpEquipment.Location = new System.Drawing.Point(20, 75);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Size = new System.Drawing.Size(369, 168);
            this.grpEquipment.TabIndex = 2;
            this.grpEquipment.TabStop = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(124, 46);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size:";
            this.lblSize.Visible = false;
            // 
            // upDownSize
            // 
            this.upDownSize.Location = new System.Drawing.Point(160, 43);
            this.upDownSize.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.upDownSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.upDownSize.Name = "upDownSize";
            this.upDownSize.Size = new System.Drawing.Size(34, 20);
            this.upDownSize.TabIndex = 8;
            this.upDownSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.upDownSize.Visible = false;
            // 
            // chkBoxSkiBoots
            // 
            this.chkBoxSkiBoots.AutoSize = true;
            this.chkBoxSkiBoots.Location = new System.Drawing.Point(9, 46);
            this.chkBoxSkiBoots.Name = "chkBoxSkiBoots";
            this.chkBoxSkiBoots.Size = new System.Drawing.Size(71, 17);
            this.chkBoxSkiBoots.TabIndex = 7;
            this.chkBoxSkiBoots.Text = "Ski Boots";
            this.chkBoxSkiBoots.UseVisualStyleBackColor = true;
            this.chkBoxSkiBoots.CheckedChanged += new System.EventHandler(this.chkBoxSkiBoots_CheckedChanged);
            // 
            // chkBoxEarmuffs
            // 
            this.chkBoxEarmuffs.AutoSize = true;
            this.chkBoxEarmuffs.Location = new System.Drawing.Point(9, 115);
            this.chkBoxEarmuffs.Name = "chkBoxEarmuffs";
            this.chkBoxEarmuffs.Size = new System.Drawing.Size(67, 17);
            this.chkBoxEarmuffs.TabIndex = 6;
            this.chkBoxEarmuffs.Text = "Earmuffs";
            this.chkBoxEarmuffs.UseVisualStyleBackColor = true;
            // 
            // chkBoxGoggles
            // 
            this.chkBoxGoggles.AutoSize = true;
            this.chkBoxGoggles.Location = new System.Drawing.Point(9, 92);
            this.chkBoxGoggles.Name = "chkBoxGoggles";
            this.chkBoxGoggles.Size = new System.Drawing.Size(65, 17);
            this.chkBoxGoggles.TabIndex = 5;
            this.chkBoxGoggles.Text = "Goggles";
            this.chkBoxGoggles.UseVisualStyleBackColor = true;
            // 
            // chkBoxSkis
            // 
            this.chkBoxSkis.AutoSize = true;
            this.chkBoxSkis.Location = new System.Drawing.Point(9, 69);
            this.chkBoxSkis.Name = "chkBoxSkis";
            this.chkBoxSkis.Size = new System.Drawing.Size(46, 17);
            this.chkBoxSkis.TabIndex = 4;
            this.chkBoxSkis.Text = "Skis";
            this.chkBoxSkis.UseVisualStyleBackColor = true;
            // 
            // chkBoxSnowGloves
            // 
            this.chkBoxSnowGloves.AutoSize = true;
            this.chkBoxSnowGloves.Location = new System.Drawing.Point(9, 138);
            this.chkBoxSnowGloves.Name = "chkBoxSnowGloves";
            this.chkBoxSnowGloves.Size = new System.Drawing.Size(89, 17);
            this.chkBoxSnowGloves.TabIndex = 3;
            this.chkBoxSnowGloves.Text = "Snow Gloves";
            this.chkBoxSnowGloves.UseVisualStyleBackColor = true;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.Location = new System.Drawing.Point(6, 16);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(276, 16);
            this.lblEquipment.TabIndex = 2;
            this.lblEquipment.Text = "Select the equipment you will be checking out";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(43, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(291, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(167, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 280);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpEquipment);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMain";
            this.Text = "Equipment Needs";
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown upDownSize;
        private System.Windows.Forms.CheckBox chkBoxSkiBoots;
        private System.Windows.Forms.CheckBox chkBoxEarmuffs;
        private System.Windows.Forms.CheckBox chkBoxGoggles;
        private System.Windows.Forms.CheckBox chkBoxSkis;
        private System.Windows.Forms.CheckBox chkBoxSnowGloves;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

