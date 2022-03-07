
namespace SOR4_Swapper
{
    partial class SwapListLevelPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSortListReplacements = new System.Windows.Forms.Label();
            this.labelSortListOriginal = new System.Windows.Forms.Label();
            this.labelReplaceUniqueCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelReplaceCount = new System.Windows.Forms.Label();
            this.labelReplaceCountLabel = new System.Windows.Forms.Label();
            this.txtFilterReplace = new System.Windows.Forms.TextBox();
            this.txtFilterOrig = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.origName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.replaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.labelReplaceUniqueCount.Location = new System.Drawing.Point(280, 34);
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
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Unique levels:";
            // 
            // labelReplaceCount
            // 
            this.labelReplaceCount.AutoSize = true;
            this.labelReplaceCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceCount.Location = new System.Drawing.Point(83, 34);
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
            this.labelReplaceCountLabel.Size = new System.Drawing.Size(88, 13);
            this.labelReplaceCountLabel.TabIndex = 38;
            this.labelReplaceCountLabel.Text = "Replaced levels:";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.origThumb,
            this.origName,
            this.spacer,
            this.replaceThumb,
            this.replaceName,
            this.origKey,
            this.replaceKey,
            this.rowIndex});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 60;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(402, 520);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellMouseLeave);
            this.dataGridView2.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseMove);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.DataPropertyName = "delete";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.delete.ToolTipText = "Remove";
            this.delete.Width = 20;
            // 
            // origThumb
            // 
            this.origThumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.origThumb.DataPropertyName = "origThumb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = null;
            this.origThumb.DefaultCellStyle = dataGridViewCellStyle2;
            this.origThumb.HeaderText = "Thumbnail Original";
            this.origThumb.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.origThumb.Name = "origThumb";
            this.origThumb.ReadOnly = true;
            this.origThumb.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origThumb.Width = 40;
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
            this.spacer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.spacer.DataPropertyName = "spacer";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.spacer.DefaultCellStyle = dataGridViewCellStyle4;
            this.spacer.HeaderText = "";
            this.spacer.Name = "spacer";
            this.spacer.ReadOnly = true;
            this.spacer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.spacer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.spacer.Width = 20;
            // 
            // replaceThumb
            // 
            this.replaceThumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.replaceThumb.DataPropertyName = "replaceThumb";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.NullValue = null;
            this.replaceThumb.DefaultCellStyle = dataGridViewCellStyle5;
            this.replaceThumb.HeaderText = "New Thumbnail";
            this.replaceThumb.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.replaceThumb.Name = "replaceThumb";
            this.replaceThumb.ReadOnly = true;
            this.replaceThumb.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.replaceThumb.Width = 40;
            // 
            // replaceName
            // 
            this.replaceName.DataPropertyName = "replaceName";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceName.DefaultCellStyle = dataGridViewCellStyle6;
            this.replaceName.HeaderText = "New";
            this.replaceName.MinimumWidth = 6;
            this.replaceName.Name = "replaceName";
            this.replaceName.ReadOnly = true;
            this.replaceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.replaceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.replaceName.Width = 133;
            // 
            // origKey
            // 
            this.origKey.DataPropertyName = "origKey";
            this.origKey.HeaderText = "hidden";
            this.origKey.MinimumWidth = 6;
            this.origKey.Name = "origKey";
            this.origKey.ReadOnly = true;
            this.origKey.Visible = false;
            this.origKey.Width = 125;
            // 
            // replaceKey
            // 
            this.replaceKey.DataPropertyName = "replaceKey";
            this.replaceKey.HeaderText = "replaceKey";
            this.replaceKey.Name = "replaceKey";
            this.replaceKey.ReadOnly = true;
            this.replaceKey.Visible = false;
            // 
            // rowIndex
            // 
            this.rowIndex.DataPropertyName = "rowIndex";
            this.rowIndex.HeaderText = "rowIndex";
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.ReadOnly = true;
            this.rowIndex.Visible = false;
            // 
            // SwapListLevelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 582);
            this.Controls.Add(this.dataGridView2);
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
            this.Name = "SwapListLevelPanel";
            this.Text = "SwapList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label labelSortListReplacements;
        public System.Windows.Forms.Label labelSortListOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn origThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn origName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacer;
        private System.Windows.Forms.DataGridViewImageColumn replaceThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn origKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
    }
}