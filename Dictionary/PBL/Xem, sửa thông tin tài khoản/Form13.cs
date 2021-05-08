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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            cbbSort.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            tbSearch.Text = null;
            Show(null);
        }
        public void Show(string name)
        {
            dtgUser.DataSource = BLL_QLUser.Instance.GetListUser(name, cbbSort.SelectedItem.ToString());
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Show(tbSearch.Text);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (User i in BLL_QLUser.Instance.GetListUser(null,null))
            {
                count = Convert.ToInt32(i.ID_User);
            }
            Form15 s = new Form15( (++count).ToString(), "add");
            s.d += new Form15.Mydel(Show);
            s.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dtgUser.SelectedRows.Count == 1)
            {
                string ID = dtgUser.SelectedRows[0].Cells["ID_User"].Value.ToString();                
                Form15 f = new Form15(ID, "edit");
                f.d += new Form15.Mydel(Show);
                f.Show();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < dtgUser.SelectedRows.Count; i++)
            {
                string MS = dtgUser.SelectedRows[i].Cells["ID_User"].Value.ToString();
                BLL_QLUser.Instance.DeleteUser();
            }*/
            if(dtgUser.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection r = dtgUser.SelectedRows;
                if (r.Count == 1)
                {
                    string ID = "";
                    foreach (DataGridViewRow i in r)
                    {
                        ID = i.Cells["ID_User"].Value.ToString();
                    }
                    foreach (User i in BLL_QLUser.Instance.GetListUser(null,null))
                    {
                        if (i.ID_User == ID)
                        {
                            BLL_QLUser.Instance.DeleteUser(i);
                        }
                    }
                }
                Show(null);
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            Show(null);
        }
    }
}
