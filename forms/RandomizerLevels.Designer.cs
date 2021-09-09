namespace SOR4_Replacer
{
    partial class RandomizerLevels
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
            this.allowDuplicates = new System.Windows.Forms.CheckBox();
            this.btnRandSurvival = new System.Windows.Forms.Button();
            this.btnRandPlayables = new System.Windows.Forms.Button();
            this.toolTipMiniboss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBoss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnemiesOnly = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnRandEverything = new System.Windows.Forms.Button();
            this.checkIgnoreBossRush = new System.Windows.Forms.CheckBox();
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
            // btnRandSurvival
            // 
            this.btnRandSurvival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandSurvival.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandSurvival.Location = new System.Drawing.Point(291, 14);
            this.btnRandSurvival.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandSurvival.Name = "btnRandSurvival";
            this.btnRandSurvival.Size = new System.Drawing.Size(89, 29);
            this.btnRandSurvival.TabIndex = 51;
            this.btnRandSurvival.Text = "Survival";
            this.btnRandSurvival.UseVisualStyleBackColor = true;
            this.btnRandSurvival.Click += new System.EventHandler(this.btnRandWeapons_Click);
            // 
            // btnRandPlayables
            // 
            this.btnRandPlayables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandPlayables.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandPlayables.Location = new System.Drawing.Point(195, 14);
            this.btnRandPlayables.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandPlayables.Name = "btnRandPlayables";
            this.btnRandPlayables.Size = new System.Drawing.Size(89, 29);
            this.btnRandPlayables.TabIndex = 50;
            this.btnRandPlayables.Text = "Story Levels";
            this.btnRandPlayables.UseVisualStyleBackColor = true;
            this.btnRandPlayables.Click += new System.EventHandler(this.btnRandPickups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Randomize Levels";
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
            // btnRandEverything
            // 
            this.btnRandEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandEverything.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandEverything.Location = new System.Drawing.Point(387, 14);
            this.btnRandEverything.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandEverything.Name = "btnRandEverything";
            this.btnRandEverything.Size = new System.Drawing.Size(121, 29);
            this.btnRandEverything.TabIndex = 64;
            this.btnRandEverything.Text = "Mix \'em all up!";
            this.btnRandEverything.UseVisualStyleBackColor = true;
            this.btnRandEverything.Click += new System.EventHandler(this.btnRandEverything_Click);
            // 
            // checkIgnoreBossRush
            // 
            this.checkIgnoreBossRush.AutoSize = true;
            this.checkIgnoreBossRush.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreBossRush.Location = new System.Drawing.Point(14, 85);
            this.checkIgnoreBossRush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreBossRush.Name = "checkIgnoreBossRush";
            this.checkIgnoreBossRush.Size = new System.Drawing.Size(233, 17);
            this.checkIgnoreBossRush.TabIndex = 55;
            this.checkIgnoreBossRush.Text = "Do not include Boss Rush in Story Levels";
            this.checkIgnoreBossRush.UseVisualStyleBackColor = true;
            // 
            // RandomizerLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.btnRandEverything);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.checkIgnoreBossRush);
            this.Controls.Add(this.allowDuplicates);
            this.Controls.Add(this.btnRandSurvival);
            this.Controls.Add(this.btnRandPlayables);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomizerLevels";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.CheckBox allowDuplicates;
        public System.Windows.Forms.Button btnRandSurvival;
        public System.Windows.Forms.Button btnRandPlayables;
        private System.Windows.Forms.ToolTip toolTipMiniboss;
        private System.Windows.Forms.ToolTip toolTipBoss;
        private System.Windows.Forms.ToolTip toolTipEnemiesOnly;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnShowList;
        public System.Windows.Forms.Button btnRandEverything;
        public System.Windows.Forms.CheckBox checkIgnoreBossRush;
    }
}