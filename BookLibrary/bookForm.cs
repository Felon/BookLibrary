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
    public partial class bookForm : Form
    {
        public bookForm()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookLibraryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.BookAll". При необходимости она может быть перемещена или удалена.
            this.bookAllTableAdapter.Fill(this.bookLibraryDataSet.BookAll);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.bookLibraryDataSet.book);
            this.genreTableAdapter1.Fill(this.bookLibraryDataSet.genre);

            //oBox1.Items.Add(genreTableAdapter1.Fill(this.bookLibraryDataSet.genre.));

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // this.bookTableAdapter.Insert(authorTextBox.Text, book_nameTextBox.Text,year_publishingTextBox.Text,pagesTextBox.Text,publishing_houseTextBox.Text,city_publishingTextBox.Text, seriesTextBox.Text, Convert.ToInt32( priceTextBox.Text),annotationTextBox.Text, Convert.ToInt32(genre_idTextBox.Text));
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bookAllGridControl_Click(object sender, EventArgs e)
        {

        }

        private void city_publishingTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void seriesTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void annotationTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
