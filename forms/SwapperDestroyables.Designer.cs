namespace SOR4_Swapper
{
    partial class SwapperDestroyables
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
            this.picThumbSwap = new System.Windows.Forms.PictureBox();
            this.picThumbOrig = new System.Windows.Forms.PictureBox();
            this.btnClearSwapList = new System.Windows.Forms.Button();
            this.labelOrigToReplace = new System.Windows.Forms.Label();
            this.btnSetItem = new System.Windows.Forms.Button();
            this.cmbItemReplacementList = new System.Windows.Forms.ComboBox();
            this.labelReplacementList = new System.Windows.Forms.Label();
            this.cmbItemOriginalList = new System.Windows.Forms.ComboBox();
            this.labelCharacterList = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbSwap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).BeginInit();
            this.SuspendLayout();
            // 
            // picThumbSwap
            // 
            this.picThumbSwap.Location = new System.Drawing.Point(226, 53);
            this.picThumbSwap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picThumbSwap.Name = "picThumbSwap";
            this.picThumbSwap.Size = new System.Drawing.Size(190, 90);
            this.picThumbSwap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumbSwap.TabIndex = 43;
            this.picThumbSwap.TabStop = false;
            this.picThumbSwap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picThumbSwap_MouseDown);
            this.picThumbSwap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picThumbSwap_MouseMove);
            // 
            // picThumbOrig
            // 
            this.picThumbOrig.Location = new System.Drawing.Point(12, 53);
            this.picThumbOrig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picThumbOrig.Name = "picThumbOrig";
            this.picThumbOrig.Size = new System.Drawing.Size(190, 90);
            this.picThumbOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumbOrig.TabIndex = 42;
            this.picThumbOrig.TabStop = false;
            this.picThumbOrig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picThumbOrig_MouseDown);
            this.picThumbOrig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picThumbOrig_MouseMove);
            // 
            // btnClearSwapList
            // 
            this.btnClearSwapList.Enabled = false;
            this.btnClearSwapList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSwapList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSwapList.Location = new System.Drawing.Point(432, 122);
            this.btnClearSwapList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClearSwapList.Name = "btnClearSwapList";
            this.btnClearSwapList.Size = new System.Drawing.Size(76, 25);
            this.btnClearSwapList.TabIndex = 41;
            this.btnClearSwapList.Text = "Clear list";
            this.btnClearSwapList.UseVisualStyleBackColor = true;
            this.btnClearSwapList.Click += new System.EventHandler(this.btnClearSwapList_Click);
            // 
            // labelOrigToReplace
            // 
            this.labelOrigToReplace.AutoSize = true;
            this.labelOrigToReplace.BackColor = System.Drawing.Color.Transparent;
            this.labelOrigToReplace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigToReplace.Location = new System.Drawing.Point(203, 29);
            this.labelOrigToReplace.Name = "labelOrigToReplace";
            this.labelOrigToReplace.Size = new System.Drawing.Size(25, 20);
            this.labelOrigToReplace.TabIndex = 40;
            this.labelOrigToReplace.Text = "->";
            // 
            // btnSetItem
            // 
            this.btnSetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetItem.Location = new System.Drawing.Point(432, 27);
            this.btnSetItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSetItem.Name = "btnSetItem";
            this.btnSetItem.Size = new System.Drawing.Size(76, 25);
            this.btnSetItem.TabIndex = 38;
            this.btnSetItem.Text = "Add to list";
            this.btnSetItem.UseVisualStyleBackColor = true;
            this.btnSetItem.Click += new System.EventHandler(this.btnSetItem_Click);
            // 
            // cmbItemReplacementList
            // 
            this.cmbItemReplacementList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemReplacementList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemReplacementList.BackColor = System.Drawing.Color.White;
            this.cmbItemReplacementList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemReplacementList.FormattingEnabled = true;
            this.cmbItemReplacementList.Location = new System.Drawing.Point(226, 27);
            this.cmbItemReplacementList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbItemReplacementList.Name = "cmbItemReplacementList";
            this.cmbItemReplacementList.Size = new System.Drawing.Size(190, 23);
            this.cmbItemReplacementList.TabIndex = 37;
            this.cmbItemReplacementList.SelectedIndexChanged += new System.EventHandler(this.cmbItemReplacementList_SelectedIndexChanged);
            // 
            // labelReplacementList
            // 
            this.labelReplacementList.AutoSize = true;
            this.labelReplacementList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplacementList.Location = new System.Drawing.Point(223, 11);
            this.labelReplacementList.Name = "labelReplacementList";
            this.labelReplacementList.Size = new System.Drawing.Size(126, 13);
            this.labelReplacementList.TabIndex = 36;
            this.labelReplacementList.Text = "Replacement Breakable";
            // 
            // cmbItemOriginalList
            // 
            this.cmbItemOriginalList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemOriginalList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemOriginalList.BackColor = System.Drawing.Color.White;
            this.cmbItemOriginalList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemOriginalList.FormattingEnabled = true;
            this.cmbItemOriginalList.Location = new System.Drawing.Point(12, 27);
            this.cmbItemOriginalList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbItemOriginalList.Name = "cmbItemOriginalList";
            this.cmbItemOriginalList.Size = new System.Drawing.Size(190, 23);
            this.cmbItemOriginalList.TabIndex = 35;
            this.cmbItemOriginalList.SelectedIndexChanged += new System.EventHandler(this.cmbItemOriginalList_SelectedIndexChanged);
            // 
            // labelCharacterList
            // 
            this.labelCharacterList.AutoSize = true;
            this.labelCharacterList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharacterList.Location = new System.Drawing.Point(9, 11);
            this.labelCharacterList.Name = "labelCharacterList";
            this.labelCharacterList.Size = new System.Drawing.Size(102, 13);
            this.labelCharacterList.TabIndex = 34;
            this.labelCharacterList.Text = "Original Breakable";
            // 
            // btnShowList
            // 
            this.btnShowList.Enabled = false;
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(432, 64);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(76, 25);
            this.btnShowList.TabIndex = 61;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // SwapperDestroyables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.cmbItemOriginalList);
            this.Controls.Add(this.cmbItemReplacementList);
            this.Controls.Add(this.picThumbSwap);
            this.Controls.Add(this.picThumbOrig);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.labelOrigToReplace);
            this.Controls.Add(this.btnSetItem);
            this.Controls.Add(this.labelReplacementList);
            this.Controls.Add(this.labelCharacterList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SwapperDestroyables";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Swapper_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Swapper_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbSwap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picThumbSwap;
        public System.Windows.Forms.PictureBox picThumbOrig;
        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.Label labelOrigToReplace;
        public System.Windows.Forms.Button btnSetItem;
        public System.Windows.Forms.ComboBox cmbItemReplacementList;
        public System.Windows.Forms.Label labelReplacementList;
        public System.Windows.Forms.ComboBox cmbItemOriginalList;
        public System.Windows.Forms.Label labelCharacterList;
        public System.Windows.Forms.Button btnShowList;
    }
}