using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace роект
{
    public partial class FormOrganization : Form
    {
        public FormOrganization()
        {
            InitializeComponent();
            ShowOrganization();
        }

        void ShowOrganization()
        {
            listViewOrg.Items.Clear();
            foreach (Organizations organizations in Program.ads.Organizations)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      organizations.Id.ToString(),
                      organizations.Mail = textBoxEmail.Text,
                      organizations.Address = textBoxAdress.Text,
                      organizations.Name = textBoxName.Text
                    });
                item.Tag = organizations;
                listViewOrg.Items.Add(item);
            }
            listViewOrg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Organizations organizations = listViewOrg.SelectedItems[0].Tag as Organizations;
                organizations.Mail = textBoxEmail.Text;
                organizations.Address = textBoxAdress.Text;
                organizations.Name = textBoxName.Text;
                Program.ads.SaveChanges();
                ShowOrganization();
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrg.SelectedItems.Count == 1)
                {
                    Organizations organizations = listViewOrg.SelectedItems[0].Tag as Organizations;
                    Program.ads.Organizations.Remove(organizations);
                    Program.ads.SaveChanges();

                }
                textBoxEmail.Text = "";
                textBoxName.Text = "";
                textBoxAdress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowOrganization();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Organizations organizations = new Organizations();
            organizations.Mail = textBoxEmail.Text;
            organizations.Address = textBoxAdress.Text;
            organizations.Name = textBoxName.Text;
            Program.ads.Organizations.Add(organizations);
            Program.ads.SaveChanges();
            ShowOrganization();
        }

        private void listViewOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Organizations organizations = listViewOrg.SelectedItems[0].Tag as Organizations;
                
                organizations.Mail = textBoxEmail.Text;
                organizations.Address = textBoxAdress.Text;
                organizations.Name = textBoxName.Text;
            }
            else
            {
                textBoxEmail.Text = "";
                textBoxName.Text = "";
                textBoxAdress.Text = "";
            }
        }
    }
}
