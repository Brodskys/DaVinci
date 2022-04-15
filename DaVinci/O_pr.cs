using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaVinci
{
    public partial class O_pr_: Form
    {
        public O_pr_()
        {
            InitializeComponent();
         
        }

        private void O_pr__FormClosing(object sender, FormClosingEventArgs e)
        {
            DaVinci.MainWindow.odin = false;  
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        { 
            base.OnShown(e);
            ActiveControl = null;
        }
    }
}
