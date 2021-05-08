using PBL3.BLL;
using PBL3.DTO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*label1.Focus();
            tbUser.Text = "Enter your phone";
            tbUser.ForeColor = Color.LightGray;*/
        }

        private void btDN_Click(object sender, EventArgs e)
        { 
          
            foreach (Admin i in BLL_QLUser.Instance.GetListAdmin())
            {
                if (tbUser.Text == i.Phone_Number && tbPass.Text == i.Admin_PW)
                {
                    new Form5().Show();
                    this.Hide();
                    break;
                }
            }
            foreach (User j in BLL_QLUser.Instance.GetListUser(null,null))
            {                
                if (tbUser.Text == j.Phone_Number && tbPass.Text == j.User_PW)
                {
                    new Form4(j.ID_User).Show();
                    this.Hide();
                }
            }            
            tbPass.Text = "";
            tbUser.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            tbUser.GotFocus += new EventHandler(this.tbFocus);
            tbUser.LostFocus += new EventHandler(this.tbLozt);
        }
        public void tbFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter your phone")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        public void tbLozt(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Enter your phone";
                tb.ForeColor = Color.LightGray;
            }
        }*/
    }
}
