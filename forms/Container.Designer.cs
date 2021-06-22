﻿namespace SOR4_Replacer
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
            this.labelSupport.Location = new System.Drawing.Point(10, 400);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(86, 15);
            this.labelSupport.TabIndex = 61;
            this.labelSupport.Text = "Support me on";
            // 
            // imgBMCSupport
            // 
            this.imgBMCSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBMCSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBMCSupport.InitialImage = null;
            this.imgBMCSupport.Location = new System.Drawing.Point(12, 414);
            this.imgBMCSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBMCSupport.Name = "imgBMCSupport";
            this.imgBMCSupport.Size = new System.Drawing.Size(152, 37);
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
            this.panelMain.Size = new System.Drawing.Size(460, 162);
            this.panelMain.TabIndex = 62;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(460, 173);
            this.panelInfo.TabIndex = 63;
            // 
            // btnStartReplace
            // 
            this.btnStartReplace.Enabled = false;
            this.btnStartReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartReplace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReplace.Location = new System.Drawing.Point(99, 344);
            this.btnStartReplace.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnStartReplace.Name = "btnStartReplace";
            this.btnStartReplace.Size = new System.Drawing.Size(262, 31);
            this.btnStartReplace.TabIndex = 64;
            this.btnStartReplace.Text = "Apply changes";
            this.btnStartReplace.UseVisualStyleBackColor = true;
            this.btnStartReplace.Click += new System.EventHandler(this.btnStartReplace_Click);
            // 
            // imgSF
            // 
            this.imgSF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSF.Location = new System.Drawing.Point(353, 432);
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
            this.imgYoutube.Location = new System.Drawing.Point(311, 435);
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
            this.imgTwitch.Location = new System.Drawing.Point(336, 435);
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
            this.label1.Location = new System.Drawing.Point(400, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 68;
            this.label1.Text = "Updates on";
            // 
            // labelPending
            // 
            this.labelPending.AutoSize = true;
            this.labelPending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPending.Location = new System.Drawing.Point(93, 378);
            this.labelPending.Name = "labelPending";
            this.labelPending.Size = new System.Drawing.Size(279, 15);
            this.labelPending.TabIndex = 69;
            this.labelPending.Text = "You have swaps which have not been applied yet.";
            this.labelPending.Visible = false;
            this.labelPending.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPending_MouseDown);
            this.labelPending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPending_MouseMove);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 463);
            this.Controls.Add(this.labelPending);
            this.Controls.Add(this.imgSF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTwitch);
            this.Controls.Add(this.imgYoutube);
            this.Controls.Add(this.imgBMCSupport);
            this.Controls.Add(this.btnStartReplace);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelSupport);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Container";
            this.Text = "v";
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
        public System.Windows.Forms.Panel panelMain;
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
    }
}