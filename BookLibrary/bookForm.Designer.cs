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
            this.bookAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.genreTableAdapter1 = new BookLibrary.BookLibraryDataSetTableAdapters.genreTableAdapter();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookAllTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.BookAllTableAdapter();
            this.bookAllGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colbook_name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colauthor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcity_publishing = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgenrename = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpages = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colprice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpublishing_house = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colseries = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colyear_publishing = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colannotation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colbook_name = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colauthor = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcity_publishing = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colgenrename = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colpages = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colprice = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn7 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colpublishing_house = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn8 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colseries = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn9 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colyear_publishing = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn10 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colannotation = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.authorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.book_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.year_publishingTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pagesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.publishing_houseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.city_publishingTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.seriesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.annotationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.genrenameTextEdit = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bookAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAllGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colbook_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colauthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity_publishing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgenrename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpublishing_house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colyear_publishing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colannotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_publishingTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishing_houseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.city_publishingTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annotationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genrenameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(16, 50);
            authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(47, 17);
            authorLabel.TabIndex = 3;
            authorLabel.Text = "Автор";
            // 
            // book_nameLabel
            // 
            book_nameLabel.AutoSize = true;
            book_nameLabel.Location = new System.Drawing.Point(16, 82);
            book_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            book_nameLabel.Name = "book_nameLabel";
            book_nameLabel.Size = new System.Drawing.Size(112, 17);
            book_nameLabel.TabIndex = 5;
            book_nameLabel.Text = "Название книги";
            // 
            // year_publishingLabel
            // 
            year_publishingLabel.AutoSize = true;
            year_publishingLabel.Location = new System.Drawing.Point(16, 114);
            year_publishingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            year_publishingLabel.Name = "year_publishingLabel";
            year_publishingLabel.Size = new System.Drawing.Size(91, 17);
            year_publishingLabel.TabIndex = 7;
            year_publishingLabel.Text = "Год издания";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(283, 47);
            pagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(64, 17);
            pagesLabel.TabIndex = 9;
            pagesLabel.Text = "Страниц";
            // 
            // publishing_houseLabel
            // 
            publishing_houseLabel.AutoSize = true;
            publishing_houseLabel.Location = new System.Drawing.Point(283, 79);
            publishing_houseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publishing_houseLabel.Name = "publishing_houseLabel";
            publishing_houseLabel.Size = new System.Drawing.Size(100, 17);
            publishing_houseLabel.TabIndex = 11;
            publishing_houseLabel.Text = "Издательство";
            // 
            // city_publishingLabel
            // 
            city_publishingLabel.AutoSize = true;
            city_publishingLabel.Location = new System.Drawing.Point(283, 114);
            city_publishingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            city_publishingLabel.Name = "city_publishingLabel";
            city_publishingLabel.Size = new System.Drawing.Size(107, 17);
            city_publishingLabel.TabIndex = 13;
            city_publishingLabel.Text = "Город издания";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Location = new System.Drawing.Point(550, 47);
            seriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new System.Drawing.Size(49, 17);
            seriesLabel.TabIndex = 15;
            seriesLabel.Text = "Серия";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(556, 76);
            priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Цена";
            // 
            // annotationLabel
            // 
            annotationLabel.AutoSize = true;
            annotationLabel.Location = new System.Drawing.Point(556, 108);
            annotationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            annotationLabel.Name = "annotationLabel";
            annotationLabel.Size = new System.Drawing.Size(80, 17);
            annotationLabel.TabIndex = 19;
            annotationLabel.Text = "Аннотация";
            // 
            // genre_idLabel
            // 
            genre_idLabel.AutoSize = true;
            genre_idLabel.Location = new System.Drawing.Point(790, 44);
            genre_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genre_idLabel.Name = "genre_idLabel";
            genre_idLabel.Size = new System.Drawing.Size(45, 17);
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
            this.bookBindingNavigator.BindingSource = this.bookAllBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.bookBindingNavigator.Size = new System.Drawing.Size(1102, 27);
            this.bookBindingNavigator.TabIndex = 0;
            this.bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bookAllBindingSource
            // 
            this.bookAllBindingSource.DataMember = "BookAll";
            this.bookAllBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.bookBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click);
            // 
            // genreTableAdapter1
            // 
            this.genreTableAdapter1.ClearBeforeFill = true;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // bookAllTableAdapter
            // 
            this.bookAllTableAdapter.ClearBeforeFill = true;
            // 
            // bookAllGridControl
            // 
            this.bookAllGridControl.DataSource = this.bookAllBindingSource;
            this.bookAllGridControl.Location = new System.Drawing.Point(0, 140);
            this.bookAllGridControl.MainView = this.gridView1;
            this.bookAllGridControl.Name = "bookAllGridControl";
            this.bookAllGridControl.Size = new System.Drawing.Size(1095, 397);
            this.bookAllGridControl.TabIndex = 22;
            this.bookAllGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.bandedGridView1,
            this.layoutView1,
            this.winExplorerView1});
            this.bookAllGridControl.Click += new System.EventHandler(this.bookAllGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8,
            this.bandedGridColumn9,
            this.bandedGridColumn10});
            this.gridView1.GridControl = this.bookAllGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Название книги";
            this.bandedGridColumn1.FieldName = "book_name";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.VisibleIndex = 0;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Автор";
            this.bandedGridColumn2.FieldName = "author";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.VisibleIndex = 1;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Город";
            this.bandedGridColumn3.FieldName = "city_publishing";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.VisibleIndex = 2;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Жанр";
            this.bandedGridColumn4.FieldName = "genrename";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.VisibleIndex = 3;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Страниц";
            this.bandedGridColumn5.FieldName = "pages";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.VisibleIndex = 4;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Цена";
            this.bandedGridColumn6.FieldName = "price";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.VisibleIndex = 5;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "Издательство";
            this.bandedGridColumn7.FieldName = "publishing_house";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            this.bandedGridColumn7.VisibleIndex = 6;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "Серия";
            this.bandedGridColumn8.FieldName = "series";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.Visible = true;
            this.bandedGridColumn8.VisibleIndex = 7;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.Caption = "Год";
            this.bandedGridColumn9.FieldName = "year_publishing";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.Visible = true;
            this.bandedGridColumn9.VisibleIndex = 8;
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.Caption = "Аннотация";
            this.bandedGridColumn10.FieldName = "annotation";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            this.bandedGridColumn10.Visible = true;
            this.bandedGridColumn10.VisibleIndex = 9;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colbook_name,
            this.colauthor,
            this.colcity_publishing,
            this.colgenrename,
            this.colpages,
            this.colprice,
            this.colpublishing_house,
            this.colseries,
            this.colyear_publishing,
            this.colannotation});
            this.bandedGridView1.GridControl = this.bookAllGridControl;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colbook_name);
            this.gridBand1.Columns.Add(this.colauthor);
            this.gridBand1.Columns.Add(this.colcity_publishing);
            this.gridBand1.Columns.Add(this.colgenrename);
            this.gridBand1.Columns.Add(this.colpages);
            this.gridBand1.Columns.Add(this.colprice);
            this.gridBand1.Columns.Add(this.colpublishing_house);
            this.gridBand1.Columns.Add(this.colseries);
            this.gridBand1.Columns.Add(this.colyear_publishing);
            this.gridBand1.Columns.Add(this.colannotation);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 750;
            // 
            // colbook_name
            // 
            this.colbook_name.Caption = "Название книги";
            this.colbook_name.FieldName = "book_name";
            this.colbook_name.Name = "colbook_name";
            this.colbook_name.Visible = true;
            // 
            // colauthor
            // 
            this.colauthor.Caption = "Автор";
            this.colauthor.FieldName = "author";
            this.colauthor.Name = "colauthor";
            this.colauthor.Visible = true;
            // 
            // colcity_publishing
            // 
            this.colcity_publishing.Caption = "Город";
            this.colcity_publishing.FieldName = "city_publishing";
            this.colcity_publishing.Name = "colcity_publishing";
            this.colcity_publishing.Visible = true;
            // 
            // colgenrename
            // 
            this.colgenrename.Caption = "Жанр";
            this.colgenrename.FieldName = "genrename";
            this.colgenrename.Name = "colgenrename";
            this.colgenrename.Visible = true;
            // 
            // colpages
            // 
            this.colpages.Caption = "Страниц";
            this.colpages.FieldName = "pages";
            this.colpages.Name = "colpages";
            this.colpages.Visible = true;
            // 
            // colprice
            // 
            this.colprice.Caption = "Цена";
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            // 
            // colpublishing_house
            // 
            this.colpublishing_house.Caption = "Издательство";
            this.colpublishing_house.FieldName = "publishing_house";
            this.colpublishing_house.Name = "colpublishing_house";
            this.colpublishing_house.Visible = true;
            // 
            // colseries
            // 
            this.colseries.Caption = "Серия";
            this.colseries.FieldName = "series";
            this.colseries.Name = "colseries";
            this.colseries.Visible = true;
            // 
            // colyear_publishing
            // 
            this.colyear_publishing.Caption = "Год";
            this.colyear_publishing.FieldName = "year_publishing";
            this.colyear_publishing.Name = "colyear_publishing";
            this.colyear_publishing.Visible = true;
            // 
            // colannotation
            // 
            this.colannotation.Caption = "Аннотация";
            this.colannotation.FieldName = "annotation";
            this.colannotation.Name = "colannotation";
            this.colannotation.Visible = true;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6,
            this.layoutViewColumn7,
            this.layoutViewColumn8,
            this.layoutViewColumn9,
            this.layoutViewColumn10});
            this.layoutView1.GridControl = this.bookAllGridControl;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Название книги";
            this.layoutViewColumn1.FieldName = "book_name";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colbook_name;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_colbook_name
            // 
            this.layoutViewField_colbook_name.EditorPreferredWidth = 98;
            this.layoutViewField_colbook_name.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colbook_name.Name = "layoutViewField_colbook_name";
            this.layoutViewField_colbook_name.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colbook_name.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Автор";
            this.layoutViewColumn2.FieldName = "author";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colauthor;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewField_colauthor
            // 
            this.layoutViewField_colauthor.EditorPreferredWidth = 98;
            this.layoutViewField_colauthor.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colauthor.Name = "layoutViewField_colauthor";
            this.layoutViewField_colauthor.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colauthor.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Город";
            this.layoutViewColumn3.FieldName = "city_publishing";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_colcity_publishing;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewField_colcity_publishing
            // 
            this.layoutViewField_colcity_publishing.EditorPreferredWidth = 98;
            this.layoutViewField_colcity_publishing.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_colcity_publishing.Name = "layoutViewField_colcity_publishing";
            this.layoutViewField_colcity_publishing.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colcity_publishing.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Жанр";
            this.layoutViewColumn4.FieldName = "genrename";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colgenrename;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewField_colgenrename
            // 
            this.layoutViewField_colgenrename.EditorPreferredWidth = 98;
            this.layoutViewField_colgenrename.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_colgenrename.Name = "layoutViewField_colgenrename";
            this.layoutViewField_colgenrename.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colgenrename.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Страниц";
            this.layoutViewColumn5.FieldName = "pages";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_colpages;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewField_colpages
            // 
            this.layoutViewField_colpages.EditorPreferredWidth = 98;
            this.layoutViewField_colpages.Location = new System.Drawing.Point(0, 104);
            this.layoutViewField_colpages.Name = "layoutViewField_colpages";
            this.layoutViewField_colpages.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colpages.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "Цена";
            this.layoutViewColumn6.FieldName = "price";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_colprice;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            // 
            // layoutViewField_colprice
            // 
            this.layoutViewField_colprice.EditorPreferredWidth = 98;
            this.layoutViewField_colprice.Location = new System.Drawing.Point(0, 130);
            this.layoutViewField_colprice.Name = "layoutViewField_colprice";
            this.layoutViewField_colprice.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colprice.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn7
            // 
            this.layoutViewColumn7.Caption = "Издательство";
            this.layoutViewColumn7.FieldName = "publishing_house";
            this.layoutViewColumn7.LayoutViewField = this.layoutViewField_colpublishing_house;
            this.layoutViewColumn7.Name = "layoutViewColumn7";
            // 
            // layoutViewField_colpublishing_house
            // 
            this.layoutViewField_colpublishing_house.EditorPreferredWidth = 98;
            this.layoutViewField_colpublishing_house.Location = new System.Drawing.Point(0, 156);
            this.layoutViewField_colpublishing_house.Name = "layoutViewField_colpublishing_house";
            this.layoutViewField_colpublishing_house.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colpublishing_house.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn8
            // 
            this.layoutViewColumn8.Caption = "Серия";
            this.layoutViewColumn8.FieldName = "series";
            this.layoutViewColumn8.LayoutViewField = this.layoutViewField_colseries;
            this.layoutViewColumn8.Name = "layoutViewColumn8";
            // 
            // layoutViewField_colseries
            // 
            this.layoutViewField_colseries.EditorPreferredWidth = 98;
            this.layoutViewField_colseries.Location = new System.Drawing.Point(0, 182);
            this.layoutViewField_colseries.Name = "layoutViewField_colseries";
            this.layoutViewField_colseries.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colseries.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn9
            // 
            this.layoutViewColumn9.Caption = "Год";
            this.layoutViewColumn9.FieldName = "year_publishing";
            this.layoutViewColumn9.LayoutViewField = this.layoutViewField_colyear_publishing;
            this.layoutViewColumn9.Name = "layoutViewColumn9";
            // 
            // layoutViewField_colyear_publishing
            // 
            this.layoutViewField_colyear_publishing.EditorPreferredWidth = 98;
            this.layoutViewField_colyear_publishing.Location = new System.Drawing.Point(0, 208);
            this.layoutViewField_colyear_publishing.Name = "layoutViewField_colyear_publishing";
            this.layoutViewField_colyear_publishing.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colyear_publishing.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewColumn10
            // 
            this.layoutViewColumn10.Caption = "Аннотация";
            this.layoutViewColumn10.FieldName = "annotation";
            this.layoutViewColumn10.LayoutViewField = this.layoutViewField_colannotation;
            this.layoutViewColumn10.Name = "layoutViewColumn10";
            // 
            // layoutViewField_colannotation
            // 
            this.layoutViewField_colannotation.EditorPreferredWidth = 98;
            this.layoutViewField_colannotation.Location = new System.Drawing.Point(0, 234);
            this.layoutViewField_colannotation.Name = "layoutViewField_colannotation";
            this.layoutViewField_colannotation.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colannotation.TextSize = new System.Drawing.Size(97, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colbook_name,
            this.layoutViewField_colauthor,
            this.layoutViewField_colcity_publishing,
            this.layoutViewField_colgenrename,
            this.layoutViewField_colpages,
            this.layoutViewField_colprice,
            this.layoutViewField_colpublishing_house,
            this.layoutViewField_colseries,
            this.layoutViewField_colyear_publishing,
            this.layoutViewField_colannotation});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.winExplorerView1.GridControl = this.bookAllGridControl;
            this.winExplorerView1.Name = "winExplorerView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Название книги";
            this.gridColumn1.FieldName = "book_name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Автор";
            this.gridColumn2.FieldName = "author";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Город";
            this.gridColumn3.FieldName = "city_publishing";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Жанр";
            this.gridColumn4.FieldName = "genrename";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Страниц";
            this.gridColumn5.FieldName = "pages";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Цена";
            this.gridColumn6.FieldName = "price";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Издательство";
            this.gridColumn7.FieldName = "publishing_house";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Серия";
            this.gridColumn8.FieldName = "series";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Год";
            this.gridColumn9.FieldName = "year_publishing";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Аннотация";
            this.gridColumn10.FieldName = "annotation";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // authorTextEdit
            // 
            this.authorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "author", true));
            this.authorTextEdit.Location = new System.Drawing.Point(143, 47);
            this.authorTextEdit.Name = "authorTextEdit";
            this.authorTextEdit.Size = new System.Drawing.Size(125, 22);
            this.authorTextEdit.TabIndex = 23;
            // 
            // book_nameTextEdit
            // 
            this.book_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "book_name", true));
            this.book_nameTextEdit.Location = new System.Drawing.Point(143, 79);
            this.book_nameTextEdit.Name = "book_nameTextEdit";
            this.book_nameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.book_nameTextEdit.TabIndex = 25;
            // 
            // year_publishingTextEdit
            // 
            this.year_publishingTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "year_publishing", true));
            this.year_publishingTextEdit.Location = new System.Drawing.Point(143, 111);
            this.year_publishingTextEdit.Name = "year_publishingTextEdit";
            this.year_publishingTextEdit.Size = new System.Drawing.Size(125, 22);
            this.year_publishingTextEdit.TabIndex = 27;
            // 
            // pagesTextEdit
            // 
            this.pagesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "pages", true));
            this.pagesTextEdit.Location = new System.Drawing.Point(410, 44);
            this.pagesTextEdit.Name = "pagesTextEdit";
            this.pagesTextEdit.Size = new System.Drawing.Size(125, 22);
            this.pagesTextEdit.TabIndex = 29;
            // 
            // publishing_houseTextEdit
            // 
            this.publishing_houseTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "publishing_house", true));
            this.publishing_houseTextEdit.Location = new System.Drawing.Point(410, 76);
            this.publishing_houseTextEdit.Name = "publishing_houseTextEdit";
            this.publishing_houseTextEdit.Size = new System.Drawing.Size(125, 22);
            this.publishing_houseTextEdit.TabIndex = 31;
            // 
            // city_publishingTextEdit
            // 
            this.city_publishingTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "city_publishing", true));
            this.city_publishingTextEdit.Location = new System.Drawing.Point(410, 109);
            this.city_publishingTextEdit.Name = "city_publishingTextEdit";
            this.city_publishingTextEdit.Size = new System.Drawing.Size(125, 22);
            this.city_publishingTextEdit.TabIndex = 33;
            this.city_publishingTextEdit.EditValueChanged += new System.EventHandler(this.city_publishingTextEdit_EditValueChanged);
            // 
            // seriesTextEdit
            // 
            this.seriesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "series", true));
            this.seriesTextEdit.Location = new System.Drawing.Point(644, 44);
            this.seriesTextEdit.Name = "seriesTextEdit";
            this.seriesTextEdit.Size = new System.Drawing.Size(125, 22);
            this.seriesTextEdit.TabIndex = 35;
            this.seriesTextEdit.EditValueChanged += new System.EventHandler(this.seriesTextEdit_EditValueChanged);
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(644, 71);
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(125, 22);
            this.priceSpinEdit.TabIndex = 37;
            // 
            // annotationTextEdit
            // 
            this.annotationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "annotation", true));
            this.annotationTextEdit.Location = new System.Drawing.Point(644, 103);
            this.annotationTextEdit.Name = "annotationTextEdit";
            this.annotationTextEdit.Size = new System.Drawing.Size(451, 22);
            this.annotationTextEdit.TabIndex = 39;
            this.annotationTextEdit.EditValueChanged += new System.EventHandler(this.annotationTextEdit_EditValueChanged);
            // 
            // genrenameTextEdit
            // 
            this.genrenameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookAllBindingSource, "genrename", true));
            this.genrenameTextEdit.Location = new System.Drawing.Point(842, 44);
            this.genrenameTextEdit.Name = "genrenameTextEdit";
            this.genrenameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.genrenameTextEdit.TabIndex = 41;
            // 
            // bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 540);
            this.Controls.Add(this.authorTextEdit);
            this.Controls.Add(this.book_nameTextEdit);
            this.Controls.Add(this.year_publishingTextEdit);
            this.Controls.Add(this.pagesTextEdit);
            this.Controls.Add(this.publishing_houseTextEdit);
            this.Controls.Add(this.city_publishingTextEdit);
            this.Controls.Add(this.seriesTextEdit);
            this.Controls.Add(this.priceSpinEdit);
            this.Controls.Add(this.annotationTextEdit);
            this.Controls.Add(this.genrenameTextEdit);
            this.Controls.Add(this.bookAllGridControl);
            this.Controls.Add(authorLabel);
            this.Controls.Add(book_nameLabel);
            this.Controls.Add(year_publishingLabel);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(publishing_houseLabel);
            this.Controls.Add(city_publishingLabel);
            this.Controls.Add(seriesLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(annotationLabel);
            this.Controls.Add(genre_idLabel);
            this.Controls.Add(this.bookBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Книга";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAllGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colbook_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colauthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity_publishing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgenrename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpublishing_house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colseries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colyear_publishing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colannotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_publishingTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishing_houseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.city_publishingTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annotationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genrenameTextEdit.Properties)).EndInit();
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
        private BookLibraryDataSetTableAdapters.genreTableAdapter genreTableAdapter1;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource bookAllBindingSource;
        private BookLibraryDataSetTableAdapters.BookAllTableAdapter bookAllTableAdapter;
        private DevExpress.XtraGrid.GridControl bookAllGridControl;
        private DevExpress.XtraEditors.TextEdit authorTextEdit;
        private DevExpress.XtraEditors.TextEdit book_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit year_publishingTextEdit;
        private DevExpress.XtraEditors.TextEdit pagesTextEdit;
        private DevExpress.XtraEditors.TextEdit publishing_houseTextEdit;
        private DevExpress.XtraEditors.TextEdit city_publishingTextEdit;
        private DevExpress.XtraEditors.TextEdit seriesTextEdit;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private DevExpress.XtraEditors.TextEdit annotationTextEdit;
        private DevExpress.XtraEditors.TextEdit genrenameTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbook_name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colauthor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcity_publishing;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgenrename;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpages;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colprice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpublishing_house;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colseries;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colyear_publishing;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colannotation;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colbook_name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colauthor;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcity_publishing;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colgenrename;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colpages;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colprice;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn7;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colpublishing_house;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn8;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colseries;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn9;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colyear_publishing;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn10;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colannotation;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}

