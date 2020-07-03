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
    public partial class FormAdvertisment : Form
    {
        public FormAdvertisment()
        {
            InitializeComponent();
            ShoWcomboBoxOrg();
            ShowAdvvv();
        }
        void ShoWcomboBoxOrg()
        { 
        
            foreach (Organizations organizations in Program.ads.Organizations)
            {
                string[] item = { organizations.Id.ToString() + ". " + organizations.Name };
                comboBoxOrg.Items.Add(string.Join(" ", item));
            }
        }

       void ShowcomboBoxNewss()
        {
            /// не может найти newspepars!!!!!
           /* string[] item = { newspapers.Id.ToString()+ ". " + newspapers.Name};
            comboBoxNewss.Items.Add(string.Join(" ", item));*/
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAdvvv.SelectedItems.Count == 1)
                {
                    Advertisement advertisement = listViewAdvvv.SelectedItems[0].Tag as Advertisement;
                    Program.ads.Advertisement.Remove(advertisement);
                    Program.ads.SaveChanges();
                   
                }
                comboBoxNewss.SelectedItem = null;
                comboBoxOrg.SelectedItem = null;
                textBoxNamber.Text = "";
                textBoxQvoliti.Text = "";      
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowAdvvv();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Advertisement advertisement = listViewAdvvv.SelectedItems[0].Tag as Advertisement;
            advertisement.IdNewspapers = Convert.ToInt32(comboBoxNewss.SelectedItem.ToString().Split('.')[0]);
            advertisement.IdOrginization = Convert.ToInt32(comboBoxOrg.SelectedItem.ToString().Split('.')[0]);
            advertisement.NamberOfNs = textBoxNamber.Text;
            advertisement.QuantityOfAt = textBoxQvoliti.Text;
            Program.ads.SaveChanges();
            ShowAdvvv();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Advertisement advertisement = new Advertisement();
            advertisement.IdNewspapers = Convert.ToInt32(comboBoxNewss.SelectedItem.ToString().Split('.')[0]);
            advertisement.IdOrginization = Convert.ToInt32(comboBoxOrg.SelectedItem.ToString().Split('.')[0]);
            advertisement.NamberOfNs = textBoxNamber.Text;
            advertisement.QuantityOfAt = textBoxQvoliti.Text;
            Program.ads.Advertisement.Add(advertisement);
            Program.ads.SaveChanges();
            ShowAdvvv();
        }

        void ShowAdvvv()
        {
            listViewAdvvv.Items.Clear();
            foreach (Advertisement advertisement in Program.ads.Advertisement)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                       advertisement.IdNewspapers.ToString(),
                       advertisement.Newspapers.Name+" "+advertisement.Newspapers.Prise,
                       advertisement.IdOrginization.ToString(),
                       advertisement.Organizations.Name+" "+advertisement.Organizations.Address,
                       textBoxNamber.Text= advertisement.NamberOfNs,
                       textBoxQvoliti.Text= advertisement.QuantityOfAt,
                      
                    }) ;
                item.Tag = advertisement;
                listViewAdvvv.Items.Add(item);
            }
        }
    }

}
