using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4_Replacer
{
    public partial class SwapListDestroyablePanel : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        public SwapListDestroyablePanel(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // 1. get hidden INT value of replaced character
                int changed = Int32.Parse(dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString());

                // 2. check if changed character showed in the table really exists in the changeList
                if (classlib.destroyableChangeList.ContainsKey(Library.destroyableDictionary[changed].Path))
                {
                    // 3. remove the character from the changeList
                    classlib.bigfileClass.RemoveSwap("destroyable", changed);
                    //classlib.changeList.Remove(Library.characterDictionary[changed].Path);

                    // 4. remove the character from the table, clear the table, then refresh
                    int[] swapcount = classlib.RemoveFromTable("destroyable", (int)dataGridView2.Rows[e.RowIndex].Cells[7].Value, Library.destroyableDictionary[changed].Path);
                    if (swapcount[0] > 0)
                    {
                        labelReplaceCount.Text = swapcount[0].ToString();
                    }
                    if (swapcount[1] > 0)
                    {
                        labelReplaceUniqueCount.Text = swapcount[0].ToString();
                    }

                    // 5. check if changeList still has any content
                    if (classlib.itemChangeList.Count > 0)
                    {

                    }
                }
            }
            _mainwindow.ResetForm();
        }

        private void dataGridView2_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
        }

        private void dataGridView2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void txtFilterOrig_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("destroyable", "origName", txtFilterOrig.Text);
        }

        private void txtFilterReplace_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("destroyable", "replaceName", txtFilterReplace.Text);
        }

        private void labelSortListOriginal_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns["origName"], System.ComponentModel.ListSortDirection.Ascending);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Bold);
            labelSortListReplacements.Font = new Font(labelSortListReplacements.Font, FontStyle.Regular);
        }

        private void labelSortListReplacements_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns["replaceName"], System.ComponentModel.ListSortDirection.Ascending);
            labelSortListReplacements.Font = new Font(labelSortListReplacements.Font, FontStyle.Bold);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Regular);
        }


    }
}
