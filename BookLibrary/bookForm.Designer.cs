namespace BookLibrary
{
    partial class bookForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label book_nameLabel;
            System.Windows.Forms.Label year_publishingLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label publishing_houseLabel;
            System.Windows.Forms.Label city_publishingLabel;
            System.Windows.Forms.Label seriesLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label annotationLabel;
            System.Windows.Forms.Label genre_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookForm));
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.bookTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.book_nameTextBox = new System.Windows.Forms.TextBox();
            this.year_publishingTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.publishing_houseTextBox = new System.Windows.Forms.TextBox();
            this.city_publishingTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.annotationTextBox = new System.Windows.Forms.TextBox();
            this.genre_idTextBox = new System.Windows.Forms.TextBox();
            this.genreTableAdapter1 = new BookLibrary.BookLibraryDataSetTableAdapters.genreTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            authorLabel = new System.Windows.Forms.Label();
            book_nameLabel = new System.Windows.Forms.Label();
            year_publishingLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            publishing_houseLabel = new System.Windows.Forms.Label();
            city_publishingLabel = new System.Windows.Forms.Label();
            seriesLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            annotationLabel = new System.Windows.Forms.Label();
            genre_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
            this.bookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(12, 41);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(37, 13);
            authorLabel.TabIndex = 3;
            authorLabel.Text = "Автор";
            // 
            // book_nameLabel
            // 
            book_nameLabel.AutoSize = true;
            book_nameLabel.Location = new System.Drawing.Point(12, 67);
            book_nameLabel.Name = "book_nameLabel";
            book_nameLabel.Size = new System.Drawing.Size(89, 13);
            book_nameLabel.TabIndex = 5;
            book_nameLabel.Text = "Название книги";
            // 
            // year_publishingLabel
            // 
            year_publishingLabel.AutoSize = true;
            year_publishingLabel.Location = new System.Drawing.Point(12, 93);
            year_publishingLabel.Name = "year_publishingLabel";
            year_publishingLabel.Size = new System.Drawing.Size(70, 13);
            year_publishingLabel.TabIndex = 7;
            year_publishingLabel.Text = "Год издания";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(12, 119);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(49, 13);
            pagesLabel.TabIndex = 9;
            pagesLabel.Text = "Страниц";
            // 
            // publishing_houseLabel
            // 
            publishing_houseLabel.AutoSize = true;
            publishing_houseLabel.Location = new System.Drawing.Point(12, 145);
            publishing_houseLabel.Name = "publishing_houseLabel";
            publishing_houseLabel.Size = new System.Drawing.Size(79, 13);
            publishing_houseLabel.TabIndex = 11;
            publishing_houseLabel.Text = "Издательство";
            // 
            // city_publishingLabel
            // 
            city_publishingLabel.AutoSize = true;
            city_publishingLabel.Location = new System.Drawing.Point(12, 171);
            city_publishingLabel.Name = "city_publishingLabel";
            city_publishingLabel.Size = new System.Drawing.Size(82, 13);
            city_publishingLabel.TabIndex = 13;
            city_publishingLabel.Text = "Город издания";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(12, 197);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(38, 13);
            seriesLabel.TabIndex = 15;
            seriesLabel.Text = "Серия";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 223);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Цена";
            // 
            // annotationLabel
            // 
            annotationLabel.AutoSize = true;
            annotationLabel.Location = new System.Drawing.Point(12, 249);
            annotationLabel.Name = "annotationLabel";
            annotationLabel.Size = new System.Drawing.Size(61, 13);
            annotationLabel.TabIndex = 19;
            annotationLabel.Text = "Аннотация";
            // 
            // genre_idLabel
            // 
            genre_idLabel.AutoSize = true;
            genre_idLabel.Location = new System.Drawing.Point(12, 275);
            genre_idLabel.Name = "genre_idLabel";
            genre_idLabel.Size = new System.Drawing.Size(36, 13);
            genre_idLabel.TabIndex = 21;
            genre_idLabel.Text = "Жанр";
            // 
            // bookLibraryDataSet
            // 
            this.bookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.bookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookinfoTableAdapter = null;
            this.tableAdapterManager.bookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.readerTableAdapter = null;
            this.tableAdapterManager.registryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // bookBindingNavigator
            // 
            this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookBindingNavigator.BindingSource = this.bookBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookBindingNavigatorSaveItem});
            this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookBindingNavigator.Name = "bookBindingNavigator";
            this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.bookBindingNavigator.TabIndex = 0;
            this.bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "author", true));
            this.authorTextBox.Location = new System.Drawing.Point(107, 38);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 4;
            // 
            // book_nameTextBox
            // 
            this.book_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "book_name", true));
            this.book_nameTextBox.Location = new System.Drawing.Point(107, 64);
            this.book_nameTextBox.Name = "book_nameTextBox";
            this.book_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.book_nameTextBox.TabIndex = 6;
            // 
            // year_publishingTextBox
            // 
            this.year_publishingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "year_publishing", true));
            this.year_publishingTextBox.Location = new System.Drawing.Point(107, 90);
            this.year_publishingTextBox.Name = "year_publishingTextBox";
            this.year_publishingTextBox.Size = new System.Drawing.Size(100, 20);
            this.year_publishingTextBox.TabIndex = 8;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(107, 116);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagesTextBox.TabIndex = 10;
            // 
            // publishing_houseTextBox
            // 
            this.publishing_houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "publishing_house", true));
            this.publishing_houseTextBox.Location = new System.Drawing.Point(107, 142);
            this.publishing_houseTextBox.Name = "publishing_houseTextBox";
            this.publishing_houseTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishing_houseTextBox.TabIndex = 12;
            // 
            // city_publishingTextBox
            // 
            this.city_publishingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "city_publishing", true));
            this.city_publishingTextBox.Location = new System.Drawing.Point(107, 168);
            this.city_publishingTextBox.Name = "city_publishingTextBox";
            this.city_publishingTextBox.Size = new System.Drawing.Size(100, 20);
            this.city_publishingTextBox.TabIndex = 14;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "series", true));
            this.seriesTextBox.Location = new System.Drawing.Point(107, 194);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.seriesTextBox.TabIndex = 16;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(107, 220);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 18;
            // 
            // annotationTextBox
            // 
            this.annotationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "annotation", true));
            this.annotationTextBox.Location = new System.Drawing.Point(107, 246);
            this.annotationTextBox.Name = "annotationTextBox";
            this.annotationTextBox.Size = new System.Drawing.Size(100, 20);
            this.annotationTextBox.TabIndex = 20;
            // 
            // genre_idTextBox
            // 
            this.genre_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "genre_id", true));
            this.genre_idTextBox.Location = new System.Drawing.Point(107, 272);
            this.genre_idTextBox.Name = "genre_idTextBox";
            this.genre_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.genre_idTextBox.TabIndex = 22;
            // 
            // genreTableAdapter1
            // 
            this.genreTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AutoGenerateColumns = false;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.genreDataGridView.DataSource = this.genreBindingSource;
            this.genreDataGridView.Location = new System.Drawing.Point(280, 38);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.Size = new System.Drawing.Size(300, 220);
            this.genreDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "genrename";
            this.dataGridViewTextBoxColumn2.HeaderText = "genrename";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 554);
            this.Controls.Add(this.genreDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(book_nameLabel);
            this.Controls.Add(this.book_nameTextBox);
            this.Controls.Add(year_publishingLabel);
            this.Controls.Add(this.year_publishingTextBox);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(publishing_houseLabel);
            this.Controls.Add(this.publishing_houseTextBox);
            this.Controls.Add(city_publishingLabel);
            this.Controls.Add(this.city_publishingTextBox);
            this.Controls.Add(seriesLabel);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(annotationLabel);
            this.Controls.Add(this.annotationTextBox);
            this.Controls.Add(genre_idLabel);
            this.Controls.Add(this.genre_idTextBox);
            this.Controls.Add(this.bookBindingNavigator);
            this.Name = "bookForm";
            this.Text = "Книга";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookLibraryDataSet bookLibraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookLibraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private BookLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox book_nameTextBox;
        private System.Windows.Forms.TextBox year_publishingTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox publishing_houseTextBox;
        private System.Windows.Forms.TextBox city_publishingTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox annotationTextBox;
        private System.Windows.Forms.TextBox genre_idTextBox;
        private BookLibraryDataSetTableAdapters.genreTableAdapter genreTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

