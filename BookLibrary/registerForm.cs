using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.RegistriAll". При необходимости она может быть перемещена или удалена.
            this.registriAllTableAdapter.Fill(this.bookLibraryDataSet.RegistriAll);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.bookLibraryDataSet.genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.bookLibraryDataSet.book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.registry". При необходимости она может быть перемещена или удалена.
            this.registryTableAdapter.Fill(this.bookLibraryDataSet.registry);
            //registryBindingSource.Add(this.bookLibraryDataSet.book);


        }

        private void registryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void registriAllGridControl_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void книгиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bookForm bookForm = new bookForm();
            bookForm.Show();
        }

        private void читателиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            readerForm readerForm = new readerForm();
            readerForm.Show();
        }

        private void книгиИнфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBookForm infoBookForm = new InfoBookForm();
            infoBookForm.Show();
        }

        private void задолжникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debtorsForm debtorsForm = new debtorsForm();
            debtorsForm.Show();
        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(registriAllGridControl);
        }
    }
}
