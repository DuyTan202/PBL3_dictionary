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
    public partial class Form15 : Form
    {
        public delegate void Mydel(string name);
        public Mydel d { get; set; }
        public string ID_User { get; set; }
        public string chucnang;
        public Form15(string m, string chucnang)
        {
            InitializeComponent();
            this.ID_User = m;
            this.chucnang = chucnang;
            SetGui();
        }
        public void SetGui()
        {
            User s = BLL_QLUser.Instance.GetUsetByID(ID_User);
            if(s != null)
            {
                tbID.Text = ID_User;
                tbName.Text = s.UserName;
                tbAdress.Text = s.Address_User;
                tbEmail.Text = s.Email;
                tbPhone.Text = s.Phone_Number;
                tbPhone.ReadOnly = true;
                tbPass.Text = s.User_PW;
            }
            else
            {
                tbID.Text = this.ID_User;
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {   if(chucnang == "add")
            {
                tbName.Text = "";
                tbAdress.Text = "";
                tbEmail.Text = "";
                tbPhone.Text = "";
                tbPass.Text = "";
            }
            else
            {
                tbName.Text = "";
                tbAdress.Text = "";
                tbEmail.Text = "";
                tbPass.Text = "";
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {

            if ((tbPhone.Text == "") || (tbPass.Text == ""))
            {
                MessageBox.Show("Mời nhập đủ thông tin!!");
            }
            else
            {
                User s = new User()
                {
                    ID_User = tbID.Text,
                    UserName = tbName.Text,
                    Email = tbEmail.Text,
                    Address_User = tbAdress.Text,
                    Phone_Number = tbPhone.Text,
                    User_PW = tbPass.Text
                };
                if(chucnang == "add")
                {
                    if(BLL_QLUser.Instance.GetUsetByID(s.ID_User) == null)
                    {
                        BLL_QLUser.Instance.CheckDB(s);
                        d(null);
                    }
                    else
                    {
                        MessageBox.Show("User mang ID này đã tồn tại!!");
                    }
                }
                else
                {
                    BLL_QLUser.Instance.CheckDB(s);
                    d(null);
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
