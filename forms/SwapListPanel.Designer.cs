
namespace SOR4_Replacer
{
    partial class SwapListPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSortListReplacements = new System.Windows.Forms.Label();
            this.labelSortListOriginal = new System.Windows.Forms.Label();
            this.labelReplaceUniqueCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelReplaceCount = new System.Windows.Forms.Label();
            this.labelReplaceCountLabel = new System.Windows.Forms.Label();
            this.txtFilterReplace = new System.Windows.Forms.TextBox();
            this.txtFilterOrig = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.origName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.replaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiddenIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSortListReplacements
            // 
            this.labelSortListReplacements.AutoSize = true;
            this.labelSortListReplacements.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortListReplacements.Location = new System.Drawing.Point(368, 34);
            this.labelSortListReplacements.Name = "labelSortListReplacements";
            this.labelSortListReplacements.Size = new System.Drawing.Size(35, 13);
            this.labelSortListReplacements.TabIndex = 43;
            this.labelSortListReplacements.Text = "SORT";
            this.labelSortListReplacements.Click += new System.EventHandler(this.labelSortListReplacements_Click);
            // 
            // labelSortListOriginal
            // 
            this.labelSortListOriginal.AutoSize = true;
            this.labelSortListOriginal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortListOriginal.Location = new System.Drawing.Point(159, 34);
            this.labelSortListOriginal.Name = "labelSortListOriginal";
            this.labelSortListOriginal.Size = new System.Drawing.Size(35, 13);
            this.labelSortListOriginal.TabIndex = 42;
            this.labelSortListOriginal.Text = "SORT";
            this.labelSortListOriginal.Click += new System.EventHandler(this.labelSortListOriginal_Click);
            // 
            // labelReplaceUniqueCount
            // 
            this.labelReplaceUniqueCount.AutoSize = true;
            this.labelReplaceUniqueCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceUniqueCount.Location = new System.Drawing.Point(322, 34);
            this.labelReplaceUniqueCount.Name = "labelReplaceUniqueCount";
            this.labelReplaceUniqueCount.Size = new System.Drawing.Size(0, 13);
            this.labelReplaceUniqueCount.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Unique replacements:";
            // 
            // labelReplaceCount
            // 
            this.labelReplaceCount.AutoSize = true;
            this.labelReplaceCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceCount.Location = new System.Drawing.Point(110, 34);
            this.labelReplaceCount.Name = "labelReplaceCount";
            this.labelReplaceCount.Size = new System.Drawing.Size(0, 13);
            this.labelReplaceCount.TabIndex = 39;
            // 
            // labelReplaceCountLabel
            // 
            this.labelReplaceCountLabel.AutoSize = true;
            this.labelReplaceCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceCountLabel.Location = new System.Drawing.Point(0, 34);
            this.labelReplaceCountLabel.Name = "labelReplaceCountLabel";
            this.labelReplaceCountLabel.Size = new System.Drawing.Size(112, 13);
            this.labelReplaceCountLabel.TabIndex = 38;
            this.labelReplaceCountLabel.Text = "Replaced characters:";
            // 
            // txtFilterReplace
            // 
            this.txtFilterReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterReplace.Location = new System.Drawing.Point(209, 0);
            this.txtFilterReplace.Name = "txtFilterReplace";
            this.txtFilterReplace.Size = new System.Drawing.Size(190, 23);
            this.txtFilterReplace.TabIndex = 37;
            this.txtFilterReplace.TextChanged += new System.EventHandler(this.txtFilterReplace_TextChanged);
            // 
            // txtFilterOrig
            // 
            this.txtFilterOrig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterOrig.Location = new System.Drawing.Point(0, 0);
            this.txtFilterOrig.Name = "txtFilterOrig";
            this.txtFilterOrig.Size = new System.Drawing.Size(190, 23);
            this.txtFilterOrig.TabIndex = 36;
            this.txtFilterOrig.TextChanged += new System.EventHandler(this.txtFilterOrig_TextChanged);
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
            this.pointer,
            this.newThumbCol,
            this.replaceName,
            this.hiddenIndex,
            this.rowIndex});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(402, 348);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDel.DataPropertyName = "delete";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.NullValue = null;
            this.origThumbCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.origThumbCol.HeaderText = "Thumbnail Original";
            this.origThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.origThumbCol.Name = "origThumbCol";
            this.origThumbCol.ReadOnly = true;
            this.origThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origThumbCol.Width = 40;
            // 
            // origName
            // 
            this.origName.DataPropertyName = "origName";
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origName.DefaultCellStyle = dataGridViewCellStyle10;
            this.origName.HeaderText = "Change";
            this.origName.MinimumWidth = 6;
            this.origName.Name = "origName";
            this.origName.ReadOnly = true;
            this.origName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.origName.Width = 133;
            // 
            // pointer
            // 
            this.pointer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pointer.DataPropertyName = "spacer";
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            this.pointer.DefaultCellStyle = dataGridViewCellStyle11;
            this.pointer.HeaderText = "";
            this.pointer.Name = "pointer";
            this.pointer.ReadOnly = true;
            this.pointer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pointer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pointer.Width = 20;
            // 
            // newThumbCol
            // 
            this.newThumbCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.newThumbCol.DataPropertyName = "replaceThumb";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.NullValue = null;
            this.newThumbCol.DefaultCellStyle = dataGridViewCellStyle12;
            this.newThumbCol.HeaderText = "New Thumbnail";
            this.newThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.newThumbCol.Name = "newThumbCol";
            this.newThumbCol.ReadOnly = true;
            this.newThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newThumbCol.Width = 40;
            // 
            // replaceName
            // 
            this.replaceName.DataPropertyName = "replaceName";
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceName.DefaultCellStyle = dataGridViewCellStyle13;
            this.replaceName.HeaderText = "New";
            this.replaceName.MinimumWidth = 6;
            this.replaceName.Name = "replaceName";
            this.replaceName.ReadOnly = true;
            this.replaceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.replaceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.replaceName.Width = 133;
            // 
            // hiddenIndex
            // 
            this.hiddenIndex.DataPropertyName = "origKey";
            this.hiddenIndex.HeaderText = "hidden";
            this.hiddenIndex.MinimumWidth = 6;
            this.hiddenIndex.Name = "hiddenIndex";
            this.hiddenIndex.ReadOnly = true;
            this.hiddenIndex.Visible = false;
            this.hiddenIndex.Width = 125;
            // 
            // rowIndex
            // 
            this.rowIndex.DataPropertyName = "rowIndex";
            this.rowIndex.HeaderText = "rowIndex";
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.ReadOnly = true;
            this.rowIndex.Visible = false;
            // 
            // SwapListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSortListReplacements);
            this.Controls.Add(this.labelSortListOriginal);
            this.Controls.Add(this.labelReplaceUniqueCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelReplaceCount);
            this.Controls.Add(this.labelReplaceCountLabel);
            this.Controls.Add(this.txtFilterReplace);
            this.Controls.Add(this.txtFilterOrig);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SwapListPanel";
            this.Text = "SwapList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelReplaceUniqueCount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelReplaceCount;
        private System.Windows.Forms.Label labelReplaceCountLabel;
        private System.Windows.Forms.TextBox txtFilterReplace;
        private System.Windows.Forms.TextBox txtFilterOrig;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label labelSortListReplacements;
        public System.Windows.Forms.Label labelSortListOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDel;
        private System.Windows.Forms.DataGridViewImageColumn origThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn origName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointer;
        private System.Windows.Forms.DataGridViewImageColumn newThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
    }
}