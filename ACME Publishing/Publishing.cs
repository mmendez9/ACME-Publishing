using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Publishing
{
    public partial class Publishing : Form
    {
        public Publishing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'acmePublishingDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.acmePublishingDataSet.Authors);
            // TODO: This line of code loads data into the 'acmePublishingDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.acmePublishingDataSet.Books);
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.acmePublishingDataSet);

        }
    }
}
