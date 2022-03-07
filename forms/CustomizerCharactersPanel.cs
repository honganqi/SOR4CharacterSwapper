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
    public partial class CharacterCustomizerPanel : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        public CharacterCustomizerPanel(MainWindow mainwindow)
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
                    if (classlib.characterCustomizationQueue.ContainsKey(customized))
                    {
                        // 3. remove the character from the table, clear the table, then refresh
                        int[] swapcount = classlib.RemoveFromTable(_mainwindow, "customCharacter", customized);
                        labelReplaceCount.Text = swapcount[0].ToString();
                    }
                }
                else
                {
                    _mainwindow.charactercustomizerscreen.characterList.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["origKey"].Value;
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

        private void labelSortListOriginal_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["origName"], ListSortDirection.Ascending);
            labelSortListOriginal.Font = new Font(labelSortListOriginal.Font, FontStyle.Bold);
        }

        private void txtFilterReplace_TextChanged(object sender, EventArgs e)
        {
            classlib.FilterSwapTable("character", "replaceName", txtFilterReplace.Text);
        }
    }
}
