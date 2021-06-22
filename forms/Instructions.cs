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
    public partial class Instructions : Form
    {
        private MainWindow _mainwindow;
        public Instructions(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void btnInstructionsClose_Click(object sender, EventArgs e)
        {
            _mainwindow.btnInstructionsClose();
        }
    }
}
