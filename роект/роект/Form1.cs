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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenNewspapers_Click(object sender, EventArgs e)
        {
            Form newspepar = new FormNewspepars();
            newspepar.Show();
        }

        private void buttonOpenOrganizations_Click(object sender, EventArgs e)
        {
            Form organization = new FormOrganization();
            organization.Show();
        }

        private void buttonOpenAdvertisement_Click(object sender, EventArgs e)
        {
            Form advertisment = new FormAdvertisment();
            advertisment.Show();
        }
    }
}
