namespace SOR4_Swapper
{
    partial class CustomizerLevels
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
            this.labelOrigToReplace = new System.Windows.Forms.Label();
            this.dgvLevelSettings = new System.Windows.Forms.DataGridView();
            this.stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnableAll = new System.Windows.Forms.Button();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.btnBattleRoyale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelSettings)).BeginInit();
            this.SuspendLayout();
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
            this.labelOrigToReplace.Visible = false;
            // 
            // dgvLevelSettings
            // 
            this.dgvLevelSettings.AllowUserToAddRows = false;
            this.dgvLevelSettings.AllowUserToDeleteRows = false;
            this.dgvLevelSettings.AllowUserToResizeColumns = false;
            this.dgvLevelSettings.AllowUserToResizeRows = false;
            this.dgvLevelSettings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLevelSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLevelSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevelSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stage,
            this.teams,
            this.origKey});
            this.dgvLevelSettings.Location = new System.Drawing.Point(12, 11);
            this.dgvLevelSettings.Name = "dgvLevelSettings";
            this.dgvLevelSettings.RowHeadersVisible = false;
            this.dgvLevelSettings.Size = new System.Drawing.Size(294, 318);
            this.dgvLevelSettings.TabIndex = 62;
            // 
            // stage
            // 
            this.stage.HeaderText = "Stage";
            this.stage.Name = "stage";
            this.stage.ReadOnly = true;
            this.stage.Width = 180;
            // 
            // teams
            // 
            this.teams.HeaderText = "Enable Teams";
            this.teams.Name = "teams";
            this.teams.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teams.Width = 90;
            // 
            // origKey
            // 
            this.origKey.DataPropertyName = "origKey";
            this.origKey.HeaderText = "origKey";
            this.origKey.Name = "origKey";
            this.origKey.ReadOnly = true;
            this.origKey.Visible = false;
            // 
            // btnEnableAll
            // 
            this.btnEnableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEnableAll.Location = new System.Drawing.Point(312, 12);
            this.btnEnableAll.Name = "btnEnableAll";
            this.btnEnableAll.Size = new System.Drawing.Size(104, 25);
            this.btnEnableAll.TabIndex = 63;
            this.btnEnableAll.Text = "Enable For All";
            this.btnEnableAll.UseVisualStyleBackColor = true;
            this.btnEnableAll.Click += new System.EventHandler(this.btnEnableAll_Click);
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableAll.Location = new System.Drawing.Point(312, 49);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(104, 25);
            this.btnDisableAll.TabIndex = 64;
            this.btnDisableAll.Text = "Disable For All";
            this.btnDisableAll.UseVisualStyleBackColor = true;
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_Click);
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDefault.Location = new System.Drawing.Point(312, 86);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(104, 25);
            this.btnResetDefault.TabIndex = 65;
            this.btnResetDefault.Text = "Reset to Default";
            this.btnResetDefault.UseVisualStyleBackColor = true;
            this.btnResetDefault.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // btnBattleRoyale
            // 
            this.btnBattleRoyale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattleRoyale.Location = new System.Drawing.Point(312, 151);
            this.btnBattleRoyale.Name = "btnBattleRoyale";
            this.btnBattleRoyale.Size = new System.Drawing.Size(104, 25);
            this.btnBattleRoyale.TabIndex = 66;
            this.btnBattleRoyale.Text = "Battle Royale";
            this.btnBattleRoyale.UseVisualStyleBackColor = true;
            this.btnBattleRoyale.Click += new System.EventHandler(this.btnBattleRoyale_Click);
            // 
            // CustomizerLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 341);
            this.Controls.Add(this.btnBattleRoyale);
            this.Controls.Add(this.btnResetDefault);
            this.Controls.Add(this.btnDisableAll);
            this.Controls.Add(this.btnEnableAll);
            this.Controls.Add(this.dgvLevelSettings);
            this.Controls.Add(this.labelOrigToReplace);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomizerLevels";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Swapper_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Swapper_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelOrigToReplace;
        public System.Windows.Forms.DataGridView dgvLevelSettings;
        private System.Windows.Forms.Button btnEnableAll;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teams;
        private System.Windows.Forms.DataGridViewTextBoxColumn origKey;
        private System.Windows.Forms.Button btnBattleRoyale;
    }
}