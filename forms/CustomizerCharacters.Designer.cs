
namespace SOR4_Swapper
{
    partial class CustomizerCharacters
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
            this.btnShowList = new System.Windows.Forms.Button();
            this.characterList = new System.Windows.Forms.ComboBox();
            this.picThumbOrig = new System.Windows.Forms.PictureBox();
            this.btnClearSwapList = new System.Windows.Forms.Button();
            this.btnSetItem = new System.Windows.Forms.Button();
            this.labelCharacterList = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelSpeedX = new System.Windows.Forms.Label();
            this.labelSpeedY = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtSpeedX = new System.Windows.Forms.TextBox();
            this.txtSpeedY = new System.Windows.Forms.TextBox();
            this.chkBoss = new System.Windows.Forms.CheckBox();
            this.chkDespawn = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMoveList = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hit_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitstop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitstun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnResetMove = new System.Windows.Forms.Button();
            this.btnResetCharacter = new System.Windows.Forms.Button();
            this.cmbShader = new System.Windows.Forms.ComboBox();
            this.labelShader = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.btnSpeedXReset = new System.Windows.Forms.Button();
            this.btnSpeedYReset = new System.Windows.Forms.Button();
            this.btnHealthReset = new System.Windows.Forms.Button();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.cmbMoveDpad = new System.Windows.Forms.ComboBox();
            this.cmbMoveButton = new System.Windows.Forms.ComboBox();
            this.cmbMoveArmor = new System.Windows.Forms.ComboBox();
            this.txtGreenHP = new System.Windows.Forms.TextBox();
            this.chkAlwaysArmor = new System.Windows.Forms.CheckBox();
            this.labelGreenHP = new System.Windows.Forms.Label();
            this.labelMovesSeparator = new System.Windows.Forms.Label();
            this.labelMoveArmor = new System.Windows.Forms.Label();
            this.cmbAI = new System.Windows.Forms.ComboBox();
            this.labelAI = new System.Windows.Forms.Label();
            this.labelAIPath = new System.Windows.Forms.Label();
            this.labelMoveInput = new System.Windows.Forms.Label();
            this.labelMoveDpad = new System.Windows.Forms.Label();
            this.labelMoveButton = new System.Windows.Forms.Label();
            this.btnGreenHPReset = new System.Windows.Forms.Button();
            this.btnMoveArmorReset = new System.Windows.Forms.Button();
            this.btnMoveDpadReset = new System.Windows.Forms.Button();
            this.btnMoveButtonReset = new System.Windows.Forms.Button();
            this.labelOrigHealth = new System.Windows.Forms.Label();
            this.labelOrigSpeedX = new System.Windows.Forms.Label();
            this.labelOrigSpeedY = new System.Windows.Forms.Label();
            this.btnAIReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnShowList.TabIndex = 67;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // characterList
            // 
            this.characterList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.characterList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.characterList.BackColor = System.Drawing.Color.White;
            this.characterList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterList.FormattingEnabled = true;
            this.characterList.Location = new System.Drawing.Point(12, 27);
            this.characterList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(163, 23);
            this.characterList.TabIndex = 63;
            // 
            // picThumbOrig
            // 
            this.picThumbOrig.Location = new System.Drawing.Point(12, 53);
            this.picThumbOrig.Name = "picThumbOrig";
            this.picThumbOrig.Size = new System.Drawing.Size(163, 90);
            this.picThumbOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThumbOrig.TabIndex = 66;
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
            this.btnClearSwapList.TabIndex = 65;
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
            this.btnSetItem.TabIndex = 64;
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
            this.labelCharacterList.Size = new System.Drawing.Size(56, 13);
            this.labelCharacterList.TabIndex = 62;
            this.labelCharacterList.Text = "Character";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(193, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 13);
            this.labelName.TabIndex = 68;
            this.labelName.Text = "Name";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(206, 54);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(41, 13);
            this.labelHealth.TabIndex = 69;
            this.labelHealth.Text = "Health";
            // 
            // labelSpeedX
            // 
            this.labelSpeedX.AutoSize = true;
            this.labelSpeedX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedX.Location = new System.Drawing.Point(199, 78);
            this.labelSpeedX.Name = "labelSpeedX";
            this.labelSpeedX.Size = new System.Drawing.Size(13, 13);
            this.labelSpeedX.TabIndex = 71;
            this.labelSpeedX.Text = "X";
            // 
            // labelSpeedY
            // 
            this.labelSpeedY.AutoSize = true;
            this.labelSpeedY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedY.Location = new System.Drawing.Point(205, 109);
            this.labelSpeedY.Name = "labelSpeedY";
            this.labelSpeedY.Size = new System.Drawing.Size(12, 13);
            this.labelSpeedY.TabIndex = 72;
            this.labelSpeedY.Text = "Y";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(231, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 22);
            this.txtName.TabIndex = 75;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.MouseHover += new System.EventHandler(this.txtName_MouseHover);
            // 
            // txtHealth
            // 
            this.txtHealth.Enabled = false;
            this.txtHealth.Location = new System.Drawing.Point(231, 55);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(38, 22);
            this.txtHealth.TabIndex = 76;
            this.txtHealth.TextChanged += new System.EventHandler(this.txtHealth_TextChanged);
            this.txtHealth.MouseHover += new System.EventHandler(this.txtHealth_MouseHover);
            // 
            // txtSpeedX
            // 
            this.txtSpeedX.Enabled = false;
            this.txtSpeedX.Location = new System.Drawing.Point(231, 86);
            this.txtSpeedX.Name = "txtSpeedX";
            this.txtSpeedX.Size = new System.Drawing.Size(38, 22);
            this.txtSpeedX.TabIndex = 77;
            this.txtSpeedX.TextChanged += new System.EventHandler(this.txtSpeedX_TextChanged);
            this.txtSpeedX.MouseHover += new System.EventHandler(this.txtSpeedX_MouseHover);
            // 
            // txtSpeedY
            // 
            this.txtSpeedY.Enabled = false;
            this.txtSpeedY.Location = new System.Drawing.Point(231, 117);
            this.txtSpeedY.Name = "txtSpeedY";
            this.txtSpeedY.Size = new System.Drawing.Size(38, 22);
            this.txtSpeedY.TabIndex = 78;
            this.txtSpeedY.TextChanged += new System.EventHandler(this.txtSpeedY_TextChanged);
            this.txtSpeedY.MouseHover += new System.EventHandler(this.txtSpeedY_MouseHover);
            // 
            // chkBoss
            // 
            this.chkBoss.AutoSize = true;
            this.chkBoss.Enabled = false;
            this.chkBoss.Location = new System.Drawing.Point(231, 150);
            this.chkBoss.Name = "chkBoss";
            this.chkBoss.Size = new System.Drawing.Size(49, 17);
            this.chkBoss.TabIndex = 79;
            this.chkBoss.Text = "Boss";
            this.chkBoss.UseVisualStyleBackColor = true;
            this.chkBoss.CheckedChanged += new System.EventHandler(this.chkBoss_CheckedChanged);
            this.chkBoss.MouseHover += new System.EventHandler(this.chkBoss_MouseHover);
            // 
            // chkDespawn
            // 
            this.chkDespawn.AutoSize = true;
            this.chkDespawn.Enabled = false;
            this.chkDespawn.Location = new System.Drawing.Point(286, 150);
            this.chkDespawn.Name = "chkDespawn";
            this.chkDespawn.Size = new System.Drawing.Size(134, 17);
            this.chkDespawn.TabIndex = 80;
            this.chkDespawn.Text = "Despawn after death";
            this.chkDespawn.UseVisualStyleBackColor = true;
            this.chkDespawn.CheckedChanged += new System.EventHandler(this.chkDespawn_CheckedChanged);
            this.chkDespawn.MouseHover += new System.EventHandler(this.chkDespawn_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Moves";
            // 
            // cmbMoveList
            // 
            this.cmbMoveList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMoveList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoveList.BackColor = System.Drawing.Color.White;
            this.cmbMoveList.Enabled = false;
            this.cmbMoveList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoveList.FormattingEnabled = true;
            this.cmbMoveList.Location = new System.Drawing.Point(55, 254);
            this.cmbMoveList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbMoveList.Name = "cmbMoveList";
            this.cmbMoveList.Size = new System.Drawing.Size(163, 23);
            this.cmbMoveList.TabIndex = 82;
            this.cmbMoveList.SelectedIndexChanged += new System.EventHandler(this.cmbMoveList_SelectedIndexChanged);
            this.cmbMoveList.MouseHover += new System.EventHandler(this.cmbMoveList_MouseHover);
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
            this.Reset});
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(268, 135);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            this.damage.HeaderText = "Damage";
            this.damage.MinimumWidth = 6;
            this.damage.Name = "damage";
            this.damage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.damage.Width = 57;
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
            // btnResetMove
            // 
            this.btnResetMove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetMove.Enabled = false;
            this.btnResetMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMove.Location = new System.Drawing.Point(432, 254);
            this.btnResetMove.Name = "btnResetMove";
            this.btnResetMove.Size = new System.Drawing.Size(76, 23);
            this.btnResetMove.TabIndex = 86;
            this.btnResetMove.Text = "Reset Move";
            this.btnResetMove.UseVisualStyleBackColor = true;
            this.btnResetMove.Click += new System.EventHandler(this.btnResetMove_Click);
            // 
            // btnResetCharacter
            // 
            this.btnResetCharacter.Enabled = false;
            this.btnResetCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCharacter.Location = new System.Drawing.Point(432, 182);
            this.btnResetCharacter.Name = "btnResetCharacter";
            this.btnResetCharacter.Size = new System.Drawing.Size(76, 44);
            this.btnResetCharacter.TabIndex = 87;
            this.btnResetCharacter.Text = "Reset Character";
            this.btnResetCharacter.UseVisualStyleBackColor = true;
            this.btnResetCharacter.Click += new System.EventHandler(this.btnResetCharacter_Click);
            // 
            // cmbShader
            // 
            this.cmbShader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbShader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShader.BackColor = System.Drawing.Color.White;
            this.cmbShader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShader.Enabled = false;
            this.cmbShader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShader.FormattingEnabled = true;
            this.cmbShader.Location = new System.Drawing.Point(231, 172);
            this.cmbShader.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbShader.Name = "cmbShader";
            this.cmbShader.Size = new System.Drawing.Size(89, 23);
            this.cmbShader.TabIndex = 88;
            this.cmbShader.SelectedIndexChanged += new System.EventHandler(this.cmbShader_SelectedIndexChanged);
            this.cmbShader.MouseHover += new System.EventHandler(this.cmbShader_MouseHover);
            // 
            // labelShader
            // 
            this.labelShader.AutoSize = true;
            this.labelShader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShader.Location = new System.Drawing.Point(186, 176);
            this.labelShader.Name = "labelShader";
            this.labelShader.Size = new System.Drawing.Size(43, 13);
            this.labelShader.TabIndex = 89;
            this.labelShader.Text = "Shader";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.Location = new System.Drawing.Point(337, 89);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(33, 13);
            this.labelTeam.TabIndex = 91;
            this.labelTeam.Text = "Team";
            // 
            // txtTeam
            // 
            this.txtTeam.Enabled = false;
            this.txtTeam.Location = new System.Drawing.Point(376, 86);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(38, 22);
            this.txtTeam.TabIndex = 92;
            this.txtTeam.TextChanged += new System.EventHandler(this.txtTeam_TextChanged);
            this.txtTeam.Leave += new System.EventHandler(this.txtTeam_Leave);
            this.txtTeam.MouseHover += new System.EventHandler(this.txtTeam_MouseHover);
            // 
            // btnSpeedXReset
            // 
            this.btnSpeedXReset.Enabled = false;
            this.btnSpeedXReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedXReset.Location = new System.Drawing.Point(267, 85);
            this.btnSpeedXReset.Name = "btnSpeedXReset";
            this.btnSpeedXReset.Size = new System.Drawing.Size(24, 24);
            this.btnSpeedXReset.TabIndex = 93;
            this.btnSpeedXReset.Text = "Reset";
            this.btnSpeedXReset.UseVisualStyleBackColor = true;
            this.btnSpeedXReset.Click += new System.EventHandler(this.btnSpeedXReset_Click);
            // 
            // btnSpeedYReset
            // 
            this.btnSpeedYReset.Enabled = false;
            this.btnSpeedYReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedYReset.Location = new System.Drawing.Point(267, 116);
            this.btnSpeedYReset.Name = "btnSpeedYReset";
            this.btnSpeedYReset.Size = new System.Drawing.Size(24, 24);
            this.btnSpeedYReset.TabIndex = 94;
            this.btnSpeedYReset.Text = "Reset";
            this.btnSpeedYReset.UseVisualStyleBackColor = true;
            this.btnSpeedYReset.Click += new System.EventHandler(this.btnSpeedYReset_Click);
            // 
            // btnHealthReset
            // 
            this.btnHealthReset.Enabled = false;
            this.btnHealthReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealthReset.Location = new System.Drawing.Point(267, 54);
            this.btnHealthReset.Name = "btnHealthReset";
            this.btnHealthReset.Size = new System.Drawing.Size(24, 24);
            this.btnHealthReset.TabIndex = 95;
            this.btnHealthReset.Text = "Reset";
            this.btnHealthReset.UseVisualStyleBackColor = true;
            this.btnHealthReset.Click += new System.EventHandler(this.btnHealthReset_Click);
            // 
            // txtScale
            // 
            this.txtScale.Enabled = false;
            this.txtScale.Location = new System.Drawing.Point(376, 55);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(38, 22);
            this.txtScale.TabIndex = 96;
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            this.txtScale.MouseHover += new System.EventHandler(this.txtScale_MouseHover);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScale.Location = new System.Drawing.Point(347, 46);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(33, 13);
            this.labelScale.TabIndex = 98;
            this.labelScale.Text = "Scale";
            // 
            // cmbMoveDpad
            // 
            this.cmbMoveDpad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveDpad.Enabled = false;
            this.cmbMoveDpad.FormattingEnabled = true;
            this.cmbMoveDpad.Location = new System.Drawing.Point(340, 361);
            this.cmbMoveDpad.Name = "cmbMoveDpad";
            this.cmbMoveDpad.Size = new System.Drawing.Size(146, 21);
            this.cmbMoveDpad.TabIndex = 95;
            this.cmbMoveDpad.SelectedIndexChanged += new System.EventHandler(this.cmbMoveDpad_SelectedIndexChanged);
            // 
            // cmbMoveButton
            // 
            this.cmbMoveButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveButton.Enabled = false;
            this.cmbMoveButton.FormattingEnabled = true;
            this.cmbMoveButton.Location = new System.Drawing.Point(340, 388);
            this.cmbMoveButton.Name = "cmbMoveButton";
            this.cmbMoveButton.Size = new System.Drawing.Size(146, 21);
            this.cmbMoveButton.TabIndex = 96;
            this.cmbMoveButton.SelectedIndexChanged += new System.EventHandler(this.cmbMoveButton_SelectedIndexChanged);
            // 
            // cmbMoveArmor
            // 
            this.cmbMoveArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveArmor.Enabled = false;
            this.cmbMoveArmor.FormattingEnabled = true;
            this.cmbMoveArmor.Location = new System.Drawing.Point(286, 308);
            this.cmbMoveArmor.Name = "cmbMoveArmor";
            this.cmbMoveArmor.Size = new System.Drawing.Size(200, 21);
            this.cmbMoveArmor.TabIndex = 99;
            this.cmbMoveArmor.Visible = false;
            this.cmbMoveArmor.SelectedIndexChanged += new System.EventHandler(this.cmbMoveArmor_SelectedIndexChanged);
            this.cmbMoveArmor.MouseHover += new System.EventHandler(this.cmbMoveArmor_MouseHover);
            // 
            // txtGreenHP
            // 
            this.txtGreenHP.Enabled = false;
            this.txtGreenHP.Location = new System.Drawing.Point(330, 255);
            this.txtGreenHP.Name = "txtGreenHP";
            this.txtGreenHP.Size = new System.Drawing.Size(68, 22);
            this.txtGreenHP.TabIndex = 100;
            this.txtGreenHP.Visible = false;
            this.txtGreenHP.TextChanged += new System.EventHandler(this.txtGreenHP_TextChanged);
            // 
            // chkAlwaysArmor
            // 
            this.chkAlwaysArmor.AutoSize = true;
            this.chkAlwaysArmor.Enabled = false;
            this.chkAlwaysArmor.Location = new System.Drawing.Point(330, 121);
            this.chkAlwaysArmor.Name = "chkAlwaysArmor";
            this.chkAlwaysArmor.Size = new System.Drawing.Size(91, 17);
            this.chkAlwaysArmor.TabIndex = 101;
            this.chkAlwaysArmor.Text = "Perma Armor";
            this.chkAlwaysArmor.UseVisualStyleBackColor = true;
            this.chkAlwaysArmor.CheckedChanged += new System.EventHandler(this.chkAlwaysArmor_CheckedChanged);
            // 
            // labelGreenHP
            // 
            this.labelGreenHP.AutoSize = true;
            this.labelGreenHP.Location = new System.Drawing.Point(283, 258);
            this.labelGreenHP.Name = "labelGreenHP";
            this.labelGreenHP.Size = new System.Drawing.Size(47, 13);
            this.labelGreenHP.TabIndex = 102;
            this.labelGreenHP.Text = "HP Cost";
            this.labelGreenHP.Visible = false;
            // 
            // labelMovesSeparator
            // 
            this.labelMovesSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMovesSeparator.Location = new System.Drawing.Point(12, 241);
            this.labelMovesSeparator.Name = "labelMovesSeparator";
            this.labelMovesSeparator.Size = new System.Drawing.Size(496, 2);
            this.labelMovesSeparator.TabIndex = 106;
            // 
            // labelMoveArmor
            // 
            this.labelMoveArmor.AutoSize = true;
            this.labelMoveArmor.Location = new System.Drawing.Point(283, 289);
            this.labelMoveArmor.Name = "labelMoveArmor";
            this.labelMoveArmor.Size = new System.Drawing.Size(81, 13);
            this.labelMoveArmor.TabIndex = 107;
            this.labelMoveArmor.Text = "Move Property";
            this.labelMoveArmor.Visible = false;
            // 
            // cmbAI
            // 
            this.cmbAI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAI.Enabled = false;
            this.cmbAI.FormattingEnabled = true;
            this.cmbAI.Location = new System.Drawing.Point(12, 173);
            this.cmbAI.Name = "cmbAI";
            this.cmbAI.Size = new System.Drawing.Size(141, 21);
            this.cmbAI.TabIndex = 108;
            this.cmbAI.SelectedIndexChanged += new System.EventHandler(this.cmbAI_SelectedIndexChanged);
            // 
            // labelAI
            // 
            this.labelAI.AutoSize = true;
            this.labelAI.Location = new System.Drawing.Point(12, 157);
            this.labelAI.Name = "labelAI";
            this.labelAI.Size = new System.Drawing.Size(43, 13);
            this.labelAI.TabIndex = 109;
            this.labelAI.Text = "Base AI";
            // 
            // labelAIPath
            // 
            this.labelAIPath.Location = new System.Drawing.Point(13, 201);
            this.labelAIPath.Name = "labelAIPath";
            this.labelAIPath.Size = new System.Drawing.Size(162, 32);
            this.labelAIPath.TabIndex = 110;
            // 
            // labelMoveInput
            // 
            this.labelMoveInput.AutoSize = true;
            this.labelMoveInput.Location = new System.Drawing.Point(283, 344);
            this.labelMoveInput.Name = "labelMoveInput";
            this.labelMoveInput.Size = new System.Drawing.Size(66, 13);
            this.labelMoveInput.TabIndex = 111;
            this.labelMoveInput.Text = "Move Input";
            this.labelMoveInput.Visible = false;
            // 
            // labelMoveDpad
            // 
            this.labelMoveDpad.AutoSize = true;
            this.labelMoveDpad.Location = new System.Drawing.Point(283, 364);
            this.labelMoveDpad.Name = "labelMoveDpad";
            this.labelMoveDpad.Size = new System.Drawing.Size(54, 13);
            this.labelMoveDpad.TabIndex = 112;
            this.labelMoveDpad.Text = "Direction";
            this.labelMoveDpad.Visible = false;
            // 
            // labelMoveButton
            // 
            this.labelMoveButton.AutoSize = true;
            this.labelMoveButton.Location = new System.Drawing.Point(283, 391);
            this.labelMoveButton.Name = "labelMoveButton";
            this.labelMoveButton.Size = new System.Drawing.Size(43, 13);
            this.labelMoveButton.TabIndex = 113;
            this.labelMoveButton.Text = "Trigger";
            this.labelMoveButton.Visible = false;
            // 
            // btnGreenHPReset
            // 
            this.btnGreenHPReset.Enabled = false;
            this.btnGreenHPReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenHPReset.Location = new System.Drawing.Point(397, 254);
            this.btnGreenHPReset.Name = "btnGreenHPReset";
            this.btnGreenHPReset.Size = new System.Drawing.Size(24, 24);
            this.btnGreenHPReset.TabIndex = 114;
            this.btnGreenHPReset.Text = "Reset";
            this.btnGreenHPReset.UseVisualStyleBackColor = true;
            this.btnGreenHPReset.Visible = false;
            this.btnGreenHPReset.Click += new System.EventHandler(this.btnGreenHPReset_Click);
            // 
            // btnMoveArmorReset
            // 
            this.btnMoveArmorReset.Enabled = false;
            this.btnMoveArmorReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveArmorReset.Location = new System.Drawing.Point(484, 307);
            this.btnMoveArmorReset.Name = "btnMoveArmorReset";
            this.btnMoveArmorReset.Size = new System.Drawing.Size(24, 23);
            this.btnMoveArmorReset.TabIndex = 115;
            this.btnMoveArmorReset.Text = "Reset";
            this.btnMoveArmorReset.UseVisualStyleBackColor = true;
            this.btnMoveArmorReset.Visible = false;
            this.btnMoveArmorReset.Click += new System.EventHandler(this.btnMoveArmorReset_Click);
            // 
            // btnMoveDpadReset
            // 
            this.btnMoveDpadReset.Enabled = false;
            this.btnMoveDpadReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDpadReset.Location = new System.Drawing.Point(484, 360);
            this.btnMoveDpadReset.Name = "btnMoveDpadReset";
            this.btnMoveDpadReset.Size = new System.Drawing.Size(24, 23);
            this.btnMoveDpadReset.TabIndex = 116;
            this.btnMoveDpadReset.Text = "Reset";
            this.btnMoveDpadReset.UseVisualStyleBackColor = true;
            this.btnMoveDpadReset.Visible = false;
            this.btnMoveDpadReset.Click += new System.EventHandler(this.btnMoveDpadReset_Click);
            // 
            // btnMoveButtonReset
            // 
            this.btnMoveButtonReset.Enabled = false;
            this.btnMoveButtonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveButtonReset.Location = new System.Drawing.Point(484, 387);
            this.btnMoveButtonReset.Name = "btnMoveButtonReset";
            this.btnMoveButtonReset.Size = new System.Drawing.Size(24, 23);
            this.btnMoveButtonReset.TabIndex = 117;
            this.btnMoveButtonReset.Text = "Reset";
            this.btnMoveButtonReset.UseVisualStyleBackColor = true;
            this.btnMoveButtonReset.Visible = false;
            this.btnMoveButtonReset.Click += new System.EventHandler(this.btnMoveButtonReset_Click);
            // 
            // labelOrigHealth
            // 
            this.labelOrigHealth.AutoSize = true;
            this.labelOrigHealth.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigHealth.Location = new System.Drawing.Point(290, 60);
            this.labelOrigHealth.Name = "labelOrigHealth";
            this.labelOrigHealth.Size = new System.Drawing.Size(29, 12);
            this.labelOrigHealth.TabIndex = 118;
            this.labelOrigHealth.Text = "label1";
            this.labelOrigHealth.Visible = false;
            // 
            // labelOrigSpeedX
            // 
            this.labelOrigSpeedX.AutoSize = true;
            this.labelOrigSpeedX.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigSpeedX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigSpeedX.Location = new System.Drawing.Point(290, 91);
            this.labelOrigSpeedX.Name = "labelOrigSpeedX";
            this.labelOrigSpeedX.Size = new System.Drawing.Size(29, 12);
            this.labelOrigSpeedX.TabIndex = 119;
            this.labelOrigSpeedX.Text = "label2";
            this.labelOrigSpeedX.Visible = false;
            // 
            // labelOrigSpeedY
            // 
            this.labelOrigSpeedY.AutoSize = true;
            this.labelOrigSpeedY.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigSpeedY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOrigSpeedY.Location = new System.Drawing.Point(290, 122);
            this.labelOrigSpeedY.Name = "labelOrigSpeedY";
            this.labelOrigSpeedY.Size = new System.Drawing.Size(29, 12);
            this.labelOrigSpeedY.TabIndex = 120;
            this.labelOrigSpeedY.Text = "label3";
            this.labelOrigSpeedY.Visible = false;
            // 
            // btnAIReset
            // 
            this.btnAIReset.Enabled = false;
            this.btnAIReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAIReset.Location = new System.Drawing.Point(151, 172);
            this.btnAIReset.Name = "btnAIReset";
            this.btnAIReset.Size = new System.Drawing.Size(24, 25);
            this.btnAIReset.TabIndex = 121;
            this.btnAIReset.Text = "Reset";
            this.btnAIReset.UseVisualStyleBackColor = true;
            this.btnAIReset.Click += new System.EventHandler(this.btnAIReset_Click);
            // 
            // CustomizerCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 501);
            this.Controls.Add(this.labelMoveButton);
            this.Controls.Add(this.labelMoveDpad);
            this.Controls.Add(this.labelMoveInput);
            this.Controls.Add(this.labelAIPath);
            this.Controls.Add(this.labelAI);
            this.Controls.Add(this.cmbAI);
            this.Controls.Add(this.labelMoveArmor);
            this.Controls.Add(this.labelMovesSeparator);
            this.Controls.Add(this.labelGreenHP);
            this.Controls.Add(this.chkAlwaysArmor);
            this.Controls.Add(this.txtGreenHP);
            this.Controls.Add(this.cmbMoveArmor);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.cmbMoveButton);
            this.Controls.Add(this.cmbMoveDpad);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelShader);
            this.Controls.Add(this.cmbShader);
            this.Controls.Add(this.btnResetCharacter);
            this.Controls.Add(this.btnResetMove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMoveList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkDespawn);
            this.Controls.Add(this.chkBoss);
            this.Controls.Add(this.txtSpeedY);
            this.Controls.Add(this.txtSpeedX);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelSpeedY);
            this.Controls.Add(this.labelSpeedX);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.characterList);
            this.Controls.Add(this.picThumbOrig);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.btnSetItem);
            this.Controls.Add(this.labelCharacterList);
            this.Controls.Add(this.btnSpeedXReset);
            this.Controls.Add(this.btnSpeedYReset);
            this.Controls.Add(this.btnHealthReset);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.btnMoveButtonReset);
            this.Controls.Add(this.btnMoveDpadReset);
            this.Controls.Add(this.btnMoveArmorReset);
            this.Controls.Add(this.btnGreenHPReset);
            this.Controls.Add(this.labelOrigSpeedY);
            this.Controls.Add(this.labelOrigSpeedX);
            this.Controls.Add(this.labelOrigHealth);
            this.Controls.Add(this.btnAIReset);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomizerCharacters";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.picThumbOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnShowList;
        public System.Windows.Forms.ComboBox characterList;
        public System.Windows.Forms.PictureBox picThumbOrig;
        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.Button btnSetItem;
        public System.Windows.Forms.Label labelCharacterList;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelHealth;
        public System.Windows.Forms.Label labelSpeedX;
        public System.Windows.Forms.Label labelSpeedY;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtSpeedX;
        private System.Windows.Forms.TextBox txtSpeedY;
        private System.Windows.Forms.CheckBox chkBoss;
        private System.Windows.Forms.CheckBox chkDespawn;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbMoveList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnResetMove;
        private System.Windows.Forms.Button btnResetCharacter;
        public System.Windows.Forms.ComboBox cmbShader;
        public System.Windows.Forms.Label labelShader;
        public System.Windows.Forms.Label labelTeam;
        public System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Button btnSpeedXReset;
        private System.Windows.Forms.Button btnSpeedYReset;
        private System.Windows.Forms.Button btnHealthReset;
        private System.Windows.Forms.TextBox txtScale;
        public System.Windows.Forms.Label labelScale;
        public System.Windows.Forms.ComboBox cmbMoveDpad;
        public System.Windows.Forms.ComboBox cmbMoveButton;
        public System.Windows.Forms.ComboBox cmbMoveArmor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hit_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn damage;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitstop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitstun;
        private System.Windows.Forms.DataGridViewButtonColumn Reset;
        private System.Windows.Forms.TextBox txtGreenHP;
        private System.Windows.Forms.CheckBox chkAlwaysArmor;
        private System.Windows.Forms.Label labelGreenHP;
        private System.Windows.Forms.Label labelMovesSeparator;
        private System.Windows.Forms.Label labelMoveArmor;
        private System.Windows.Forms.Label labelAI;
        public System.Windows.Forms.ComboBox cmbAI;
        private System.Windows.Forms.Label labelAIPath;
        private System.Windows.Forms.Label labelMoveInput;
        private System.Windows.Forms.Label labelMoveDpad;
        private System.Windows.Forms.Label labelMoveButton;
        private System.Windows.Forms.Button btnGreenHPReset;
        private System.Windows.Forms.Button btnMoveArmorReset;
        private System.Windows.Forms.Button btnMoveDpadReset;
        private System.Windows.Forms.Button btnMoveButtonReset;
        private System.Windows.Forms.Label labelOrigHealth;
        private System.Windows.Forms.Label labelOrigSpeedX;
        private System.Windows.Forms.Label labelOrigSpeedY;
        private System.Windows.Forms.Button btnAIReset;
    }
}