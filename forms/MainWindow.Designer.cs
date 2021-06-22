namespace SOR4_Replacer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelDisplayList = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ofdLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenBigfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnShowRandomPanel = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelInstructions = new System.Windows.Forms.Panel();
            this.colDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newThumbCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.newCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiddenIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDisplayList
            // 
            this.labelDisplayList.AutoSize = true;
            this.labelDisplayList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayList.Location = new System.Drawing.Point(585, 56);
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
            this.colText,
            this.pointer,
            this.newThumbCol,
            this.newCol,
            this.hiddenIndex});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(586, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(402, 401);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(10, 140);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 90);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load swap list";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ofdLoadDialog
            // 
            this.ofdLoadDialog.Filter = "SOR4 Swapper Settings|*.swap";
            this.ofdLoadDialog.Title = "Load Settings File";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(763, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 26);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save swap list";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenBigfile
            // 
            this.btnOpenBigfile.FlatAppearance.BorderSize = 0;
            this.btnOpenBigfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenBigfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBigfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBigfile.ForeColor = System.Drawing.Color.White;
            this.btnOpenBigfile.Location = new System.Drawing.Point(10, 30);
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
            this.btnClose.Location = new System.Drawing.Point(424, 0);
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
            this.panelLeft.Controls.Add(this.btnShowRandomPanel);
            this.panelLeft.Controls.Add(this.btnInstructions);
            this.panelLeft.Controls.Add(this.btnLoad);
            this.panelLeft.Controls.Add(this.btnOpenBigfile);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(110, 500);
            this.panelLeft.TabIndex = 42;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            // 
            // btnShowRandomPanel
            // 
            this.btnShowRandomPanel.FlatAppearance.BorderSize = 0;
            this.btnShowRandomPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowRandomPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRandomPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRandomPanel.ForeColor = System.Drawing.Color.White;
            this.btnShowRandomPanel.Location = new System.Drawing.Point(10, 250);
            this.btnShowRandomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowRandomPanel.Name = "btnShowRandomPanel";
            this.btnShowRandomPanel.Size = new System.Drawing.Size(90, 90);
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
            this.btnInstructions.Location = new System.Drawing.Point(10, 360);
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
            this.panelTop.Controls.Add(this.labelAuthor);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(110, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(460, 36);
            this.panelTop.TabIndex = 44;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(234, 13);
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
            this.btnMinimize.Location = new System.Drawing.Point(388, 0);
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
            this.labelTitle.Size = new System.Drawing.Size(224, 21);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "SOR4 CHARACTER SWAPPER";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(110, 36);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(460, 464);
            this.panelContainer.TabIndex = 46;
            // 
            // panelInstructions
            // 
            this.panelInstructions.Location = new System.Drawing.Point(108, 37);
            this.panelInstructions.Name = "panelInstructions";
            this.panelInstructions.Size = new System.Drawing.Size(460, 463);
            this.panelInstructions.TabIndex = 47;
            this.panelInstructions.Visible = false;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDel.HeaderText = "";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDel.ToolTipText = "Remove";
            this.colDel.Width = 30;
            // 
            // origThumbCol
            // 
            this.origThumbCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = null;
            this.origThumbCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.origThumbCol.HeaderText = "Thumbnail Original";
            this.origThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.origThumbCol.Name = "origThumbCol";
            this.origThumbCol.ReadOnly = true;
            this.origThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.origThumbCol.Width = 40;
            // 
            // colText
            // 
            this.colText.DataPropertyName = "original";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colText.DefaultCellStyle = dataGridViewCellStyle3;
            this.colText.HeaderText = "Change";
            this.colText.MinimumWidth = 6;
            this.colText.Name = "colText";
            this.colText.ReadOnly = true;
            this.colText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colText.Width = 110;
            // 
            // pointer
            // 
            this.pointer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.pointer.DefaultCellStyle = dataGridViewCellStyle4;
            this.pointer.HeaderText = "";
            this.pointer.Name = "pointer";
            this.pointer.ReadOnly = true;
            this.pointer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pointer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pointer.Width = 30;
            // 
            // newThumbCol
            // 
            this.newThumbCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.NullValue = null;
            this.newThumbCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.newThumbCol.HeaderText = "New Thumbnail";
            this.newThumbCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.newThumbCol.Name = "newThumbCol";
            this.newThumbCol.ReadOnly = true;
            this.newThumbCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newThumbCol.Width = 40;
            // 
            // newCol
            // 
            this.newCol.DataPropertyName = "replacement";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.newCol.HeaderText = "New";
            this.newCol.MinimumWidth = 6;
            this.newCol.Name = "newCol";
            this.newCol.ReadOnly = true;
            this.newCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.newCol.Width = 110;
            // 
            // hiddenIndex
            // 
            this.hiddenIndex.DataPropertyName = "hidden";
            this.hiddenIndex.HeaderText = "hidden";
            this.hiddenIndex.MinimumWidth = 6;
            this.hiddenIndex.Name = "hiddenIndex";
            this.hiddenIndex.ReadOnly = true;
            this.hiddenIndex.Visible = false;
            this.hiddenIndex.Width = 125;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(570, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDisplayList);
            this.Controls.Add(this.panelInstructions);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MainWindow";
            this.Text = "SOR4 CHARACTER SWAPPER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDisplayList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdLoadDialog;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenBigfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnInstructions;
        public System.Windows.Forms.Button btnShowRandomPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDel;
        private System.Windows.Forms.DataGridViewImageColumn origThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointer;
        private System.Windows.Forms.DataGridViewImageColumn newThumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenIndex;
    }
}

