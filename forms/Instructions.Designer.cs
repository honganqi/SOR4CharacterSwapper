namespace SOR4_Swapper
{
    partial class Instructions
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
            this.btnInstructionsClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstructionsClose
            // 
            this.btnInstructionsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstructionsClose.AutoSize = true;
            this.btnInstructionsClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstructionsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructionsClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructionsClose.Location = new System.Drawing.Point(145, 41);
            this.btnInstructionsClose.Name = "btnInstructionsClose";
            this.btnInstructionsClose.Size = new System.Drawing.Size(231, 37);
            this.btnInstructionsClose.TabIndex = 48;
            this.btnInstructionsClose.Text = "Tutorials on YouTube";
            this.btnInstructionsClose.UseVisualStyleBackColor = false;
            this.btnInstructionsClose.Click += new System.EventHandler(this.btnInstructionsClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Check out the tutorials by clicking on the button below";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstructionsClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnInstructionsClose;
        private System.Windows.Forms.Label label1;
    }
}