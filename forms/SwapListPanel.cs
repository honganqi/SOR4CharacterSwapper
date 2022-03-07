using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOR4_Swapper
{
    public partial class SwapListPanel : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        public SwapListPanel(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    // 1. get hidden INT value of replaced character
                    int changed = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["hiddenIndex"].Value.ToString());

                    // 2. check if changed character showed in the table really exists in the changeList
                    if (classlib.changeList.ContainsKey(changed))
                    {
                        // 4. remove the character from the table, clear the table, then refresh
                        int[] swapcount = classlib.RemoveFromTable(_mainwindow, "character", changed);
                        labelReplaceCount.Text = swapcount[0].ToString();
                        labelReplaceUniqueCount.Text = swapcount[0].ToString();
                    }
                }
                else
                {
                    _mainwindow.swapper.characterList.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["hiddenIndex"].Value;
                    _mainwindow.swapper.replacementComboBox.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["replaceKey"].Value;
                }
            }
            _mainwindow.ResetForm();
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void txtFilterOrig_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("character", "origName", txtFilterOrig.Text);
        }

        private void txtFilterReplace_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("character", "replaceName", txtFilterReplace.Text);
        }

        private void labelSortListOriginal_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["origName"], System.ComponentModel.ListSortDirection.Ascending);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Bold);
            labelSortListReplacements.Font = new Font(labelSortListReplacements.Font, FontStyle.Regular);
        }

        private void labelSortListReplacements_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["replaceName"], System.ComponentModel.ListSortDirection.Ascending);
            labelSortListReplacements.Font = new Font(labelSortListReplacements.Font, FontStyle.Bold);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Regular);
        }


    }
}
