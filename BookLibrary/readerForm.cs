using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class readerForm : Form
    {
        public readerForm()
        {
            InitializeComponent();
        }

        private void readerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookLibraryDataSet);

        }

        private void readerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.reader". При необходимости она может быть перемещена или удалена.
            this.readerTableAdapter.Fill(this.bookLibraryDataSet.reader);

        }
    }
}
