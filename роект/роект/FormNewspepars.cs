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
    public partial class FormNewspepars : Form
    {
        public FormNewspepars()
        {
            InitializeComponent();
            ShowNewspepar();
        }
        void ShowNewspepar()
        {
            listViewOrg.Items.Clear();
            foreach (Newspapers newspapers in Program.ads.Newspapers)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      newspapers.Id.ToString(),
                      newspapers.Mail = textBoxEmail.Text,
                      newspapers.Prise = textBoxPrise.Text,
                      newspapers.Name = textBoxName.Text
                    }) ;
                item.Tag = newspapers;
                listViewOrg.Items.Add(item);
            }
            listViewOrg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Newspapers newspapers = new Newspapers();
            newspapers.Mail = textBoxEmail.Text;
            newspapers.Prise = textBoxPrise.Text;
            newspapers.Name = textBoxName.Text;
            Program.ads.Newspapers.Add(newspapers);
            Program.ads.SaveChanges();
            ShowNewspepar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Newspapers newspapers = listViewOrg.SelectedItems[0].Tag as Newspapers;
                newspapers.Mail = textBoxEmail.Text;
                newspapers.Prise = textBoxPrise.Text;
                newspapers.Name = textBoxName.Text;
                Program.ads.SaveChanges();
                ShowNewspepar();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrg.SelectedItems.Count == 1)
                {
                    Newspapers newspapers = listViewOrg.SelectedItems[0].Tag as Newspapers;
                    Program.ads.Newspapers.Remove(newspapers);
                    Program.ads.SaveChanges();

                }
                textBoxEmail.Text = "";
                textBoxName.Text = "";
                textBoxPrise.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowNewspepar();
        }

        private void listViewNewspepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Newspapers newspapers = listViewOrg.SelectedItems[0].Tag as Newspapers;
                newspapers.Mail = textBoxEmail.Text;
                newspapers.Prise = textBoxPrise.Text;
                newspapers.Name = textBoxName.Text;
            }
            else
            {
                textBoxEmail.Text = "";
                textBoxName.Text = "";
                textBoxPrise.Text = "";
            }
        }
    }
}
