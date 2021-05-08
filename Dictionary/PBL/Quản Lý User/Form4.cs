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
    public partial class Form4 : Form
    {
        public string ID { get; set; }
        public Form4(string m)
        {
            InitializeComponent();
            ID = m;
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

        private void btLS_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            new Form12(ID).Show();
            this.Hide();
        }
    }
}
