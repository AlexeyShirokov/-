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
        }

        private void comboBoxOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Organizations organizations in Program.ads.Organizations)
            {
                string[] item = { organizations.Id.ToString() + ". " + organizations.Name };
                comboBoxOrg.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxNewss_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Advertisement advertisement = listViewAdvvv.SelectedItems[0].Tag as Advertisement;
            advertisement.IdNewspapers = Convert.ToInt32(comboBoxNewss.SelectedItem.ToString().Split('.')[0]);
            advertisement.IdOrginization = Convert.ToInt32(comboBoxOrg.SelectedItem.ToString().Split('.')[0]);
            advertisement.NamberOfNs = textBoxNamber.Text;
            advertisement.QuantityOfAt = textBoxQvoliti.Text;
            Program.ads.SaveChanges();

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
        }

        void ShowAdvvv()
        {
            listViewAdvvv.Items.Clear();
            foreach (Advertisement advertisement in Program.ads.Advertisement)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                       advertisement.IdNewspapers.ToString(),
                       advertisement.+" "+advertisement.ClientSet.MiddleName+" "advertisement.ClientSet.LastName,
                       advertisement.IdWorker.ToString(),
                       advertisement.WorkerSet.FirstName+" "+product.WorkerSet.MiddleName+" "+product.WorkerSet.LastName,
                       advertisement.IdProduct.ToString(),
                       product.ProductSet.Author+" "+product.ProductSet.Name+" "+product.ProductSet.GameName+" "+ product.ProductSet.NameOfficeSupply,
                       product.ProductSet.Prise.ToString()
                    });
                item.Tag = product;
                listViewChekProduct.Items.Add(item);
            }
        }
    }

}
