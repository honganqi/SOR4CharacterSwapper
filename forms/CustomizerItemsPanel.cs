using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOR4_Swapper
{
    public partial class ItemCustomizerPanel : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        public ItemCustomizerPanel(MainWindow mainwindow)
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
                    int customized = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["origKey"].Value.ToString());

                    // 2. check if changed character showed in the table really exists in the changeList
                    if (classlib.itemCustomizationQueue.ContainsKey(customized))
                    {
                        // 3. remove the character from the table, clear the table, then refresh
                        int[] swapcount = classlib.RemoveFromTable(_mainwindow, "customItem", customized);
                        labelReplaceCount.Text = swapcount[0].ToString();
                    }
                }
                else
                {
                    _mainwindow.itemcustomizerscreen.itemList.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["origKey"].Value;
                }
            }
            _mainwindow.ResetForm();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void txtFilterOrig_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("customItem", "origName", txtFilterOrig.Text);
        }

        private void labelSortListOriginal_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["origName"], ListSortDirection.Ascending);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Bold);
        }

        private void txtFilterReplace_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("customItem", "replaceName", txtFilterReplace.Text);
        }
    }
}
