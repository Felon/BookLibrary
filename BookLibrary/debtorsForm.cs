using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace BookLibrary
{
    public partial class debtorsForm : Form
    {
        public debtorsForm()
        {
            InitializeComponent();
        }

        private void debtorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.debtors". При необходимости она может быть перемещена или удалена.
            this.debtorsTableAdapter.Fill(this.bookLibraryDataSet.debtors);

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
            ShowGridPreview(debtorsGridControl);
        }
    }
}
