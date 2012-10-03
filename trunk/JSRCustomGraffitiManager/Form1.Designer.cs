namespace JSRCustomGraffitiManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.pictureBoxXL = new System.Windows.Forms.PictureBox();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenJSRSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonReplaceXL = new System.Windows.Forms.Button();
            this.buttonReplaceL = new System.Windows.Forms.Button();
            this.buttonReplaceS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSaveSlots = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNoGraffitiWarningXL = new System.Windows.Forms.Label();
            this.labelNoGraffitiWarningS = new System.Windows.Forms.Label();
            this.labelNoGraffitiWarningL = new System.Windows.Forms.Label();
            this.labelProTip3 = new System.Windows.Forms.Label();
            this.labelProTip1 = new System.Windows.Forms.Label();
            this.labelProTip2 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.BackColor = System.Drawing.Color.White;
            this.textBoxSaveFolder.Enabled = false;
            this.textBoxSaveFolder.Location = new System.Drawing.Point(124, 12);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(304, 20);
            this.textBoxSaveFolder.TabIndex = 1;
            // 
            // pictureBoxXL
            // 
            this.pictureBoxXL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxXL.Location = new System.Drawing.Point(15, 321);
            this.pictureBoxXL.Name = "pictureBoxXL";
            this.pictureBoxXL.Size = new System.Drawing.Size(512, 128);
            this.pictureBoxXL.TabIndex = 2;
            this.pictureBoxXL.TabStop = false;
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxL.Location = new System.Drawing.Point(271, 129);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(256, 128);
            this.pictureBoxL.TabIndex = 4;
            this.pictureBoxL.TabStop = false;
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxS.Location = new System.Drawing.Point(15, 129);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxS.TabIndex = 5;
            this.pictureBoxS.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "JSR Save Folder:";
            // 
            // buttonOpenJSRSave
            // 
            this.buttonOpenJSRSave.Location = new System.Drawing.Point(444, 10);
            this.buttonOpenJSRSave.Name = "buttonOpenJSRSave";
            this.buttonOpenJSRSave.Size = new System.Drawing.Size(83, 23);
            this.buttonOpenJSRSave.TabIndex = 7;
            this.buttonOpenJSRSave.Text = "Open...";
            this.buttonOpenJSRSave.UseVisualStyleBackColor = true;
            this.buttonOpenJSRSave.Click += new System.EventHandler(this.buttonOpenJSRSave_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(121, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(Should be [Your Steam Dir]\\userdata\\[Number]\\205950)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.bmp;*.tif;*.gif;*.tiff;*.jpeg|All files|*.*";
            // 
            // buttonReplaceXL
            // 
            this.buttonReplaceXL.Enabled = false;
            this.buttonReplaceXL.Location = new System.Drawing.Point(232, 455);
            this.buttonReplaceXL.Name = "buttonReplaceXL";
            this.buttonReplaceXL.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceXL.TabIndex = 12;
            this.buttonReplaceXL.Text = "Replace...";
            this.buttonReplaceXL.UseVisualStyleBackColor = true;
            this.buttonReplaceXL.Click += new System.EventHandler(this.buttonReplaceXL_Click);
            // 
            // buttonReplaceL
            // 
            this.buttonReplaceL.Enabled = false;
            this.buttonReplaceL.Location = new System.Drawing.Point(358, 263);
            this.buttonReplaceL.Name = "buttonReplaceL";
            this.buttonReplaceL.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceL.TabIndex = 13;
            this.buttonReplaceL.Text = "Replace...";
            this.buttonReplaceL.UseVisualStyleBackColor = true;
            this.buttonReplaceL.Click += new System.EventHandler(this.buttonReplaceL_Click);
            // 
            // buttonReplaceS
            // 
            this.buttonReplaceS.Enabled = false;
            this.buttonReplaceS.Location = new System.Drawing.Point(45, 263);
            this.buttonReplaceS.Name = "buttonReplaceS";
            this.buttonReplaceS.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceS.TabIndex = 14;
            this.buttonReplaceS.Text = "Replace...";
            this.buttonReplaceS.UseVisualStyleBackColor = true;
            this.buttonReplaceS.Click += new System.EventHandler(this.buttonReplaceS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "512 x 128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "128 x 128";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(268, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "256 x 128";
            // 
            // comboBoxSaveSlots
            // 
            this.comboBoxSaveSlots.Enabled = false;
            this.comboBoxSaveSlots.FormattingEnabled = true;
            this.comboBoxSaveSlots.Location = new System.Drawing.Point(124, 69);
            this.comboBoxSaveSlots.Name = "comboBoxSaveSlots";
            this.comboBoxSaveSlots.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSaveSlots.TabIndex = 18;
            this.comboBoxSaveSlots.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaveSlots_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Save Slot:";
            // 
            // labelNoGraffitiWarningXL
            // 
            this.labelNoGraffitiWarningXL.AutoSize = true;
            this.labelNoGraffitiWarningXL.ForeColor = System.Drawing.Color.Red;
            this.labelNoGraffitiWarningXL.Location = new System.Drawing.Point(23, 330);
            this.labelNoGraffitiWarningXL.Name = "labelNoGraffitiWarningXL";
            this.labelNoGraffitiWarningXL.Size = new System.Drawing.Size(435, 13);
            this.labelNoGraffitiWarningXL.TabIndex = 20;
            this.labelNoGraffitiWarningXL.Text = "You must create a custom graffiti of this size in game before you can import a cu" +
    "stom spray.";
            this.labelNoGraffitiWarningXL.Visible = false;
            // 
            // labelNoGraffitiWarningS
            // 
            this.labelNoGraffitiWarningS.AutoSize = true;
            this.labelNoGraffitiWarningS.ForeColor = System.Drawing.Color.Red;
            this.labelNoGraffitiWarningS.Location = new System.Drawing.Point(23, 138);
            this.labelNoGraffitiWarningS.Name = "labelNoGraffitiWarningS";
            this.labelNoGraffitiWarningS.Size = new System.Drawing.Size(106, 65);
            this.labelNoGraffitiWarningS.TabIndex = 21;
            this.labelNoGraffitiWarningS.Text = "You must create a \ncustom graffiti of this \nsize in game before \nyou can import a" +
    " \ncustom spray.";
            this.labelNoGraffitiWarningS.Visible = false;
            // 
            // labelNoGraffitiWarningL
            // 
            this.labelNoGraffitiWarningL.AutoSize = true;
            this.labelNoGraffitiWarningL.ForeColor = System.Drawing.Color.Red;
            this.labelNoGraffitiWarningL.Location = new System.Drawing.Point(277, 138);
            this.labelNoGraffitiWarningL.Name = "labelNoGraffitiWarningL";
            this.labelNoGraffitiWarningL.Size = new System.Drawing.Size(226, 26);
            this.labelNoGraffitiWarningL.TabIndex = 22;
            this.labelNoGraffitiWarningL.Text = "You must create a custom graffiti of this size \nin game before you can import a c" +
    "ustom spray.";
            this.labelNoGraffitiWarningL.Visible = false;
            // 
            // labelProTip3
            // 
            this.labelProTip3.AutoSize = true;
            this.labelProTip3.ForeColor = System.Drawing.Color.DimGray;
            this.labelProTip3.Location = new System.Drawing.Point(12, 535);
            this.labelProTip3.Name = "labelProTip3";
            this.labelProTip3.Size = new System.Drawing.Size(332, 26);
            this.labelProTip3.TabIndex = 23;
            this.labelProTip3.Text = "Pro Tip: If a spray appears to import correctly, but does not show up \nin-game, t" +
    "ry creating an in-game custom graffiti for that size of spray first!";
            this.labelProTip3.Visible = false;
            // 
            // labelProTip1
            // 
            this.labelProTip1.AutoSize = true;
            this.labelProTip1.ForeColor = System.Drawing.Color.DimGray;
            this.labelProTip1.Location = new System.Drawing.Point(12, 485);
            this.labelProTip1.Name = "labelProTip1";
            this.labelProTip1.Size = new System.Drawing.Size(254, 13);
            this.labelProTip1.TabIndex = 24;
            this.labelProTip1.Text = "Pro Tip: Restart the game after to see your changes!";
            this.labelProTip1.Visible = false;
            // 
            // labelProTip2
            // 
            this.labelProTip2.AutoSize = true;
            this.labelProTip2.ForeColor = System.Drawing.Color.DimGray;
            this.labelProTip2.Location = new System.Drawing.Point(12, 510);
            this.labelProTip2.Name = "labelProTip2";
            this.labelProTip2.Size = new System.Drawing.Size(282, 13);
            this.labelProTip2.TabIndex = 25;
            this.labelProTip2.Text = "Pro Tip: Your custom sprays will be in the \"E\" slot in-game.";
            this.labelProTip2.Visible = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(207, 510);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(128, 48);
            this.buttonHelp.TabIndex = 26;
            this.buttonHelp.Text = "It\'s not working!";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 570);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelProTip2);
            this.Controls.Add(this.labelProTip1);
            this.Controls.Add(this.labelProTip3);
            this.Controls.Add(this.labelNoGraffitiWarningL);
            this.Controls.Add(this.labelNoGraffitiWarningS);
            this.Controls.Add(this.labelNoGraffitiWarningXL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSaveSlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReplaceS);
            this.Controls.Add(this.buttonReplaceL);
            this.Controls.Add(this.buttonReplaceXL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenJSRSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.pictureBoxL);
            this.Controls.Add(this.pictureBoxXL);
            this.Controls.Add(this.textBoxSaveFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jet Set Radio Graffiti Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.PictureBox pictureBoxXL;
        private System.Windows.Forms.PictureBox pictureBoxL;
        private System.Windows.Forms.PictureBox pictureBoxS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenJSRSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonReplaceXL;
        private System.Windows.Forms.Button buttonReplaceL;
        private System.Windows.Forms.Button buttonReplaceS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSaveSlots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNoGraffitiWarningXL;
        private System.Windows.Forms.Label labelNoGraffitiWarningS;
        private System.Windows.Forms.Label labelNoGraffitiWarningL;
        private System.Windows.Forms.Label labelProTip3;
        private System.Windows.Forms.Label labelProTip1;
        private System.Windows.Forms.Label labelProTip2;
        private System.Windows.Forms.Button buttonHelp;
    }
}

