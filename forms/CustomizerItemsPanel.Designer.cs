
namespace SOR4_Swapper
{
    partial class ItemCustomizerPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.origName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.replaceNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSortListOriginal = new System.Windows.Forms.Label();
            this.labelReplaceCount = new System.Windows.Forms.Label();
            this.labelReplaceCountLabel = new System.Windows.Forms.Label();
            this.txtFilterOrig = new System.Windows.Forms.TextBox();
            this.txtFilterReplace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDel,
            this.origThumbCol,
            this.origName,
            this.spacer,
            this.newThumbCol,
            this.replaceNameCol,
            this.origKey,
            this.rowIndex});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(402, 520);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDel.DataPropertyName = "delete";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDel.HeaderText = "";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDel.ToolTipText = "Remove";
            this.colDel.Width = 20;
            // 
            // origThumbCol
            // 
            this.origThumbCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.origThumbCol.DataPropertyName = "origThumb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = null;
            this.origThumbCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.origThumbCol.HeaderText = "Thumbnail Original";
            this.origThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.origThumbCol.MinimumWidth = 6;
            this.origThumbCol.Name = "origThumbCol";
            this.origThumbCol.ReadOnly = true;
            this.origThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origThumbCol.Width = 40;
            // 
            // origName
            // 
            this.origName.DataPropertyName = "origName";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origName.DefaultCellStyle = dataGridViewCellStyle3;
            this.origName.HeaderText = "Change";
            this.origName.MinimumWidth = 6;
            this.origName.Name = "origName";
            this.origName.ReadOnly = true;
            this.origName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.origName.Width = 133;
            // 
            // spacer
            // 
            this.spacer.DataPropertyName = "spacer";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.spacer.DefaultCellStyle = dataGridViewCellStyle4;
            this.spacer.HeaderText = "";
            this.spacer.Name = "spacer";
            this.spacer.ReadOnly = true;
            this.spacer.Width = 20;
            // 
            // newThumbCol
            // 
            this.newThumbCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.newThumbCol.DataPropertyName = "replaceThumb";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.newThumbCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.newThumbCol.HeaderText = "New Thumbnail";
            this.newThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.newThumbCol.Name = "newThumbCol";
            this.newThumbCol.ReadOnly = true;
            this.newThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newThumbCol.Width = 40;
            // 
            // replaceNameCol
            // 
            this.replaceNameCol.DataPropertyName = "replaceName";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Format = "Segoe UI, 8.25pt";
            this.replaceNameCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.replaceNameCol.HeaderText = "New";
            this.replaceNameCol.MinimumWidth = 6;
            this.replaceNameCol.Name = "replaceNameCol";
            this.replaceNameCol.ReadOnly = true;
            this.replaceNameCol.Width = 133;
            // 
            // origKey
            // 
            this.origKey.DataPropertyName = "origKey";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.origKey.DefaultCellStyle = dataGridViewCellStyle7;
            this.origKey.HeaderText = "hidden";
            this.origKey.MinimumWidth = 6;
            this.origKey.Name = "origKey";
            this.origKey.ReadOnly = true;
            this.origKey.Visible = false;
            this.origKey.Width = 125;
            // 
            // rowIndex
            // 
            this.rowIndex.DataPropertyName = "rowIndex";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            this.rowIndex.DefaultCellStyle = dataGridViewCellStyle8;
            this.rowIndex.HeaderText = "rowIndex";
            this.rowIndex.MinimumWidth = 6;
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.ReadOnly = true;
            this.rowIndex.Visible = false;
            // 
            // labelSortListOriginal
            // 
            this.labelSortListOriginal.AutoSize = true;
            this.labelSortListOriginal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortListOriginal.Location = new System.Drawing.Point(159, 34);
            this.labelSortListOriginal.Name = "labelSortListOriginal";
            this.labelSortListOriginal.Size = new System.Drawing.Size(35, 13);
            this.labelSortListOriginal.TabIndex = 55;
            this.labelSortListOriginal.Text = "SORT";
            this.labelSortListOriginal.TextChanged += new System.EventHandler(this.labelSortListOriginal_Click);
            // 
            // labelReplaceCount
            // 
            this.labelReplaceCount.AutoSize = true;
            this.labelReplaceCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceCount.Location = new System.Drawing.Point(125, 34);
            this.labelReplaceCount.Name = "labelReplaceCount";
            this.labelReplaceCount.Size = new System.Drawing.Size(0, 13);
            this.labelReplaceCount.TabIndex = 54;
            // 
            // labelReplaceCountLabel
            // 
            this.labelReplaceCountLabel.AutoSize = true;
            this.labelReplaceCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceCountLabel.Location = new System.Drawing.Point(0, 34);
            this.labelReplaceCountLabel.Name = "labelReplaceCountLabel";
            this.labelReplaceCountLabel.Size = new System.Drawing.Size(100, 13);
            this.labelReplaceCountLabel.TabIndex = 53;
            this.labelReplaceCountLabel.Text = "Customized items:";
            // 
            // txtFilterOrig
            // 
            this.txtFilterOrig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterOrig.Location = new System.Drawing.Point(0, 0);
            this.txtFilterOrig.Name = "txtFilterOrig";
            this.txtFilterOrig.Size = new System.Drawing.Size(190, 23);
            this.txtFilterOrig.TabIndex = 52;
            this.txtFilterOrig.TextChanged += new System.EventHandler(this.txtFilterOrig_TextChanged);
            // 
            // txtFilterReplace
            // 
            this.txtFilterReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterReplace.Location = new System.Drawing.Point(209, 0);
            this.txtFilterReplace.Name = "txtFilterReplace";
            this.txtFilterReplace.Size = new System.Drawing.Size(190, 23);
            this.txtFilterReplace.TabIndex = 57;
            this.txtFilterReplace.TextChanged += new System.EventHandler(this.txtFilterOrig_TextChanged);
            // 
            // ItemCustomizerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSortListOriginal);
            this.Controls.Add(this.labelReplaceCount);
            this.Controls.Add(this.labelReplaceCountLabel);
            this.Controls.Add(this.txtFilterOrig);
            this.Controls.Add(this.txtFilterReplace);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemCustomizerPanel";
            this.Text = "ItemCustomizerPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDel;
        private System.Windows.Forms.DataGridViewImageColumn origThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn origName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacer;
        private System.Windows.Forms.DataGridViewImageColumn newThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn origKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
        public System.Windows.Forms.Label labelSortListOriginal;
        public System.Windows.Forms.Label labelReplaceCount;
        private System.Windows.Forms.Label labelReplaceCountLabel;
        private System.Windows.Forms.TextBox txtFilterOrig;
        private System.Windows.Forms.TextBox txtFilterReplace;
    }
}