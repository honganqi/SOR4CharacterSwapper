namespace SOR4_Swapper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelDisplayList = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenBigfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnShowSwapperPanel = new System.Windows.Forms.Button();
            this.btnShowCustomizer = new System.Windows.Forms.Button();
            this.navDivider = new System.Windows.Forms.Label();
            this.btnSaveSwap = new System.Windows.Forms.Button();
            this.btnLoadSwap = new System.Windows.Forms.Button();
            this.btnOwnerPanel = new System.Windows.Forms.Button();
            this.btnDifficultyPanel = new System.Windows.Forms.Button();
            this.btnShowRandomPanel = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelVerNum = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.imgListShadow = new System.Windows.Forms.PictureBox();
            this.panelSwapList = new System.Windows.Forms.Panel();
            this.panelInstructions = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListShadow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDisplayList
            // 
            this.labelDisplayList.AutoSize = true;
            this.labelDisplayList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayList.Location = new System.Drawing.Point(648, 56);
            this.labelDisplayList.Name = "labelDisplayList";
            this.labelDisplayList.Size = new System.Drawing.Size(155, 20);
            this.labelDisplayList.TabIndex = 10;
            this.labelDisplayList.Text = "List of Replacements";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "bigfile";
            this.openFileDialog1.Filter = "SOR4 bigfile|bigfile";
            this.openFileDialog1.Title = "Location of \"bigfile\"";
            // 
            // ofdLoadDialog
            // 
            this.ofdLoadDialog.Filter = "SOR4 Swapper Settings|*.swap";
            this.ofdLoadDialog.Title = "Load Settings File";
            // 
            // btnOpenBigfile
            // 
            this.btnOpenBigfile.FlatAppearance.BorderSize = 0;
            this.btnOpenBigfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenBigfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBigfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBigfile.ForeColor = System.Drawing.Color.White;
            this.btnOpenBigfile.Location = new System.Drawing.Point(11, 10);
            this.btnOpenBigfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenBigfile.Name = "btnOpenBigfile";
            this.btnOpenBigfile.Size = new System.Drawing.Size(90, 90);
            this.btnOpenBigfile.TabIndex = 11;
            this.btnOpenBigfile.Text = "Open bigfile";
            this.btnOpenBigfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenBigfile.UseVisualStyleBackColor = true;
            this.btnOpenBigfile.Click += new System.EventHandler(this.btnOpenBigfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(484, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.btnShowSwapperPanel);
            this.panelLeft.Controls.Add(this.btnShowCustomizer);
            this.panelLeft.Controls.Add(this.navDivider);
            this.panelLeft.Controls.Add(this.btnSaveSwap);
            this.panelLeft.Controls.Add(this.btnLoadSwap);
            this.panelLeft.Controls.Add(this.btnOwnerPanel);
            this.panelLeft.Controls.Add(this.btnDifficultyPanel);
            this.panelLeft.Controls.Add(this.btnShowRandomPanel);
            this.panelLeft.Controls.Add(this.btnInstructions);
            this.panelLeft.Controls.Add(this.btnOpenBigfile);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(110, 689);
            this.panelLeft.TabIndex = 42;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            // 
            // btnShowSwapperPanel
            // 
            this.btnShowSwapperPanel.FlatAppearance.BorderSize = 0;
            this.btnShowSwapperPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowSwapperPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSwapperPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSwapperPanel.ForeColor = System.Drawing.Color.White;
            this.btnShowSwapperPanel.Location = new System.Drawing.Point(11, 190);
            this.btnShowSwapperPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowSwapperPanel.Name = "btnShowSwapperPanel";
            this.btnShowSwapperPanel.Size = new System.Drawing.Size(90, 60);
            this.btnShowSwapperPanel.TabIndex = 51;
            this.btnShowSwapperPanel.Text = "Swapper";
            this.btnShowSwapperPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowSwapperPanel.UseVisualStyleBackColor = true;
            this.btnShowSwapperPanel.Visible = false;
            this.btnShowSwapperPanel.Click += new System.EventHandler(this.btnShowSwapperPanel_Click);
            // 
            // btnShowCustomizer
            // 
            this.btnShowCustomizer.FlatAppearance.BorderSize = 0;
            this.btnShowCustomizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowCustomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCustomizer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomizer.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomizer.Location = new System.Drawing.Point(11, 340);
            this.btnShowCustomizer.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowCustomizer.Name = "btnShowCustomizer";
            this.btnShowCustomizer.Size = new System.Drawing.Size(90, 60);
            this.btnShowCustomizer.TabIndex = 50;
            this.btnShowCustomizer.Text = "Customizer";
            this.btnShowCustomizer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowCustomizer.UseVisualStyleBackColor = true;
            this.btnShowCustomizer.Visible = false;
            this.btnShowCustomizer.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // navDivider
            // 
            this.navDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.navDivider.Location = new System.Drawing.Point(21, 565);
            this.navDivider.Name = "navDivider";
            this.navDivider.Size = new System.Drawing.Size(70, 2);
            this.navDivider.TabIndex = 46;
            // 
            // btnSaveSwap
            // 
            this.btnSaveSwap.FlatAppearance.BorderSize = 0;
            this.btnSaveSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSwap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSwap.ForeColor = System.Drawing.Color.White;
            this.btnSaveSwap.Location = new System.Drawing.Point(56, 115);
            this.btnSaveSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSwap.Name = "btnSaveSwap";
            this.btnSaveSwap.Size = new System.Drawing.Size(44, 60);
            this.btnSaveSwap.TabIndex = 45;
            this.btnSaveSwap.Text = "Save";
            this.btnSaveSwap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveSwap.UseVisualStyleBackColor = true;
            this.btnSaveSwap.Visible = false;
            this.btnSaveSwap.Click += new System.EventHandler(this.btnSaveSwap_Click);
            // 
            // btnLoadSwap
            // 
            this.btnLoadSwap.FlatAppearance.BorderSize = 0;
            this.btnLoadSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSwap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSwap.ForeColor = System.Drawing.Color.White;
            this.btnLoadSwap.Location = new System.Drawing.Point(11, 115);
            this.btnLoadSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadSwap.Name = "btnLoadSwap";
            this.btnLoadSwap.Size = new System.Drawing.Size(44, 60);
            this.btnLoadSwap.TabIndex = 44;
            this.btnLoadSwap.Text = "Load";
            this.btnLoadSwap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadSwap.UseVisualStyleBackColor = true;
            this.btnLoadSwap.Visible = false;
            this.btnLoadSwap.Click += new System.EventHandler(this.btnLoadSwap_Click);
            // 
            // btnOwnerPanel
            // 
            this.btnOwnerPanel.FlatAppearance.BorderSize = 0;
            this.btnOwnerPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOwnerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerPanel.ForeColor = System.Drawing.Color.White;
            this.btnOwnerPanel.Location = new System.Drawing.Point(11, 490);
            this.btnOwnerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOwnerPanel.Name = "btnOwnerPanel";
            this.btnOwnerPanel.Size = new System.Drawing.Size(88, 60);
            this.btnOwnerPanel.TabIndex = 43;
            this.btnOwnerPanel.Text = "Swap Author";
            this.btnOwnerPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOwnerPanel.UseVisualStyleBackColor = true;
            this.btnOwnerPanel.Visible = false;
            this.btnOwnerPanel.Click += new System.EventHandler(this.btnOwnerPanel_Click);
            // 
            // btnDifficultyPanel
            // 
            this.btnDifficultyPanel.FlatAppearance.BorderSize = 0;
            this.btnDifficultyPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDifficultyPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifficultyPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifficultyPanel.ForeColor = System.Drawing.Color.White;
            this.btnDifficultyPanel.Location = new System.Drawing.Point(11, 410);
            this.btnDifficultyPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDifficultyPanel.Name = "btnDifficultyPanel";
            this.btnDifficultyPanel.Size = new System.Drawing.Size(88, 60);
            this.btnDifficultyPanel.TabIndex = 42;
            this.btnDifficultyPanel.Text = "Difficulty";
            this.btnDifficultyPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDifficultyPanel.UseVisualStyleBackColor = true;
            this.btnDifficultyPanel.Visible = false;
            this.btnDifficultyPanel.Click += new System.EventHandler(this.btnDifficultyPanel_Click);
            // 
            // btnShowRandomPanel
            // 
            this.btnShowRandomPanel.FlatAppearance.BorderSize = 0;
            this.btnShowRandomPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowRandomPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRandomPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRandomPanel.ForeColor = System.Drawing.Color.White;
            this.btnShowRandomPanel.Location = new System.Drawing.Point(11, 265);
            this.btnShowRandomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowRandomPanel.Name = "btnShowRandomPanel";
            this.btnShowRandomPanel.Size = new System.Drawing.Size(90, 60);
            this.btnShowRandomPanel.TabIndex = 41;
            this.btnShowRandomPanel.Text = "Randomizer";
            this.btnShowRandomPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowRandomPanel.UseVisualStyleBackColor = true;
            this.btnShowRandomPanel.Visible = false;
            this.btnShowRandomPanel.Click += new System.EventHandler(this.btnShowRandomPanel_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.FlatAppearance.BorderSize = 0;
            this.btnInstructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(11, 580);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(90, 90);
            this.btnInstructions.TabIndex = 40;
            this.btnInstructions.Text = "How-To";
            this.btnInstructions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.labelVerNum);
            this.panelTop.Controls.Add(this.labelAuthor);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(110, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(520, 36);
            this.panelTop.TabIndex = 44;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelVerNum
            // 
            this.labelVerNum.AutoSize = true;
            this.labelVerNum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerNum.ForeColor = System.Drawing.Color.White;
            this.labelVerNum.Location = new System.Drawing.Point(137, 13);
            this.labelVerNum.Name = "labelVerNum";
            this.labelVerNum.Size = new System.Drawing.Size(27, 13);
            this.labelVerNum.TabIndex = 44;
            this.labelVerNum.Text = "v4.2";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(168, 13);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(73, 13);
            this.labelAuthor.TabIndex = 43;
            this.labelAuthor.Text = "by honganqi";
            this.labelAuthor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAuthor_MouseDown);
            this.labelAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAuthor_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(448, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 42;
            this.btnMinimize.Text = "̶̶";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 21);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "SOR4 SWAPPER";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.imgListShadow);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(110, 36);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(520, 653);
            this.panelContainer.TabIndex = 46;
            // 
            // imgListShadow
            // 
            this.imgListShadow.Location = new System.Drawing.Point(520, 0);
            this.imgListShadow.Name = "imgListShadow";
            this.imgListShadow.Size = new System.Drawing.Size(15, 653);
            this.imgListShadow.TabIndex = 26;
            this.imgListShadow.TabStop = false;
            // 
            // panelSwapList
            // 
            this.panelSwapList.Location = new System.Drawing.Point(655, 88);
            this.panelSwapList.Name = "panelSwapList";
            this.panelSwapList.Size = new System.Drawing.Size(440, 582);
            this.panelSwapList.TabIndex = 26;
            // 
            // panelInstructions
            // 
            this.panelInstructions.BackColor = System.Drawing.SystemColors.Control;
            this.panelInstructions.Location = new System.Drawing.Point(111, 189);
            this.panelInstructions.Name = "panelInstructions";
            this.panelInstructions.Size = new System.Drawing.Size(520, 427);
            this.panelInstructions.TabIndex = 47;
            this.panelInstructions.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 689);
            this.Controls.Add(this.labelDisplayList);
            this.Controls.Add(this.panelSwapList);
            this.Controls.Add(this.panelInstructions);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MainWindow";
            this.Text = "SOR4 SWAPPER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgListShadow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDisplayList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog ofdLoadDialog;
        private System.Windows.Forms.Button btnOpenBigfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnInstructions;
        public System.Windows.Forms.Button btnShowRandomPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Panel panelInstructions;
        public System.Windows.Forms.Panel panelSwapList;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox imgListShadow;
        public System.Windows.Forms.Button btnDifficultyPanel;
        private System.Windows.Forms.Label labelVerNum;
        public System.Windows.Forms.Button btnOwnerPanel;
        public System.Windows.Forms.Button btnLoadSwap;
        public System.Windows.Forms.Button btnSaveSwap;
        private System.Windows.Forms.Label navDivider;
        public System.Windows.Forms.Button btnShowCustomizer;
        public System.Windows.Forms.Button btnShowSwapperPanel;
    }
}

