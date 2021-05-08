using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btQLTV_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();
        }       

        private void btQLUser_Click(object sender, EventArgs e)
        {
            new Form13().Show();
            this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btLS_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Hide();
        }

        private void btTra_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void btDich_Click(object sender, EventArgs e)
        {
            new Form14().Show();
            this.Hide();
        }

        private void btTu_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }
    }
}
