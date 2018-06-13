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
    public partial class InfoBookForm : Form
    {
        public InfoBookForm()
        {
            InitializeComponent();
        }

        private void InfoBookForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.BookinfoAll". При необходимости она может быть перемещена или удалена.
            this.bookinfoAllTableAdapter.Fill(this.bookLibraryDataSet.BookinfoAll);

        }
    }
}
