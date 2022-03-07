namespace SOR4_Swapper
{
    partial class Randomizer
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
            this.components = new System.ComponentModel.Container();
            this.btnClearSwapList = new System.Windows.Forms.Button();
            this.checkMiniToMini = new System.Windows.Forms.CheckBox();
            this.checkBossToBoss = new System.Windows.Forms.CheckBox();
            this.checkIgnoreMiniboss = new System.Windows.Forms.CheckBox();
            this.checkIgnoreBoss = new System.Windows.Forms.CheckBox();
            this.allowDuplicates = new System.Windows.Forms.CheckBox();
            this.btnRandomizeEverybody = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.toolTipMiniboss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBoss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnemiesOnly = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.toolTipRegularplus = new System.Windows.Forms.ToolTip(this.components);
            this.checkRegplusToRegplus = new System.Windows.Forms.CheckBox();
            this.checkIgnoreRegularplus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTipBossIsolate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMinibossIsolate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRegularplusIsolate = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.btnClearSwapList.TabIndex = 53;
            this.btnClearSwapList.Text = "Clear list";
            this.btnClearSwapList.UseVisualStyleBackColor = true;
            this.btnClearSwapList.Click += new System.EventHandler(this.btnClearSwapList_Click);
            // 
            // checkMiniToMini
            // 
            this.checkMiniToMini.AutoSize = true;
            this.checkMiniToMini.Checked = true;
            this.checkMiniToMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMiniToMini.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniToMini.Location = new System.Drawing.Point(382, 102);
            this.checkMiniToMini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMiniToMini.Name = "checkMiniToMini";
            this.checkMiniToMini.Size = new System.Drawing.Size(15, 14);
            this.checkMiniToMini.TabIndex = 58;
            this.checkMiniToMini.UseVisualStyleBackColor = true;
            // 
            // checkBossToBoss
            // 
            this.checkBossToBoss.AutoSize = true;
            this.checkBossToBoss.Checked = true;
            this.checkBossToBoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBossToBoss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBossToBoss.Location = new System.Drawing.Point(382, 82);
            this.checkBossToBoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBossToBoss.Name = "checkBossToBoss";
            this.checkBossToBoss.Size = new System.Drawing.Size(15, 14);
            this.checkBossToBoss.TabIndex = 57;
            this.checkBossToBoss.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreMiniboss
            // 
            this.checkIgnoreMiniboss.AutoSize = true;
            this.checkIgnoreMiniboss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreMiniboss.Location = new System.Drawing.Point(331, 102);
            this.checkIgnoreMiniboss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreMiniboss.Name = "checkIgnoreMiniboss";
            this.checkIgnoreMiniboss.Size = new System.Drawing.Size(15, 14);
            this.checkIgnoreMiniboss.TabIndex = 56;
            this.checkIgnoreMiniboss.UseVisualStyleBackColor = true;
            this.checkIgnoreMiniboss.CheckedChanged += new System.EventHandler(this.checkIgnoreMiniboss_CheckedChanged);
            // 
            // checkIgnoreBoss
            // 
            this.checkIgnoreBoss.AutoSize = true;
            this.checkIgnoreBoss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreBoss.Location = new System.Drawing.Point(331, 82);
            this.checkIgnoreBoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreBoss.Name = "checkIgnoreBoss";
            this.checkIgnoreBoss.Size = new System.Drawing.Size(15, 14);
            this.checkIgnoreBoss.TabIndex = 55;
            this.checkIgnoreBoss.UseVisualStyleBackColor = true;
            this.checkIgnoreBoss.CheckedChanged += new System.EventHandler(this.checkIgnoreBoss_CheckedChanged);
            // 
            // allowDuplicates
            // 
            this.allowDuplicates.AutoSize = true;
            this.allowDuplicates.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowDuplicates.Location = new System.Drawing.Point(14, 62);
            this.allowDuplicates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allowDuplicates.Name = "allowDuplicates";
            this.allowDuplicates.Size = new System.Drawing.Size(111, 17);
            this.allowDuplicates.TabIndex = 52;
            this.allowDuplicates.Text = "Allow duplicates";
            this.allowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnRandomizeEverybody
            // 
            this.btnRandomizeEverybody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomizeEverybody.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomizeEverybody.Location = new System.Drawing.Point(293, 14);
            this.btnRandomizeEverybody.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandomizeEverybody.Name = "btnRandomizeEverybody";
            this.btnRandomizeEverybody.Size = new System.Drawing.Size(89, 29);
            this.btnRandomizeEverybody.TabIndex = 51;
            this.btnRandomizeEverybody.Text = "Everybody";
            this.btnRandomizeEverybody.UseVisualStyleBackColor = true;
            this.btnRandomizeEverybody.Click += new System.EventHandler(this.btnRandomizeEverybody_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(197, 14);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(89, 29);
            this.btnRandomize.TabIndex = 50;
            this.btnRandomize.Text = "Enemies only";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Randomize Characters";
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
            this.btnShowList.TabIndex = 60;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // checkRegplusToRegplus
            // 
            this.checkRegplusToRegplus.AutoSize = true;
            this.checkRegplusToRegplus.Checked = true;
            this.checkRegplusToRegplus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRegplusToRegplus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegplusToRegplus.Location = new System.Drawing.Point(382, 122);
            this.checkRegplusToRegplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRegplusToRegplus.Name = "checkRegplusToRegplus";
            this.checkRegplusToRegplus.Size = new System.Drawing.Size(15, 14);
            this.checkRegplusToRegplus.TabIndex = 65;
            this.checkRegplusToRegplus.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreRegularplus
            // 
            this.checkIgnoreRegularplus.AutoSize = true;
            this.checkIgnoreRegularplus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreRegularplus.Location = new System.Drawing.Point(331, 122);
            this.checkIgnoreRegularplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreRegularplus.Name = "checkIgnoreRegularplus";
            this.checkIgnoreRegularplus.Size = new System.Drawing.Size(15, 14);
            this.checkIgnoreRegularplus.TabIndex = 64;
            this.checkIgnoreRegularplus.UseVisualStyleBackColor = true;
            this.checkIgnoreRegularplus.CheckedChanged += new System.EventHandler(this.checkIgnoreRegPlus_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "IGNORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "ISOLATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Bosses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Minibosses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Regular+";
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkRegplusToRegplus);
            this.Controls.Add(this.checkIgnoreRegularplus);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.checkMiniToMini);
            this.Controls.Add(this.checkBossToBoss);
            this.Controls.Add(this.checkIgnoreMiniboss);
            this.Controls.Add(this.checkIgnoreBoss);
            this.Controls.Add(this.allowDuplicates);
            this.Controls.Add(this.btnRandomizeEverybody);
            this.Controls.Add(this.btnRandomize);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randomizer";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.CheckBox checkMiniToMini;
        public System.Windows.Forms.CheckBox checkBossToBoss;
        public System.Windows.Forms.CheckBox checkIgnoreMiniboss;
        public System.Windows.Forms.CheckBox checkIgnoreBoss;
        public System.Windows.Forms.CheckBox allowDuplicates;
        public System.Windows.Forms.Button btnRandomizeEverybody;
        public System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.ToolTip toolTipMiniboss;
        private System.Windows.Forms.ToolTip toolTipBoss;
        private System.Windows.Forms.ToolTip toolTipEnemiesOnly;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.ToolTip toolTipRegularplus;
        public System.Windows.Forms.CheckBox checkRegplusToRegplus;
        public System.Windows.Forms.CheckBox checkIgnoreRegularplus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTipBossIsolate;
        private System.Windows.Forms.ToolTip toolTipMinibossIsolate;
        private System.Windows.Forms.ToolTip toolTipRegularplusIsolate;
    }
}