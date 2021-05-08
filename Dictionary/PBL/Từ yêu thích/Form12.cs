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
    public partial class Form12 : Form
    {
        public string ID1 { get; set; }
        public Form12(string m)
        {
            InitializeComponent();
            ID1 = m;
            foreach(User i in BLL_QLUser.Instance.GetListUser(null, null))
            {
                if(i.ID_User == ID1)
                {
                    tbID.Text = ID1;
                    tbName.Text = i.UserName;
                    tbEmail.Text = i.Email;
                    tbPhone.Text = i.Phone_Number;
                    tbAddress.Text = i.Address_User;
                    tbPass.Text = i.User_PW;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User i in BLL_QLUser.Instance.GetListUser(null, null))
            {
                if (i.ID_User == ID1)
                {
                    i.UserName = tbName.Text;
                    i.Email=tbEmail.Text;
                    i.Address_User = tbAddress.Text;
                    i.User_PW = tbPass.Text;
                    BLL_QLUser.Instance.EditUser(i);
                }
            }            
            new Form4(ID1).Show();
            this.Hide();
        }
    }
}
