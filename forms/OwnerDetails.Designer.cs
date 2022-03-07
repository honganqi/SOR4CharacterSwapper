namespace SOR4_Swapper
{
    partial class OwnerDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.txtDownloadURL = new System.Windows.Forms.TextBox();
            this.txtModTitle = new System.Windows.Forms.TextBox();
            this.txtRecoDiff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Swap Mod Author Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Swap Mod Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Download URL";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(149, 48);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(359, 22);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "Unnamed";
            this.txtAuthor.MouseHover += new System.EventHandler(this.txtAuthor_MouseHover);
            // 
            // txtModDesc
            // 
            this.txtModDesc.Location = new System.Drawing.Point(149, 184);
            this.txtModDesc.Multiline = true;
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModDesc.Size = new System.Drawing.Size(359, 175);
            this.txtModDesc.TabIndex = 5;
            this.txtModDesc.MouseHover += new System.EventHandler(this.txtModDesc_MouseHover);
            // 
            // txtDownloadURL
            // 
            this.txtDownloadURL.Location = new System.Drawing.Point(149, 102);
            this.txtDownloadURL.Name = "txtDownloadURL";
            this.txtDownloadURL.Size = new System.Drawing.Size(359, 22);
            this.txtDownloadURL.TabIndex = 3;
            this.txtDownloadURL.Text = "Unlocated";
            this.txtDownloadURL.MouseHover += new System.EventHandler(this.txtDownloadURL_MouseHover);
            // 
            // txtModTitle
            // 
            this.txtModTitle.Location = new System.Drawing.Point(149, 75);
            this.txtModTitle.Name = "txtModTitle";
            this.txtModTitle.Size = new System.Drawing.Size(359, 22);
            this.txtModTitle.TabIndex = 2;
            this.txtModTitle.Text = "Untitled";
            this.txtModTitle.MouseHover += new System.EventHandler(this.txtModTitle_MouseHover);
            // 
            // txtRecoDiff
            // 
            this.txtRecoDiff.Location = new System.Drawing.Point(149, 129);
            this.txtRecoDiff.Name = "txtRecoDiff";
            this.txtRecoDiff.Size = new System.Drawing.Size(359, 22);
            this.txtRecoDiff.TabIndex = 4;
            this.txtRecoDiff.Text = "Unthought";
            this.txtRecoDiff.MouseHover += new System.EventHandler(this.txtRecoDiff_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Recommended Difficulty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Date Created";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.AutoSize = true;
            this.txtDateCreated.Location = new System.Drawing.Point(146, 159);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(0, 13);
            this.txtDateCreated.TabIndex = 74;
            // 
            // OwnerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 372);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRecoDiff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModTitle);
            this.Controls.Add(this.txtDownloadURL);
            this.Controls.Add(this.txtModDesc);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerDetails";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtModDesc;
        public System.Windows.Forms.TextBox txtDownloadURL;
        public System.Windows.Forms.TextBox txtModTitle;
        public System.Windows.Forms.TextBox txtRecoDiff;
        public System.Windows.Forms.Label txtDateCreated;
    }
}