
namespace SOR4_Swapper.forms
{
    partial class TextEditor
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
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGridText = new System.Windows.Forms.TextBox();
            this.txtGridIndex = new System.Windows.Forms.TextBox();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelApply = new System.Windows.Forms.Panel();
            this.chkSwapFile = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkTextApply = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.panelApply.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridView1);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 93);
            this.panelTable.Name = "panelTable";
            this.panelTable.Padding = new System.Windows.Forms.Padding(12, 6, 12, 12);
            this.panelTable.Size = new System.Drawing.Size(933, 432);
            this.panelTable.TabIndex = 94;
            this.panelTable.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colText});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(909, 414);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 200;
            // 
            // colText
            // 
            this.colText.HeaderText = "Text";
            this.colText.Name = "colText";
            this.colText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colText.Width = 580;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.labelDateCreated);
            this.panelFilters.Controls.Add(this.label4);
            this.panelFilters.Controls.Add(this.label3);
            this.panelFilters.Controls.Add(this.txtTitle);
            this.panelFilters.Controls.Add(this.txtAuthor);
            this.panelFilters.Controls.Add(this.label2);
            this.panelFilters.Controls.Add(this.txtGridText);
            this.panelFilters.Controls.Add(this.txtGridIndex);
            this.panelFilters.Controls.Add(this.cmbLang);
            this.panelFilters.Controls.Add(this.label1);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(933, 93);
            this.panelFilters.TabIndex = 93;
            this.panelFilters.Visible = false;
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCreated.Location = new System.Drawing.Point(485, 14);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(80, 13);
            this.labelDateCreated.TabIndex = 99;
            this.labelDateCreated.Text = "Date Created: ";
            this.labelDateCreated.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 98;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(233, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(246, 25);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(65, 7);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(115, 25);
            this.txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Filters";
            // 
            // txtGridText
            // 
            this.txtGridText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGridText.Location = new System.Drawing.Point(144, 62);
            this.txtGridText.Name = "txtGridText";
            this.txtGridText.Size = new System.Drawing.Size(121, 25);
            this.txtGridText.TabIndex = 4;
            this.txtGridText.TextChanged += new System.EventHandler(this.txtGridText_TextChanged);
            // 
            // txtGridIndex
            // 
            this.txtGridIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGridIndex.Location = new System.Drawing.Point(12, 62);
            this.txtGridIndex.Name = "txtGridIndex";
            this.txtGridIndex.Size = new System.Drawing.Size(121, 25);
            this.txtGridIndex.TabIndex = 3;
            this.txtGridIndex.TextChanged += new System.EventHandler(this.txtGridIndex_TextChanged);
            // 
            // cmbLang
            // 
            this.cmbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Location = new System.Drawing.Point(833, 7);
            this.cmbLang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(88, 25);
            this.cmbLang.TabIndex = 90;
            this.cmbLang.SelectedIndexChanged += new System.EventHandler(this.cmbLang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Language";
            // 
            // panelApply
            // 
            this.panelApply.Controls.Add(this.chkSwapFile);
            this.panelApply.Controls.Add(this.btnSave);
            this.panelApply.Controls.Add(this.chkTextApply);
            this.panelApply.Controls.Add(this.btnReset);
            this.panelApply.Controls.Add(this.btnLoad);
            this.panelApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelApply.Location = new System.Drawing.Point(0, 525);
            this.panelApply.Name = "panelApply";
            this.panelApply.Size = new System.Drawing.Size(933, 63);
            this.panelApply.TabIndex = 90;
            // 
            // chkSwapFile
            // 
            this.chkSwapFile.AutoSize = true;
            this.chkSwapFile.Location = new System.Drawing.Point(361, 21);
            this.chkSwapFile.Name = "chkSwapFile";
            this.chkSwapFile.Size = new System.Drawing.Size(216, 21);
            this.chkSwapFile.TabIndex = 70;
            this.chkSwapFile.Text = "Include in Swap File when Saving";
            this.chkSwapFile.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 19);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 25);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Export";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkTextApply
            // 
            this.chkTextApply.AutoSize = true;
            this.chkTextApply.Location = new System.Drawing.Point(144, 21);
            this.chkTextApply.Name = "chkTextApply";
            this.chkTextApply.Size = new System.Drawing.Size(211, 21);
            this.chkTextApply.TabIndex = 68;
            this.chkTextApply.Text = "Include in next \"Apply Changes\"";
            this.chkTextApply.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(818, 17);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 25);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset to default";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(73, 19);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(55, 25);
            this.btnLoad.TabIndex = 66;
            this.btnLoad.Text = "Import";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelApply);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TextEditor";
            this.Text = "SOR4 Swapper Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelApply.ResumeLayout(false);
            this.panelApply.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelApply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkTextApply;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGridText;
        private System.Windows.Forms.TextBox txtGridIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDateCreated;
        public System.Windows.Forms.CheckBox chkSwapFile;
    }
}