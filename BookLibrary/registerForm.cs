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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void registryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookLibraryDataSet);

        }

        private void registerForm_Load(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.bookLibraryDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.bookLibraryDataSet.book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.bookLibraryDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.bookLibraryDataSet.book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.registry". При необходимости она может быть перемещена или удалена.
            this.registryTableAdapter.Fill(this.bookLibraryDataSet.registry);

        }

        private void registryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
