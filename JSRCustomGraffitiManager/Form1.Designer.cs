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
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.pictureBoxXL = new System.Windows.Forms.PictureBox();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenJSRSave = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDeleteCurrentGraffiti = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxSprays = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Location = new System.Drawing.Point(124, 12);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(453, 20);
            this.textBoxSaveFolder.TabIndex = 1;
            // 
            // pictureBoxXL
            // 
            this.pictureBoxXL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxXL.Location = new System.Drawing.Point(154, 173);
            this.pictureBoxXL.Name = "pictureBoxXL";
            this.pictureBoxXL.Size = new System.Drawing.Size(512, 128);
            this.pictureBoxXL.TabIndex = 2;
            this.pictureBoxXL.TabStop = false;
            this.pictureBoxXL.Visible = false;
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxL.Location = new System.Drawing.Point(410, 173);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(256, 128);
            this.pictureBoxL.TabIndex = 4;
            this.pictureBoxL.TabStop = false;
            this.pictureBoxL.Visible = false;
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxS.Location = new System.Drawing.Point(538, 173);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxS.TabIndex = 5;
            this.pictureBoxS.TabStop = false;
            this.pictureBoxS.Visible = false;
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
            this.buttonOpenJSRSave.Location = new System.Drawing.Point(583, 10);
            this.buttonOpenJSRSave.Name = "buttonOpenJSRSave";
            this.buttonOpenJSRSave.Size = new System.Drawing.Size(83, 23);
            this.buttonOpenJSRSave.TabIndex = 7;
            this.buttonOpenJSRSave.Text = "Open...";
            this.buttonOpenJSRSave.UseVisualStyleBackColor = true;
            this.buttonOpenJSRSave.Click += new System.EventHandler(this.buttonOpenJSRSave_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Location = new System.Drawing.Point(12, 289);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(136, 41);
            this.buttonImport.TabIndex = 8;
            this.buttonImport.Text = "Import New Graffiti...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDeleteCurrentGraffiti
            // 
            this.buttonDeleteCurrentGraffiti.Location = new System.Drawing.Point(485, 307);
            this.buttonDeleteCurrentGraffiti.Name = "buttonDeleteCurrentGraffiti";
            this.buttonDeleteCurrentGraffiti.Size = new System.Drawing.Size(181, 23);
            this.buttonDeleteCurrentGraffiti.TabIndex = 9;
            this.buttonDeleteCurrentGraffiti.Text = "Delete Selected Graffiti";
            this.buttonDeleteCurrentGraffiti.UseVisualStyleBackColor = true;
            this.buttonDeleteCurrentGraffiti.Click += new System.EventHandler(this.buttonDeleteCurrentGraffiti_Click);
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
            // listBoxSprays
            // 
            this.listBoxSprays.FormattingEnabled = true;
            this.listBoxSprays.Location = new System.Drawing.Point(12, 61);
            this.listBoxSprays.Name = "listBoxSprays";
            this.listBoxSprays.Size = new System.Drawing.Size(136, 225);
            this.listBoxSprays.TabIndex = 11;
            this.listBoxSprays.SelectedIndexChanged += new System.EventHandler(this.listBoxSprays_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 342);
            this.Controls.Add(this.listBoxSprays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteCurrentGraffiti);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonOpenJSRSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.pictureBoxL);
            this.Controls.Add(this.pictureBoxXL);
            this.Controls.Add(this.textBoxSaveFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonDeleteCurrentGraffiti;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxSprays;
    }
}

