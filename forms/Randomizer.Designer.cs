namespace SOR4_Replacer
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
            this.checkDuplicates = new System.Windows.Forms.CheckBox();
            this.btnRandomizeEverybody = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.toolTipMiniboss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBoss = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnemiesOnly = new System.Windows.Forms.ToolTip(this.components);
            this.ofdLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.labelShowListArrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearSwapList
            // 
            this.btnClearSwapList.Enabled = false;
            this.btnClearSwapList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSwapList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSwapList.Location = new System.Drawing.Point(372, 64);
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
            this.checkMiniToMini.Checked = true;
            this.checkMiniToMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMiniToMini.Enabled = false;
            this.checkMiniToMini.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniToMini.Location = new System.Drawing.Point(140, 108);
            this.checkMiniToMini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMiniToMini.Name = "checkMiniToMini";
            this.checkMiniToMini.Size = new System.Drawing.Size(207, 18);
            this.checkMiniToMini.TabIndex = 58;
            this.checkMiniToMini.Text = "Swap miniboss with miniboss only";
            this.checkMiniToMini.UseVisualStyleBackColor = true;
            // 
            // checkBossToBoss
            // 
            this.checkBossToBoss.Checked = true;
            this.checkBossToBoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBossToBoss.Enabled = false;
            this.checkBossToBoss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBossToBoss.Location = new System.Drawing.Point(140, 89);
            this.checkBossToBoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBossToBoss.Name = "checkBossToBoss";
            this.checkBossToBoss.Size = new System.Drawing.Size(174, 18);
            this.checkBossToBoss.TabIndex = 57;
            this.checkBossToBoss.Text = "Swap boss with boss only";
            this.checkBossToBoss.UseVisualStyleBackColor = true;
            // 
            // checkIgnoreMiniboss
            // 
            this.checkIgnoreMiniboss.Checked = true;
            this.checkIgnoreMiniboss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIgnoreMiniboss.Enabled = false;
            this.checkIgnoreMiniboss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreMiniboss.Location = new System.Drawing.Point(11, 108);
            this.checkIgnoreMiniboss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreMiniboss.Name = "checkIgnoreMiniboss";
            this.checkIgnoreMiniboss.Size = new System.Drawing.Size(123, 18);
            this.checkIgnoreMiniboss.TabIndex = 56;
            this.checkIgnoreMiniboss.Text = "Ignore minibosses";
            this.checkIgnoreMiniboss.UseVisualStyleBackColor = true;
            this.checkIgnoreMiniboss.CheckedChanged += new System.EventHandler(this.checkIgnoreMiniboss_CheckedChanged);
            // 
            // checkIgnoreBoss
            // 
            this.checkIgnoreBoss.Checked = true;
            this.checkIgnoreBoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIgnoreBoss.Enabled = false;
            this.checkIgnoreBoss.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIgnoreBoss.Location = new System.Drawing.Point(11, 89);
            this.checkIgnoreBoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIgnoreBoss.Name = "checkIgnoreBoss";
            this.checkIgnoreBoss.Size = new System.Drawing.Size(123, 18);
            this.checkIgnoreBoss.TabIndex = 55;
            this.checkIgnoreBoss.Text = "Ignore bosses";
            this.checkIgnoreBoss.UseVisualStyleBackColor = true;
            this.checkIgnoreBoss.CheckedChanged += new System.EventHandler(this.checkIgnoreBoss_CheckedChanged);
            // 
            // checkDuplicates
            // 
            this.checkDuplicates.Checked = true;
            this.checkDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDuplicates.Enabled = false;
            this.checkDuplicates.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDuplicates.Location = new System.Drawing.Point(11, 68);
            this.checkDuplicates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkDuplicates.Name = "checkDuplicates";
            this.checkDuplicates.Size = new System.Drawing.Size(226, 18);
            this.checkDuplicates.TabIndex = 52;
            this.checkDuplicates.Text = "Prevent duplicates on randomization";
            this.checkDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnRandomizeEverybody
            // 
            this.btnRandomizeEverybody.Enabled = false;
            this.btnRandomizeEverybody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomizeEverybody.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomizeEverybody.Location = new System.Drawing.Point(209, 13);
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
            this.btnRandomize.Enabled = false;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(113, 13);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(89, 29);
            this.btnRandomize.TabIndex = 50;
            this.btnRandomize.Text = "Enemies only";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // ofdLoadDialog
            // 
            this.ofdLoadDialog.Filter = "SOR4 Swapper Settings|*.swap";
            this.ofdLoadDialog.Title = "Load Settings File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "bigfile";
            this.openFileDialog1.Filter = "SOR4 bigfile|bigfile";
            this.openFileDialog1.Title = "Location of \"bigfile\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Randomize";
            // 
            // btnShowList
            // 
            this.btnShowList.Enabled = false;
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(372, 101);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(76, 25);
            this.btnShowList.TabIndex = 60;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // labelShowListArrow
            // 
            this.labelShowListArrow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowListArrow.Location = new System.Drawing.Point(446, 104);
            this.labelShowListArrow.Name = "labelShowListArrow";
            this.labelShowListArrow.Size = new System.Drawing.Size(25, 25);
            this.labelShowListArrow.TabIndex = 63;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 162);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.labelShowListArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearSwapList);
            this.Controls.Add(this.checkMiniToMini);
            this.Controls.Add(this.checkBossToBoss);
            this.Controls.Add(this.checkIgnoreMiniboss);
            this.Controls.Add(this.checkIgnoreBoss);
            this.Controls.Add(this.checkDuplicates);
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
        public System.Windows.Forms.CheckBox checkDuplicates;
        public System.Windows.Forms.Button btnRandomizeEverybody;
        public System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.ToolTip toolTipMiniboss;
        private System.Windows.Forms.ToolTip toolTipBoss;
        private System.Windows.Forms.ToolTip toolTipEnemiesOnly;
        private System.Windows.Forms.OpenFileDialog ofdLoadDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnShowList;
        public System.Windows.Forms.Label labelShowListArrow;
    }
}