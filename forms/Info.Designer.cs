namespace SOR4_Swapper
{
    partial class Info
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
            this.btnRestoreBigfile = new System.Windows.Forms.Button();
            this.labelLoadedSwapFile = new System.Windows.Forms.Label();
            this.labelLoadedSwap = new System.Windows.Forms.Label();
            this.labelBackupMade = new System.Windows.Forms.Label();
            this.labelValidBigfile = new System.Windows.Forms.Label();
            this.labelBigfileLocationInfo = new System.Windows.Forms.Label();
            this.ofdBrowseBigfile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnRestoreBigfile
            // 
            this.btnRestoreBigfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestoreBigfile.Enabled = false;
            this.btnRestoreBigfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBigfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreBigfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestoreBigfile.Location = new System.Drawing.Point(13, 61);
            this.btnRestoreBigfile.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRestoreBigfile.Name = "btnRestoreBigfile";
            this.btnRestoreBigfile.Size = new System.Drawing.Size(138, 23);
            this.btnRestoreBigfile.TabIndex = 63;
            this.btnRestoreBigfile.Text = "Restore original bigfile";
            this.btnRestoreBigfile.UseVisualStyleBackColor = false;
            this.btnRestoreBigfile.Visible = false;
            this.btnRestoreBigfile.Click += new System.EventHandler(this.btnRestoreBigfile_Click);
            // 
            // labelLoadedSwapFile
            // 
            this.labelLoadedSwapFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadedSwapFile.ForeColor = System.Drawing.Color.Black;
            this.labelLoadedSwapFile.Location = new System.Drawing.Point(10, 121);
            this.labelLoadedSwapFile.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelLoadedSwapFile.Name = "labelLoadedSwapFile";
            this.labelLoadedSwapFile.Size = new System.Drawing.Size(498, 16);
            this.labelLoadedSwapFile.TabIndex = 65;
            this.labelLoadedSwapFile.Visible = false;
            this.labelLoadedSwapFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLoadedSwapFile_MouseDown);
            this.labelLoadedSwapFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLoadedSwapFile_MouseMove);
            // 
            // labelLoadedSwap
            // 
            this.labelLoadedSwap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadedSwap.ForeColor = System.Drawing.Color.Black;
            this.labelLoadedSwap.Location = new System.Drawing.Point(10, 105);
            this.labelLoadedSwap.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadedSwap.Name = "labelLoadedSwap";
            this.labelLoadedSwap.Size = new System.Drawing.Size(105, 16);
            this.labelLoadedSwap.TabIndex = 64;
            this.labelLoadedSwap.Text = "Swap list loaded:";
            this.labelLoadedSwap.Visible = false;
            this.labelLoadedSwap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLoadedSwap_MouseDown);
            this.labelLoadedSwap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLoadedSwap_MouseMove);
            // 
            // labelBackupMade
            // 
            this.labelBackupMade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackupMade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBackupMade.Location = new System.Drawing.Point(10, 40);
            this.labelBackupMade.Name = "labelBackupMade";
            this.labelBackupMade.Size = new System.Drawing.Size(498, 15);
            this.labelBackupMade.TabIndex = 62;
            this.labelBackupMade.Visible = false;
            this.labelBackupMade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBackupMade_MouseDown);
            this.labelBackupMade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBackupMade_MouseMove);
            // 
            // labelValidBigfile
            // 
            this.labelValidBigfile.AutoSize = true;
            this.labelValidBigfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidBigfile.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelValidBigfile.Location = new System.Drawing.Point(74, 7);
            this.labelValidBigfile.Name = "labelValidBigfile";
            this.labelValidBigfile.Size = new System.Drawing.Size(97, 13);
            this.labelValidBigfile.TabIndex = 61;
            this.labelValidBigfile.Text = "original v7 bigfile";
            this.labelValidBigfile.Visible = false;
            // 
            // labelBigfileLocationInfo
            // 
            this.labelBigfileLocationInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelBigfileLocationInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBigfileLocationInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBigfileLocationInfo.Location = new System.Drawing.Point(10, 7);
            this.labelBigfileLocationInfo.Name = "labelBigfileLocationInfo";
            this.labelBigfileLocationInfo.Size = new System.Drawing.Size(498, 32);
            this.labelBigfileLocationInfo.TabIndex = 60;
            this.labelBigfileLocationInfo.Text = "To begin, please look for the \"bigfile\" file in your \"/Streets of Rage 4/data/\" f" +
    "older.";
            this.labelBigfileLocationInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBigfileLocationInfo_MouseDown);
            this.labelBigfileLocationInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBigfileLocationInfo_MouseMove);
            // 
            // ofdBrowseBigfile
            // 
            this.ofdBrowseBigfile.FileName = "bigfile";
            this.ofdBrowseBigfile.Filter = "SOR4 bigfile|bigfile";
            this.ofdBrowseBigfile.Title = "Location of \"bigfile\"";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 173);
            this.Controls.Add(this.btnRestoreBigfile);
            this.Controls.Add(this.labelLoadedSwapFile);
            this.Controls.Add(this.labelLoadedSwap);
            this.Controls.Add(this.labelBackupMade);
            this.Controls.Add(this.labelValidBigfile);
            this.Controls.Add(this.labelBigfileLocationInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Info_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Info_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRestoreBigfile;
        public System.Windows.Forms.Label labelLoadedSwapFile;
        public System.Windows.Forms.Label labelLoadedSwap;
        public System.Windows.Forms.Label labelBackupMade;
        public System.Windows.Forms.Label labelValidBigfile;
        public System.Windows.Forms.Label labelBigfileLocationInfo;
        private System.Windows.Forms.OpenFileDialog ofdBrowseBigfile;
    }
}