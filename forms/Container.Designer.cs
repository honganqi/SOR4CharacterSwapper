namespace SOR4_Swapper
{
    partial class Container
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
            this.components = new System.ComponentModel.Container();
            this.labelSupport = new System.Windows.Forms.Label();
            this.imgBMCSupport = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnStartReplace = new System.Windows.Forms.Button();
            this.imgSF = new System.Windows.Forms.PictureBox();
            this.imgYoutube = new System.Windows.Forms.PictureBox();
            this.imgTwitch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipYoutube = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTwitch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCoffee = new System.Windows.Forms.ToolTip(this.components);
            this.labelPending = new System.Windows.Forms.Label();
            this.btnCharPanel = new System.Windows.Forms.Button();
            this.btnItemPanel = new System.Windows.Forms.Button();
            this.panelDivider = new System.Windows.Forms.Label();
            this.btnDestroyablesPanel = new System.Windows.Forms.Button();
            this.btnLevelPanel = new System.Windows.Forms.Button();
            this.btnClearAllSwaps = new System.Windows.Forms.Button();
            this.btnPresetsPanel = new System.Windows.Forms.Button();
            this.panelDifficulty = new System.Windows.Forms.Panel();
            this.panelOwner = new System.Windows.Forms.Panel();
            this.btnClearAllCustomizations = new System.Windows.Forms.Button();
            this.btnUpdateNotif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSupport.Location = new System.Drawing.Point(10, 666);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(86, 15);
            this.labelSupport.TabIndex = 61;
            this.labelSupport.Text = "Support me on";
            this.labelSupport.Visible = false;
            // 
            // imgBMCSupport
            // 
            this.imgBMCSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBMCSupport.InitialImage = null;
            this.imgBMCSupport.Location = new System.Drawing.Point(12, 675);
            this.imgBMCSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBMCSupport.Name = "imgBMCSupport";
            this.imgBMCSupport.Size = new System.Drawing.Size(152, 43);
            this.imgBMCSupport.TabIndex = 60;
            this.imgBMCSupport.TabStop = false;
            this.toolTipCoffee.SetToolTip(this.imgBMCSupport, "Any support is appreciated! Thank you!");
            this.imgBMCSupport.Click += new System.EventHandler(this.imgBMCSupport_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 174);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(520, 421);
            this.panelMain.TabIndex = 62;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(520, 146);
            this.panelInfo.TabIndex = 63;
            // 
            // btnStartReplace
            // 
            this.btnStartReplace.Enabled = false;
            this.btnStartReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartReplace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReplace.Location = new System.Drawing.Point(88, 606);
            this.btnStartReplace.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnStartReplace.Name = "btnStartReplace";
            this.btnStartReplace.Size = new System.Drawing.Size(262, 39);
            this.btnStartReplace.TabIndex = 64;
            this.btnStartReplace.Text = "Apply changes";
            this.btnStartReplace.UseVisualStyleBackColor = true;
            this.btnStartReplace.Visible = false;
            this.btnStartReplace.Click += new System.EventHandler(this.btnStartReplace_Click);
            // 
            // imgSF
            // 
            this.imgSF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSF.Location = new System.Drawing.Point(413, 698);
            this.imgSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgSF.Name = "imgSF";
            this.imgSF.Size = new System.Drawing.Size(95, 20);
            this.imgSF.TabIndex = 65;
            this.imgSF.TabStop = false;
            this.toolTipSF.SetToolTip(this.imgSF, "https://sourceforge.net/projects/sor4-character-swapper/");
            this.imgSF.Click += new System.EventHandler(this.imgSF_Click);
            // 
            // imgYoutube
            // 
            this.imgYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgYoutube.Location = new System.Drawing.Point(371, 701);
            this.imgYoutube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgYoutube.Name = "imgYoutube";
            this.imgYoutube.Size = new System.Drawing.Size(23, 16);
            this.imgYoutube.TabIndex = 66;
            this.imgYoutube.TabStop = false;
            this.toolTipYoutube.SetToolTip(this.imgYoutube, "https://youtube.com/honganqi");
            this.imgYoutube.Click += new System.EventHandler(this.imgYoutube_Click);
            // 
            // imgTwitch
            // 
            this.imgTwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTwitch.Location = new System.Drawing.Point(396, 701);
            this.imgTwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgTwitch.Name = "imgTwitch";
            this.imgTwitch.Size = new System.Drawing.Size(15, 16);
            this.imgTwitch.TabIndex = 67;
            this.imgTwitch.TabStop = false;
            this.toolTipTwitch.SetToolTip(this.imgTwitch, "https://twitch.tv/honganqi");
            this.imgTwitch.Click += new System.EventHandler(this.imgTwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(460, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 68;
            this.label1.Text = "Updates on";
            // 
            // labelPending
            // 
            this.labelPending.AutoSize = true;
            this.labelPending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPending.Location = new System.Drawing.Point(80, 649);
            this.labelPending.Name = "labelPending";
            this.labelPending.Size = new System.Drawing.Size(279, 15);
            this.labelPending.TabIndex = 69;
            this.labelPending.Text = "You have swaps which have not been applied yet.";
            this.labelPending.Visible = false;
            this.labelPending.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPending_MouseDown);
            this.labelPending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPending_MouseMove);
            // 
            // btnCharPanel
            // 
            this.btnCharPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharPanel.Location = new System.Drawing.Point(11, 153);
            this.btnCharPanel.Name = "btnCharPanel";
            this.btnCharPanel.Size = new System.Drawing.Size(75, 23);
            this.btnCharPanel.TabIndex = 70;
            this.btnCharPanel.Text = "Character";
            this.btnCharPanel.UseVisualStyleBackColor = true;
            this.btnCharPanel.Visible = false;
            this.btnCharPanel.Click += new System.EventHandler(this.btnCharPanel_Click);
            // 
            // btnItemPanel
            // 
            this.btnItemPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnItemPanel.Location = new System.Drawing.Point(89, 153);
            this.btnItemPanel.Name = "btnItemPanel";
            this.btnItemPanel.Size = new System.Drawing.Size(75, 23);
            this.btnItemPanel.TabIndex = 71;
            this.btnItemPanel.Text = "Items";
            this.btnItemPanel.UseVisualStyleBackColor = true;
            this.btnItemPanel.Visible = false;
            this.btnItemPanel.Click += new System.EventHandler(this.btnItemPanel_Click);
            // 
            // panelDivider
            // 
            this.panelDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivider.Location = new System.Drawing.Point(-3, 173);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(540, 1);
            this.panelDivider.TabIndex = 72;
            this.panelDivider.Visible = false;
            // 
            // btnDestroyablesPanel
            // 
            this.btnDestroyablesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestroyablesPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestroyablesPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDestroyablesPanel.Location = new System.Drawing.Point(167, 153);
            this.btnDestroyablesPanel.Name = "btnDestroyablesPanel";
            this.btnDestroyablesPanel.Size = new System.Drawing.Size(75, 23);
            this.btnDestroyablesPanel.TabIndex = 73;
            this.btnDestroyablesPanel.Text = "Breakables";
            this.btnDestroyablesPanel.UseVisualStyleBackColor = true;
            this.btnDestroyablesPanel.Visible = false;
            this.btnDestroyablesPanel.Click += new System.EventHandler(this.btnDestroyablePanel_Click);
            // 
            // btnLevelPanel
            // 
            this.btnLevelPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLevelPanel.Location = new System.Drawing.Point(245, 153);
            this.btnLevelPanel.Name = "btnLevelPanel";
            this.btnLevelPanel.Size = new System.Drawing.Size(75, 23);
            this.btnLevelPanel.TabIndex = 74;
            this.btnLevelPanel.Text = "Levels";
            this.btnLevelPanel.UseVisualStyleBackColor = true;
            this.btnLevelPanel.Visible = false;
            this.btnLevelPanel.Click += new System.EventHandler(this.btnLevelPanel_Click);
            // 
            // btnClearAllSwaps
            // 
            this.btnClearAllSwaps.Enabled = false;
            this.btnClearAllSwaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllSwaps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSwaps.Location = new System.Drawing.Point(432, 340);
            this.btnClearAllSwaps.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClearAllSwaps.Name = "btnClearAllSwaps";
            this.btnClearAllSwaps.Size = new System.Drawing.Size(76, 39);
            this.btnClearAllSwaps.TabIndex = 75;
            this.btnClearAllSwaps.Text = "Clear all swap lists";
            this.btnClearAllSwaps.UseVisualStyleBackColor = true;
            this.btnClearAllSwaps.Visible = false;
            this.btnClearAllSwaps.Click += new System.EventHandler(this.btnClearAllSwaps_Click);
            // 
            // btnPresetsPanel
            // 
            this.btnPresetsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetsPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresetsPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPresetsPanel.Location = new System.Drawing.Point(433, 153);
            this.btnPresetsPanel.Name = "btnPresetsPanel";
            this.btnPresetsPanel.Size = new System.Drawing.Size(75, 23);
            this.btnPresetsPanel.TabIndex = 76;
            this.btnPresetsPanel.Text = "Presets";
            this.btnPresetsPanel.UseVisualStyleBackColor = true;
            this.btnPresetsPanel.Visible = false;
            this.btnPresetsPanel.Click += new System.EventHandler(this.btnPresetsPanel_Click);
            // 
            // panelDifficulty
            // 
            this.panelDifficulty.Location = new System.Drawing.Point(0, 135);
            this.panelDifficulty.Name = "panelDifficulty";
            this.panelDifficulty.Size = new System.Drawing.Size(520, 460);
            this.panelDifficulty.TabIndex = 77;
            this.panelDifficulty.Visible = false;
            // 
            // panelOwner
            // 
            this.panelOwner.Location = new System.Drawing.Point(0, 135);
            this.panelOwner.Name = "panelOwner";
            this.panelOwner.Size = new System.Drawing.Size(520, 462);
            this.panelOwner.TabIndex = 78;
            this.panelOwner.Visible = false;
            // 
            // btnClearAllCustomizations
            // 
            this.btnClearAllCustomizations.Enabled = false;
            this.btnClearAllCustomizations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllCustomizations.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllCustomizations.Location = new System.Drawing.Point(432, 205);
            this.btnClearAllCustomizations.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClearAllCustomizations.Name = "btnClearAllCustomizations";
            this.btnClearAllCustomizations.Size = new System.Drawing.Size(76, 39);
            this.btnClearAllCustomizations.TabIndex = 79;
            this.btnClearAllCustomizations.Text = "Clear all customized";
            this.btnClearAllCustomizations.UseVisualStyleBackColor = true;
            this.btnClearAllCustomizations.Visible = false;
            this.btnClearAllCustomizations.Click += new System.EventHandler(this.btnClearAllCustomizations_Click);
            // 
            // btnUpdateNotif
            // 
            this.btnUpdateNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNotif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNotif.Location = new System.Drawing.Point(190, 675);
            this.btnUpdateNotif.Name = "btnUpdateNotif";
            this.btnUpdateNotif.Size = new System.Drawing.Size(160, 43);
            this.btnUpdateNotif.TabIndex = 81;
            this.btnUpdateNotif.Text = "vx.x is now available!\r\nGET IT NOW!";
            this.btnUpdateNotif.UseVisualStyleBackColor = false;
            this.btnUpdateNotif.Visible = false;
            this.btnUpdateNotif.Click += new System.EventHandler(this.btnUpdateNotif_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 732);
            this.Controls.Add(this.btnUpdateNotif);
            this.Controls.Add(this.panelOwner);
            this.Controls.Add(this.panelDifficulty);
            this.Controls.Add(this.btnClearAllCustomizations);
            this.Controls.Add(this.btnClearAllSwaps);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnCharPanel);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.btnLevelPanel);
            this.Controls.Add(this.btnDestroyablesPanel);
            this.Controls.Add(this.btnItemPanel);
            this.Controls.Add(this.labelPending);
            this.Controls.Add(this.imgSF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTwitch);
            this.Controls.Add(this.imgYoutube);
            this.Controls.Add(this.imgBMCSupport);
            this.Controls.Add(this.btnStartReplace);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelSupport);
            this.Controls.Add(this.btnPresetsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Container";
            this.Text = "Container";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Container_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Container_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelSupport;
        public System.Windows.Forms.PictureBox imgBMCSupport;
        public System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Button btnStartReplace;
        public System.Windows.Forms.PictureBox imgSF;
        public System.Windows.Forms.PictureBox imgYoutube;
        public System.Windows.Forms.PictureBox imgTwitch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipYoutube;
        private System.Windows.Forms.ToolTip toolTipTwitch;
        private System.Windows.Forms.ToolTip toolTipSF;
        private System.Windows.Forms.ToolTip toolTipCoffee;
        public System.Windows.Forms.Label labelPending;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Button btnCharPanel;
        public System.Windows.Forms.Button btnItemPanel;
        public System.Windows.Forms.Label panelDivider;
        public System.Windows.Forms.Button btnDestroyablesPanel;
        public System.Windows.Forms.Button btnLevelPanel;
        public System.Windows.Forms.Button btnClearAllSwaps;
        public System.Windows.Forms.Button btnPresetsPanel;
        public System.Windows.Forms.Panel panelDifficulty;
        public System.Windows.Forms.Panel panelOwner;
        public System.Windows.Forms.Button btnClearAllCustomizations;
        public System.Windows.Forms.Button btnUpdateNotif;
    }
}