using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fWin : Form
    {   
        public fWin()
        {
            InitializeComponent();
        }

        private void btnNice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
