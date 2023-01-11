
namespace SOR4_Swapper
{
    partial class CustomizerItems
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
            this.labelFood = new System.Windows.Forms.Label();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.labelMovesSeparator = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.cmbWeaponType = new System.Windows.Forms.ComboBox();
            this.btnResetItem = new System.Windows.Forms.Button();
            this.btnResetWeapon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hit_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitstop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitstun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recoverHP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageToSelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkCatchable = new System.Windows.Forms.CheckBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLife = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.picThumbOrig = new System.Windows.Forms.PictureBox();
            this.btnClearSwapList = new System.Windows.Forms.Button();
            this.btnSetItem = new System.Windows.Forms.Button();
            this.labelCharacterList = new System.Windows.Forms.Label();
            this.btnScoreReset = new System.Windows.Forms.Button();
            this.btnStarReset = new System.Windows.Forms.Button();
            this.btnLifeReset = new System.Windows.Forms.Button();
            this.btnHealthReset = new System.Windows.Forms.Button();
            this.labelOrigStar = new System.Windows.Forms.Label();
            this.labelOrigScore = new System.Windows.Forms.Label();
            this.labelOrigLife = new System.Windows.Forms.Label();
            this.labelWhenThrown = new System.Windows.Forms.Label();
            this.chkGravity = new System.Windows.Forms.CheckBox();
            this.chkPassthrough = new System.Windows.Forms.CheckBox();
            this.labelThrowDamage = new System.Windows.Forms.Label();
            this.txtThrowDamage = new System.Windows.Forms.TextBox();
            this.btnThrowDamage = new System.Windows.Forms.Button();
            this.labelOrigHealth = new System.Windows.Forms.Label();
            this.labelOrigThrowDamage = new System.Windows.Forms.Label();
            this.chkDroppable = new System.Windows.Forms.CheckBox();
            this.txtThrowX = new System.Windows.Forms.TextBox();
            this.txtThrowY = new System.Windows.Forms.TextBox();
            this.labelThrowX = new System.Windows.Forms.Label();
            this.labelThrowY = new System.Windows.Forms.Label();
            this.labelThrowSpeedLabel = new System.Windows.Forms.Label();
            this.labelOrigThrowX = new System.Windows.Forms.Label();
            this.labelOrigThrowY = new System.Windows.Forms.Label();
            this.cmbTransformOnHit = new System.Windows.Forms.ComboBox();
            this.chkThrowOnly = new System.Windows.Forms.CheckBox();
            this.labelTransformOnHit = new System.Windows.Forms.Label();
            this.labelDamageToSelfOnThrow = new System.Windows.Forms.Label();
            this.txtDamageToSelfOnThrow = new System.Windows.Forms.TextBox();
            this.labelOrigDamageToSelfOnThrow = new System.Windows.Forms.Label();
            this.btnDamageToSelfOnThrowReset = new System.Windows.Forms.Button();
            this.btnThrowSpeedReset = new System.Windows.Forms.Button();
            this.labelThrowSeparator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(199, 10);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(60, 13);
            this.labelFood.TabIndex = 161;
            this.labelFood.Text = "Food Type";
            // 
            // cmbFood
            // 
            this.cmbFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.Enabled = false;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(202, 26);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(77, 21);
            this.cmbFood.TabIndex = 160;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // labelMovesSeparator
            // 
            this.labelMovesSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMovesSeparator.Location = new System.Drawing.Point(12, 157);
            this.labelMovesSeparator.Name = "labelMovesSeparator";
            this.labelMovesSeparator.Size = new System.Drawing.Size(410, 2);
            this.labelMovesSeparator.TabIndex = 158;
            this.labelMovesSeparator.Visible = false;
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Location = new System.Drawing.Point(39, 323);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(68, 13);
            this.labelHealth.TabIndex = 157;
            this.labelHealth.Text = "Weapon HP";
            this.labelHealth.Visible = false;
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Enabled = false;
            this.chkRotate.Location = new System.Drawing.Point(292, 356);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(60, 17);
            this.chkRotate.TabIndex = 156;
            this.chkRotate.Text = "Rotate";
            this.chkRotate.UseVisualStyleBackColor = true;
            this.chkRotate.Visible = false;
            this.chkRotate.CheckedChanged += new System.EventHandler(this.chkRotate_CheckedChanged);
            // 
            // txtHealth
            // 
            this.txtHealth.Enabled = false;
            this.txtHealth.Location = new System.Drawing.Point(109, 318);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(68, 22);
            this.txtHealth.TabIndex = 155;
            this.txtHealth.Visible = false;
            this.txtHealth.TextChanged += new System.EventHandler(this.txtHealth_TextChanged);
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeapon.Location = new System.Drawing.Point(301, 10);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(77, 13);
            this.labelWeapon.TabIndex = 144;
            this.labelWeapon.Text = "Weapon Type";
            // 
            // cmbWeaponType
            // 
            this.cmbWeaponType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWeaponType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWeaponType.BackColor = System.Drawing.Color.White;
            this.cmbWeaponType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponType.Enabled = false;
            this.cmbWeaponType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeaponType.FormattingEnabled = true;
            this.cmbWeaponType.Location = new System.Drawing.Point(304, 26);
            this.cmbWeaponType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbWeaponType.Name = "cmbWeaponType";
            this.cmbWeaponType.Size = new System.Drawing.Size(103, 21);
            this.cmbWeaponType.TabIndex = 143;
            this.cmbWeaponType.SelectedIndexChanged += new System.EventHandler(this.cmbWeaponType_SelectedIndexChanged);
            // 
            // btnResetItem
            // 
            this.btnResetItem.Enabled = false;
            this.btnResetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetItem.Location = new System.Drawing.Point(432, 182);
            this.btnResetItem.Name = "btnResetItem";
            this.btnResetItem.Size = new System.Drawing.Size(76, 44);
            this.btnResetItem.TabIndex = 142;
            this.btnResetItem.Text = "Reset Item Properties";
            this.btnResetItem.UseVisualStyleBackColor = true;
            this.btnResetItem.Click += new System.EventHandler(this.btnResetItem_Click);
            // 
            // btnResetWeapon
            // 
            this.btnResetWeapon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetWeapon.Enabled = false;
            this.btnResetWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetWeapon.Location = new System.Drawing.Point(432, 254);
            this.btnResetWeapon.Name = "btnResetWeapon";
            this.btnResetWeapon.Size = new System.Drawing.Size(76, 57);
            this.btnResetWeapon.TabIndex = 141;
            this.btnResetWeapon.Text = "Reset Weapon Properties";
            this.btnResetWeapon.UseVisualStyleBackColor = true;
            this.btnResetWeapon.Click += new System.EventHandler(this.btnResetWeapon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hit_no,
            this.damage,
            this.hitstop,
            this.hitstun,
            this.multi,
            this.recoverHP,
            this.xForce,
            this.yForce,
            this.damageToSelf,
            this.Reset});
            this.dataGridView1.Location = new System.Drawing.Point(12, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(268, 139);
            this.dataGridView1.TabIndex = 140;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // hit_no
            // 
            this.hit_no.DataPropertyName = "hit_no";
            this.hit_no.HeaderText = "Hit #";
            this.hit_no.MinimumWidth = 6;
            this.hit_no.Name = "hit_no";
            this.hit_no.ReadOnly = true;
            this.hit_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hit_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hit_no.Width = 39;
            // 
            // damage
            // 
            this.damage.DataPropertyName = "damage";
            this.damage.HeaderText = "DMG";
            this.damage.MinimumWidth = 6;
            this.damage.Name = "damage";
            this.damage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.damage.Width = 40;
            // 
            // hitstop
            // 
            this.hitstop.DataPropertyName = "hitstop";
            this.hitstop.HeaderText = "Hitstop";
            this.hitstop.MinimumWidth = 6;
            this.hitstop.Name = "hitstop";
            this.hitstop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hitstop.Width = 52;
            // 
            // hitstun
            // 
            this.hitstun.DataPropertyName = "hitstun";
            this.hitstun.HeaderText = "Hitstun";
            this.hitstun.MinimumWidth = 6;
            this.hitstun.Name = "hitstun";
            this.hitstun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hitstun.Width = 52;
            // 
            // multi
            // 
            this.multi.HeaderText = "Multi";
            this.multi.MinimumWidth = 6;
            this.multi.Name = "multi";
            this.multi.Width = 40;
            // 
            // recoverHP
            // 
            this.recoverHP.HeaderText = "+HP";
            this.recoverHP.Name = "recoverHP";
            this.recoverHP.Width = 40;
            // 
            // xForce
            // 
            this.xForce.HeaderText = "X Force";
            this.xForce.Name = "xForce";
            this.xForce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xForce.Width = 52;
            // 
            // yForce
            // 
            this.yForce.HeaderText = "Y Force";
            this.yForce.Name = "yForce";
            this.yForce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yForce.Width = 52;
            // 
            // damageToSelf
            // 
            this.damageToSelf.HeaderText = "HP Cost";
            this.damageToSelf.Name = "damageToSelf";
            this.damageToSelf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.damageToSelf.Width = 60;
            // 
            // Reset
            // 
            this.Reset.DataPropertyName = "reset";
            this.Reset.HeaderText = "";
            this.Reset.MinimumWidth = 6;
            this.Reset.Name = "Reset";
            this.Reset.Text = "Reset";
            this.Reset.UseColumnTextForButtonValue = true;
            this.Reset.Width = 50;
            // 
            // chkCatchable
            // 
            this.chkCatchable.AutoSize = true;
            this.chkCatchable.Enabled = false;
            this.chkCatchable.Location = new System.Drawing.Point(292, 334);
            this.chkCatchable.Name = "chkCatchable";
            this.chkCatchable.Size = new System.Drawing.Size(106, 17);
            this.chkCatchable.TabIndex = 137;
            this.chkCatchable.Text = "Catchable in air";
            this.chkCatchable.UseVisualStyleBackColor = true;
            this.chkCatchable.Visible = false;
            this.chkCatchable.CheckedChanged += new System.EventHandler(this.chkCatchable_CheckedChanged);
            // 
            // txtStar
            // 
            this.txtStar.Enabled = false;
            this.txtStar.Location = new System.Drawing.Point(351, 72);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(48, 22);
            this.txtStar.TabIndex = 135;
            this.txtStar.TextChanged += new System.EventHandler(this.txtStar_TextChanged);
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(276, 72);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(48, 22);
            this.txtScore.TabIndex = 134;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtLife
            // 
            this.txtLife.Enabled = false;
            this.txtLife.Location = new System.Drawing.Point(202, 72);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(48, 22);
            this.txtLife.TabIndex = 133;
            this.txtLife.TextChanged += new System.EventHandler(this.txtLife_TextChanged);
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.Location = new System.Drawing.Point(348, 56);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(27, 13);
            this.labelStar.TabIndex = 131;
            this.labelStar.Text = "Star";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(273, 56);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 130;
            this.labelScore.Text = "Score";
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLife.Location = new System.Drawing.Point(199, 56);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(41, 13);
            this.labelLife.TabIndex = 129;
            this.labelLife.Text = "Health";
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
            this.btnShowList.TabIndex = 127;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // itemList
            // 
            this.itemList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemList.BackColor = System.Drawing.Color.White;
            this.itemList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(12, 27);
            this.itemList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(163, 23);
            this.itemList.TabIndex = 123;
            // 
            // picThumbOrig
            // 
            this.picThumbOrig.Location = new System.Drawing.Point(12, 53);
            this.picThumbOrig.Name = "picThumbOrig";
            this.picThumbOrig.Size = new System.Drawing.Size(163, 90);
            this.picThumbOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumbOrig.TabIndex = 126;
            this.picThumbOrig.TabStop = false;
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
            this.btnClearSwapList.TabIndex = 125;
            this.btnClearSwapList.Text = "Clear list";
            this.btnClearSwapList.UseVisualStyleBackColor = true;
            this.btnClearSwapList.Click += new System.EventHandler(this.btnClearSwapList_Click);
            // 
            // btnSetItem
            // 
            this.btnSetItem.Enabled = false;
            this.btnSetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetItem.Location = new System.Drawing.Point(432, 27);
            this.btnSetItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSetItem.Name = "btnSetItem";
            this.btnSetItem.Size = new System.Drawing.Size(76, 25);
            this.btnSetItem.TabIndex = 124;
            this.btnSetItem.Text = "Add to list";
            this.btnSetItem.UseVisualStyleBackColor = true;
            this.btnSetItem.Click += new System.EventHandler(this.btnSetItem_Click);
            // 
            // labelCharacterList
            // 
            this.labelCharacterList.AutoSize = true;
            this.labelCharacterList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharacterList.Location = new System.Drawing.Point(9, 10);
            this.labelCharacterList.Name = "labelCharacterList";
            this.labelCharacterList.Size = new System.Drawing.Size(29, 13);
            this.labelCharacterList.TabIndex = 122;
            this.labelCharacterList.Text = "Item";
            // 
            // btnScoreReset
            // 
            this.btnScoreReset.Enabled = false;
            this.btnScoreReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreReset.Location = new System.Drawing.Point(322, 71);
            this.btnScoreReset.Name = "btnScoreReset";
            this.btnScoreReset.Size = new System.Drawing.Size(24, 24);
            this.btnScoreReset.TabIndex = 147;
            this.btnScoreReset.Text = "Reset";
            this.btnScoreReset.UseVisualStyleBackColor = true;
            this.btnScoreReset.Click += new System.EventHandler(this.btnScoreReset_Click);
            // 
            // btnStarReset
            // 
            this.btnStarReset.Enabled = false;
            this.btnStarReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarReset.Location = new System.Drawing.Point(397, 71);
            this.btnStarReset.Name = "btnStarReset";
            this.btnStarReset.Size = new System.Drawing.Size(24, 24);
            this.btnStarReset.TabIndex = 148;
            this.btnStarReset.Text = "Reset";
            this.btnStarReset.UseVisualStyleBackColor = true;
            this.btnStarReset.Click += new System.EventHandler(this.btnStarReset_Click);
            // 
            // btnLifeReset
            // 
            this.btnLifeReset.Enabled = false;
            this.btnLifeReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLifeReset.Location = new System.Drawing.Point(248, 71);
            this.btnLifeReset.Name = "btnLifeReset";
            this.btnLifeReset.Size = new System.Drawing.Size(24, 24);
            this.btnLifeReset.TabIndex = 149;
            this.btnLifeReset.Text = "Reset";
            this.btnLifeReset.UseVisualStyleBackColor = true;
            this.btnLifeReset.Click += new System.EventHandler(this.btnLifeReset_Click);
            // 
            // btnHealthReset
            // 
            this.btnHealthReset.Enabled = false;
            this.btnHealthReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealthReset.Location = new System.Drawing.Point(175, 317);
            this.btnHealthReset.Name = "btnHealthReset";
            this.btnHealthReset.Size = new System.Drawing.Size(24, 24);
            this.btnHealthReset.TabIndex = 166;
            this.btnHealthReset.Text = "Reset";
            this.btnHealthReset.UseVisualStyleBackColor = true;
            this.btnHealthReset.Visible = false;
            this.btnHealthReset.Click += new System.EventHandler(this.btnHealthReset_Click);
            // 
            // labelOrigStar
            // 
            this.labelOrigStar.AutoSize = true;
            this.labelOrigStar.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigStar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigStar.Location = new System.Drawing.Point(349, 97);
            this.labelOrigStar.Name = "labelOrigStar";
            this.labelOrigStar.Size = new System.Drawing.Size(29, 12);
            this.labelOrigStar.TabIndex = 172;
            this.labelOrigStar.Text = "label3";
            this.labelOrigStar.Visible = false;
            // 
            // labelOrigScore
            // 
            this.labelOrigScore.AutoSize = true;
            this.labelOrigScore.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigScore.Location = new System.Drawing.Point(274, 97);
            this.labelOrigScore.Name = "labelOrigScore";
            this.labelOrigScore.Size = new System.Drawing.Size(29, 12);
            this.labelOrigScore.TabIndex = 171;
            this.labelOrigScore.Text = "label2";
            this.labelOrigScore.Visible = false;
            // 
            // labelOrigLife
            // 
            this.labelOrigLife.AutoSize = true;
            this.labelOrigLife.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigLife.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigLife.Location = new System.Drawing.Point(200, 97);
            this.labelOrigLife.Name = "labelOrigLife";
            this.labelOrigLife.Size = new System.Drawing.Size(29, 12);
            this.labelOrigLife.TabIndex = 170;
            this.labelOrigLife.Text = "label1";
            this.labelOrigLife.Visible = false;
            // 
            // labelWhenThrown
            // 
            this.labelWhenThrown.AutoSize = true;
            this.labelWhenThrown.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhenThrown.Location = new System.Drawing.Point(288, 170);
            this.labelWhenThrown.Name = "labelWhenThrown";
            this.labelWhenThrown.Size = new System.Drawing.Size(111, 13);
            this.labelWhenThrown.TabIndex = 173;
            this.labelWhenThrown.Text = "--- When Thrown ---";
            this.labelWhenThrown.Visible = false;
            // 
            // chkGravity
            // 
            this.chkGravity.AutoSize = true;
            this.chkGravity.Enabled = false;
            this.chkGravity.Location = new System.Drawing.Point(292, 377);
            this.chkGravity.Name = "chkGravity";
            this.chkGravity.Size = new System.Drawing.Size(92, 17);
            this.chkGravity.TabIndex = 174;
            this.chkGravity.Text = "Apply gravity";
            this.chkGravity.UseVisualStyleBackColor = true;
            this.chkGravity.Visible = false;
            this.chkGravity.CheckedChanged += new System.EventHandler(this.chkGravity_CheckedChanged);
            // 
            // chkPassthrough
            // 
            this.chkPassthrough.AutoSize = true;
            this.chkPassthrough.Enabled = false;
            this.chkPassthrough.Location = new System.Drawing.Point(292, 398);
            this.chkPassthrough.Name = "chkPassthrough";
            this.chkPassthrough.Size = new System.Drawing.Size(133, 17);
            this.chkPassthrough.TabIndex = 175;
            this.chkPassthrough.Text = "Pass through targets";
            this.chkPassthrough.UseVisualStyleBackColor = true;
            this.chkPassthrough.Visible = false;
            this.chkPassthrough.CheckedChanged += new System.EventHandler(this.chkPassthrough_CheckedChanged);
            // 
            // labelThrowDamage
            // 
            this.labelThrowDamage.AutoSize = true;
            this.labelThrowDamage.Location = new System.Drawing.Point(289, 190);
            this.labelThrowDamage.Name = "labelThrowDamage";
            this.labelThrowDamage.Size = new System.Drawing.Size(49, 13);
            this.labelThrowDamage.TabIndex = 178;
            this.labelThrowDamage.Text = "Damage";
            this.labelThrowDamage.Visible = false;
            // 
            // txtThrowDamage
            // 
            this.txtThrowDamage.Enabled = false;
            this.txtThrowDamage.Location = new System.Drawing.Point(341, 186);
            this.txtThrowDamage.Name = "txtThrowDamage";
            this.txtThrowDamage.Size = new System.Drawing.Size(58, 22);
            this.txtThrowDamage.TabIndex = 177;
            this.txtThrowDamage.Visible = false;
            this.txtThrowDamage.TextChanged += new System.EventHandler(this.txtThrowDamage_TextChanged);
            // 
            // btnThrowDamage
            // 
            this.btnThrowDamage.Enabled = false;
            this.btnThrowDamage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrowDamage.Location = new System.Drawing.Point(397, 185);
            this.btnThrowDamage.Name = "btnThrowDamage";
            this.btnThrowDamage.Size = new System.Drawing.Size(24, 24);
            this.btnThrowDamage.TabIndex = 179;
            this.btnThrowDamage.Text = "Reset";
            this.btnThrowDamage.UseVisualStyleBackColor = true;
            this.btnThrowDamage.Visible = false;
            this.btnThrowDamage.Click += new System.EventHandler(this.btnThrowDamage_Click);
            // 
            // labelOrigHealth
            // 
            this.labelOrigHealth.AutoSize = true;
            this.labelOrigHealth.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigHealth.Location = new System.Drawing.Point(200, 322);
            this.labelOrigHealth.Name = "labelOrigHealth";
            this.labelOrigHealth.Size = new System.Drawing.Size(29, 12);
            this.labelOrigHealth.TabIndex = 184;
            this.labelOrigHealth.Text = "label1";
            this.labelOrigHealth.Visible = false;
            // 
            // labelOrigThrowDamage
            // 
            this.labelOrigThrowDamage.AutoSize = true;
            this.labelOrigThrowDamage.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigThrowDamage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigThrowDamage.Location = new System.Drawing.Point(339, 211);
            this.labelOrigThrowDamage.Name = "labelOrigThrowDamage";
            this.labelOrigThrowDamage.Size = new System.Drawing.Size(29, 12);
            this.labelOrigThrowDamage.TabIndex = 185;
            this.labelOrigThrowDamage.Text = "label1";
            this.labelOrigThrowDamage.Visible = false;
            // 
            // chkDroppable
            // 
            this.chkDroppable.AutoSize = true;
            this.chkDroppable.Enabled = false;
            this.chkDroppable.Location = new System.Drawing.Point(109, 347);
            this.chkDroppable.Name = "chkDroppable";
            this.chkDroppable.Size = new System.Drawing.Size(81, 17);
            this.chkDroppable.TabIndex = 186;
            this.chkDroppable.Text = "Droppable";
            this.chkDroppable.UseVisualStyleBackColor = true;
            this.chkDroppable.Visible = false;
            this.chkDroppable.CheckedChanged += new System.EventHandler(this.chkDroppable_CheckedChanged);
            // 
            // txtThrowX
            // 
            this.txtThrowX.Enabled = false;
            this.txtThrowX.Location = new System.Drawing.Point(302, 279);
            this.txtThrowX.Name = "txtThrowX";
            this.txtThrowX.Size = new System.Drawing.Size(38, 22);
            this.txtThrowX.TabIndex = 187;
            this.txtThrowX.Visible = false;
            this.txtThrowX.TextChanged += new System.EventHandler(this.txtThrowX_TextChanged);
            // 
            // txtThrowY
            // 
            this.txtThrowY.Enabled = false;
            this.txtThrowY.Location = new System.Drawing.Point(361, 279);
            this.txtThrowY.Name = "txtThrowY";
            this.txtThrowY.Size = new System.Drawing.Size(38, 22);
            this.txtThrowY.TabIndex = 188;
            this.txtThrowY.Visible = false;
            this.txtThrowY.TextChanged += new System.EventHandler(this.txtThrowY_TextChanged);
            // 
            // labelThrowX
            // 
            this.labelThrowX.AutoSize = true;
            this.labelThrowX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThrowX.Location = new System.Drawing.Point(289, 282);
            this.labelThrowX.Name = "labelThrowX";
            this.labelThrowX.Size = new System.Drawing.Size(13, 13);
            this.labelThrowX.TabIndex = 189;
            this.labelThrowX.Text = "X";
            this.labelThrowX.Visible = false;
            // 
            // labelThrowY
            // 
            this.labelThrowY.AutoSize = true;
            this.labelThrowY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThrowY.Location = new System.Drawing.Point(348, 282);
            this.labelThrowY.Name = "labelThrowY";
            this.labelThrowY.Size = new System.Drawing.Size(12, 13);
            this.labelThrowY.TabIndex = 190;
            this.labelThrowY.Text = "Y";
            this.labelThrowY.Visible = false;
            // 
            // labelThrowSpeedLabel
            // 
            this.labelThrowSpeedLabel.AutoSize = true;
            this.labelThrowSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThrowSpeedLabel.Location = new System.Drawing.Point(289, 263);
            this.labelThrowSpeedLabel.Name = "labelThrowSpeedLabel";
            this.labelThrowSpeedLabel.Size = new System.Drawing.Size(75, 13);
            this.labelThrowSpeedLabel.TabIndex = 191;
            this.labelThrowSpeedLabel.Text = "Throw Speed";
            this.labelThrowSpeedLabel.Visible = false;
            // 
            // labelOrigThrowX
            // 
            this.labelOrigThrowX.AutoSize = true;
            this.labelOrigThrowX.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigThrowX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigThrowX.Location = new System.Drawing.Point(300, 304);
            this.labelOrigThrowX.Name = "labelOrigThrowX";
            this.labelOrigThrowX.Size = new System.Drawing.Size(29, 12);
            this.labelOrigThrowX.TabIndex = 192;
            this.labelOrigThrowX.Text = "label1";
            this.labelOrigThrowX.Visible = false;
            // 
            // labelOrigThrowY
            // 
            this.labelOrigThrowY.AutoSize = true;
            this.labelOrigThrowY.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigThrowY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigThrowY.Location = new System.Drawing.Point(359, 304);
            this.labelOrigThrowY.Name = "labelOrigThrowY";
            this.labelOrigThrowY.Size = new System.Drawing.Size(29, 12);
            this.labelOrigThrowY.TabIndex = 193;
            this.labelOrigThrowY.Text = "label1";
            this.labelOrigThrowY.Visible = false;
            // 
            // cmbTransformOnHit
            // 
            this.cmbTransformOnHit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTransformOnHit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTransformOnHit.BackColor = System.Drawing.Color.White;
            this.cmbTransformOnHit.Enabled = false;
            this.cmbTransformOnHit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransformOnHit.FormattingEnabled = true;
            this.cmbTransformOnHit.Location = new System.Drawing.Point(202, 127);
            this.cmbTransformOnHit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbTransformOnHit.Name = "cmbTransformOnHit";
            this.cmbTransformOnHit.Size = new System.Drawing.Size(163, 23);
            this.cmbTransformOnHit.TabIndex = 194;
            this.cmbTransformOnHit.Visible = false;
            this.cmbTransformOnHit.SelectedIndexChanged += new System.EventHandler(this.cmbTransformOnHit_SelectedIndexChanged);
            // 
            // chkThrowOnly
            // 
            this.chkThrowOnly.AutoSize = true;
            this.chkThrowOnly.Enabled = false;
            this.chkThrowOnly.Location = new System.Drawing.Point(109, 367);
            this.chkThrowOnly.Name = "chkThrowOnly";
            this.chkThrowOnly.Size = new System.Drawing.Size(84, 17);
            this.chkThrowOnly.TabIndex = 195;
            this.chkThrowOnly.Text = "Throw only";
            this.chkThrowOnly.UseVisualStyleBackColor = true;
            this.chkThrowOnly.Visible = false;
            // 
            // labelTransformOnHit
            // 
            this.labelTransformOnHit.AutoSize = true;
            this.labelTransformOnHit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransformOnHit.Location = new System.Drawing.Point(199, 112);
            this.labelTransformOnHit.Name = "labelTransformOnHit";
            this.labelTransformOnHit.Size = new System.Drawing.Size(132, 13);
            this.labelTransformOnHit.TabIndex = 196;
            this.labelTransformOnHit.Text = "Replace with item on hit";
            this.labelTransformOnHit.Visible = false;
            // 
            // labelDamageToSelfOnThrow
            // 
            this.labelDamageToSelfOnThrow.AutoSize = true;
            this.labelDamageToSelfOnThrow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamageToSelfOnThrow.Location = new System.Drawing.Point(288, 231);
            this.labelDamageToSelfOnThrow.Name = "labelDamageToSelfOnThrow";
            this.labelDamageToSelfOnThrow.Size = new System.Drawing.Size(47, 13);
            this.labelDamageToSelfOnThrow.TabIndex = 198;
            this.labelDamageToSelfOnThrow.Text = "HP Cost";
            this.labelDamageToSelfOnThrow.Visible = false;
            // 
            // txtDamageToSelfOnThrow
            // 
            this.txtDamageToSelfOnThrow.Enabled = false;
            this.txtDamageToSelfOnThrow.Location = new System.Drawing.Point(341, 226);
            this.txtDamageToSelfOnThrow.Name = "txtDamageToSelfOnThrow";
            this.txtDamageToSelfOnThrow.Size = new System.Drawing.Size(58, 22);
            this.txtDamageToSelfOnThrow.TabIndex = 197;
            this.txtDamageToSelfOnThrow.Visible = false;
            this.txtDamageToSelfOnThrow.TextChanged += new System.EventHandler(this.txtDamageToSelfOnThrow_TextChanged);
            // 
            // labelOrigDamageToSelfOnThrow
            // 
            this.labelOrigDamageToSelfOnThrow.AutoSize = true;
            this.labelOrigDamageToSelfOnThrow.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigDamageToSelfOnThrow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigDamageToSelfOnThrow.Location = new System.Drawing.Point(339, 251);
            this.labelOrigDamageToSelfOnThrow.Name = "labelOrigDamageToSelfOnThrow";
            this.labelOrigDamageToSelfOnThrow.Size = new System.Drawing.Size(29, 12);
            this.labelOrigDamageToSelfOnThrow.TabIndex = 199;
            this.labelOrigDamageToSelfOnThrow.Text = "label1";
            this.labelOrigDamageToSelfOnThrow.Visible = false;
            // 
            // btnDamageToSelfOnThrowReset
            // 
            this.btnDamageToSelfOnThrowReset.Enabled = false;
            this.btnDamageToSelfOnThrowReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDamageToSelfOnThrowReset.Location = new System.Drawing.Point(397, 225);
            this.btnDamageToSelfOnThrowReset.Name = "btnDamageToSelfOnThrowReset";
            this.btnDamageToSelfOnThrowReset.Size = new System.Drawing.Size(24, 24);
            this.btnDamageToSelfOnThrowReset.TabIndex = 200;
            this.btnDamageToSelfOnThrowReset.Text = "Reset";
            this.btnDamageToSelfOnThrowReset.UseVisualStyleBackColor = true;
            this.btnDamageToSelfOnThrowReset.Visible = false;
            this.btnDamageToSelfOnThrowReset.Click += new System.EventHandler(this.btnDamageToSelfOnThrowReset_Click);
            // 
            // btnThrowSpeedReset
            // 
            this.btnThrowSpeedReset.Enabled = false;
            this.btnThrowSpeedReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrowSpeedReset.Location = new System.Drawing.Point(397, 278);
            this.btnThrowSpeedReset.Name = "btnThrowSpeedReset";
            this.btnThrowSpeedReset.Size = new System.Drawing.Size(24, 24);
            this.btnThrowSpeedReset.TabIndex = 202;
            this.btnThrowSpeedReset.Text = "Reset";
            this.btnThrowSpeedReset.UseVisualStyleBackColor = true;
            this.btnThrowSpeedReset.Visible = false;
            this.btnThrowSpeedReset.Click += new System.EventHandler(this.btnThrowYReset_Click);
            // 
            // labelThrowSeparator
            // 
            this.labelThrowSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelThrowSeparator.Location = new System.Drawing.Point(285, 172);
            this.labelThrowSeparator.Name = "labelThrowSeparator";
            this.labelThrowSeparator.Size = new System.Drawing.Size(2, 244);
            this.labelThrowSeparator.TabIndex = 203;
            this.labelThrowSeparator.Visible = false;
            // 
            // CustomizerItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelThrowSeparator);
            this.Controls.Add(this.txtThrowX);
            this.Controls.Add(this.txtThrowY);
            this.Controls.Add(this.btnThrowSpeedReset);
            this.Controls.Add(this.txtDamageToSelfOnThrow);
            this.Controls.Add(this.btnDamageToSelfOnThrowReset);
            this.Controls.Add(this.labelOrigDamageToSelfOnThrow);
            this.Controls.Add(this.labelDamageToSelfOnThrow);
            this.Controls.Add(this.labelTransformOnHit);
            this.Controls.Add(this.chkThrowOnly);
            this.Controls.Add(this.cmbTransformOnHit);
            this.Controls.Add(this.labelOrigThrowY);
            this.Controls.Add(this.labelOrigThrowX);
            this.Controls.Add(this.labelThrowSpeedLabel);
            this.Controls.Add(this.labelThrowY);
            this.Controls.Add(this.labelThrowX);
            this.Controls.Add(this.chkDroppable);
            this.Controls.Add(this.labelOrigThrowDamage);
            this.Controls.Add(this.labelOrigHealth);
            this.Controls.Add(this.labelThrowDamage);
            this.Controls.Add(this.txtThrowDamage);
            this.Controls.Add(this.btnThrowDamage);
            this.Controls.Add(this.chkPassthrough);
            this.Controls.Add(this.chkGravity);
            this.Controls.Add(this.labelWhenThrown);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.labelMovesSeparator);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.chkRotate);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.labelWeapon);
            this.Controls.Add(this.cmbWeaponType);
            this.Controls.Add(this.btnResetItem);
            this.Controls.Add(this.btnResetWeapon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkCatchable);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtLife);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.picThumbOrig);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.btnSetItem);
            this.Controls.Add(this.labelCharacterList);
            this.Controls.Add(this.btnScoreReset);
            this.Controls.Add(this.btnStarReset);
            this.Controls.Add(this.btnLifeReset);
            this.Controls.Add(this.btnHealthReset);
            this.Controls.Add(this.labelOrigStar);
            this.Controls.Add(this.labelOrigScore);
            this.Controls.Add(this.labelOrigLife);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomizerItems";
            this.Text = "CustomizerItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFood;
        public System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Label labelMovesSeparator;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.TextBox txtHealth;
        public System.Windows.Forms.Label labelWeapon;
        public System.Windows.Forms.ComboBox cmbWeaponType;
        private System.Windows.Forms.Button btnResetItem;
        private System.Windows.Forms.Button btnResetWeapon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkCatchable;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtLife;
        public System.Windows.Forms.Label labelStar;
        public System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.Label labelLife;
        public System.Windows.Forms.Button btnShowList;
        public System.Windows.Forms.ComboBox itemList;
        public System.Windows.Forms.PictureBox picThumbOrig;
        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.Button btnSetItem;
        public System.Windows.Forms.Label labelCharacterList;
        private System.Windows.Forms.Button btnScoreReset;
        private System.Windows.Forms.Button btnStarReset;
        private System.Windows.Forms.Button btnLifeReset;
        private System.Windows.Forms.Button btnHealthReset;
        private System.Windows.Forms.Label labelOrigStar;
        private System.Windows.Forms.Label labelOrigScore;
        private System.Windows.Forms.Label labelOrigLife;
        public System.Windows.Forms.Label labelWhenThrown;
        private System.Windows.Forms.CheckBox chkGravity;
        private System.Windows.Forms.CheckBox chkPassthrough;
        private System.Windows.Forms.Label labelThrowDamage;
        private System.Windows.Forms.TextBox txtThrowDamage;
        private System.Windows.Forms.Button btnThrowDamage;
        private System.Windows.Forms.Label labelOrigHealth;
        private System.Windows.Forms.Label labelOrigThrowDamage;
        private System.Windows.Forms.CheckBox chkDroppable;
        private System.Windows.Forms.TextBox txtThrowX;
        private System.Windows.Forms.TextBox txtThrowY;
        public System.Windows.Forms.Label labelThrowX;
        public System.Windows.Forms.Label labelThrowY;
        public System.Windows.Forms.Label labelThrowSpeedLabel;
        private System.Windows.Forms.Label labelOrigThrowX;
        private System.Windows.Forms.Label labelOrigThrowY;
        public System.Windows.Forms.ComboBox cmbTransformOnHit;
        private System.Windows.Forms.CheckBox chkThrowOnly;
        public System.Windows.Forms.Label labelTransformOnHit;
        public System.Windows.Forms.Label labelDamageToSelfOnThrow;
        private System.Windows.Forms.TextBox txtDamageToSelfOnThrow;
        private System.Windows.Forms.Label labelOrigDamageToSelfOnThrow;
        private System.Windows.Forms.Button btnDamageToSelfOnThrowReset;
        private System.Windows.Forms.Button btnThrowSpeedReset;
        private System.Windows.Forms.Label labelThrowSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn hit_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitstop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitstun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn multi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recoverHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn xForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn yForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageToSelf;
        private System.Windows.Forms.DataGridViewButtonColumn Reset;
    }
}