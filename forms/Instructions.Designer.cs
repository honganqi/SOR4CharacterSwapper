namespace SOR4_Replacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.labelInstructions = new System.Windows.Forms.Label();
            this.btnInstructionsClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(10, 7);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(441, 447);
            this.labelInstructions.TabIndex = 46;
            this.labelInstructions.Text = resources.GetString("labelInstructions.Text");
            // 
            // btnInstructionsClose
            // 
            this.btnInstructionsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstructionsClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstructionsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructionsClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructionsClose.Location = new System.Drawing.Point(361, 431);
            this.btnInstructionsClose.Name = "btnInstructionsClose";
            this.btnInstructionsClose.Size = new System.Drawing.Size(90, 23);
            this.btnInstructionsClose.TabIndex = 48;
            this.btnInstructionsClose.Text = "Got it!";
            this.btnInstructionsClose.UseVisualStyleBackColor = false;
            this.btnInstructionsClose.Click += new System.EventHandler(this.btnInstructionsClose_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 463);
            this.Controls.Add(this.btnInstructionsClose);
            this.Controls.Add(this.labelInstructions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelInstructions;
        public System.Windows.Forms.Button btnInstructionsClose;
    }
}