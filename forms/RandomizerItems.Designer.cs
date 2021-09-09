namespace SOR4_Replacer
{
    partial class RandomizerItems
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
            this.checkGoldToGold = new System.Windows.Forms.CheckBox();
            this.checkIgnoreGolden = new System.Windows.Forms.CheckBox();
            this.allowDuplicates = new System.Windows.Forms.CheckBox();
            this.btnRandWeapons = new System.Windows.Forms.Button();
            this.btnRandPickups = new System.Windows.Forms.Button();
            this.toolTipIsolateGolden = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipIgnoreGolden = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPickups = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // checkGoldToGold
            // 
            this.checkGoldToGold.AutoSize = true;
            this.checkGoldToGold.Checked = true;
            this.checkGoldToGold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGoldToGold.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGoldToGold.Location = new System.Drawing.Point(382, 91);
            this.checkGoldToGold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkGoldToGold.Name = "checkGoldToGold";
            this.checkGoldToGold.Size = new System.Drawing.Size(15, 14);
            this.checkGoldToGold.TabIndex = 57;
            this.checkGoldToGold.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreGolden
            // 
            this.checkIgnoreGolden.AutoSize = true;
            this.checkIgnoreGolden.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreGolden.Location = new System.Drawing.Point(331, 91);
            this.checkIgnoreGolden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreGolden.Name = "checkIgnoreGolden";
            this.checkIgnoreGolden.Size = new System.Drawing.Size(15, 14);
            this.checkIgnoreGolden.TabIndex = 55;
            this.checkIgnoreGolden.UseVisualStyleBackColor = true;
            this.checkIgnoreGolden.CheckedChanged += new System.EventHandler(this.checkIgnoreBoss_CheckedChanged);
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
            // btnRandWeapons
            // 
            this.btnRandWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandWeapons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandWeapons.Location = new System.Drawing.Point(254, 14);
            this.btnRandWeapons.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandWeapons.Name = "btnRandWeapons";
            this.btnRandWeapons.Size = new System.Drawing.Size(89, 29);
            this.btnRandWeapons.TabIndex = 51;
            this.btnRandWeapons.Text = "Weapons";
            this.btnRandWeapons.UseVisualStyleBackColor = true;
            this.btnRandWeapons.Click += new System.EventHandler(this.btnRandWeapons_Click);
            // 
            // btnRandPickups
            // 
            this.btnRandPickups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandPickups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandPickups.Location = new System.Drawing.Point(158, 14);
            this.btnRandPickups.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandPickups.Name = "btnRandPickups";
            this.btnRandPickups.Size = new System.Drawing.Size(89, 29);
            this.btnRandPickups.TabIndex = 50;
            this.btnRandPickups.Text = "Pickups";
            this.btnRandPickups.UseVisualStyleBackColor = true;
            this.btnRandPickups.Click += new System.EventHandler(this.btnRandPickups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Randomize Items";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "ISOLATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "IGNORE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Golden Weapons";
            // 
            // RandomizerItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.checkGoldToGold);
            this.Controls.Add(this.checkIgnoreGolden);
            this.Controls.Add(this.allowDuplicates);
            this.Controls.Add(this.btnRandWeapons);
            this.Controls.Add(this.btnRandPickups);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomizerItems";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Randomizer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClearSwapList;
        public System.Windows.Forms.CheckBox checkGoldToGold;
        public System.Windows.Forms.CheckBox checkIgnoreGolden;
        public System.Windows.Forms.CheckBox allowDuplicates;
        public System.Windows.Forms.Button btnRandWeapons;
        public System.Windows.Forms.Button btnRandPickups;
        private System.Windows.Forms.ToolTip toolTipIsolateGolden;
        private System.Windows.Forms.ToolTip toolTipIgnoreGolden;
        private System.Windows.Forms.ToolTip toolTipPickups;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}