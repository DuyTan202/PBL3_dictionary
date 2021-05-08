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
    
        public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();
            tbUserName.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btCLR_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbPass.Text = "";
            tbPass1.Text = "";
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                tbPass.PasswordChar = '\0';
                tbPass1.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
                tbPass1.PasswordChar = '*';
            }
        }
        
        private void btDK_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "" || tbPass.Text == ""||tbPass1.Text == "" || tbPass.Text != tbPass1.Text)
            {
                MessageBox.Show("Nhap lai");
            }
            else
            {
                int count = 0;
                foreach(User i in BLL_QLUser.Instance.GetListUser(null,null))
                {
                    count = Convert.ToInt32(i.ID_User);
                }
                User s = new User();                
                s.ID_User = (++count).ToString();
                s.UserName = "";
                s.Email = "";
                s.Phone_Number = tbUserName.Text.ToString();
                s.Address_User = "";
                s.User_PW = tbPass.Text;
                BLL_QLUser.Instance.AddUser(s);                
                new Form4(s.ID_User).Show();
                this.Hide();
            }
        }
    }
}
