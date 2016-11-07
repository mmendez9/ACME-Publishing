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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.acmePublishingDataSet);

        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'acmePublishingDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.acmePublishingDataSet.Books);

        }
    }
}
