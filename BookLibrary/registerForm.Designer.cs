namespace BookLibrary
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label reader_idLabel;
            System.Windows.Forms.Label issue_dateLabel;
            System.Windows.Forms.Label plan_return_dateLabel;
            System.Windows.Forms.Label return_dateLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задолжникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиИнфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.registryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registryTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.registryTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.registryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registryDataGridView = new System.Windows.Forms.DataGridView();
            this.book_idTextBox = new System.Windows.Forms.TextBox();
            this.reader_idTextBox = new System.Windows.Forms.TextBox();
            this.issue_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.plan_return_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.return_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.bookTableAdapter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.genreTableAdapter();
            book_idLabel = new System.Windows.Forms.Label();
            reader_idLabel = new System.Windows.Forms.Label();
            issue_dateLabel = new System.Windows.Forms.Label();
            plan_return_dateLabel = new System.Windows.Forms.Label();
            return_dateLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingNavigator)).BeginInit();
            this.registryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задолжникиToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.читателиToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // задолжникиToolStripMenuItem
            // 
            this.задолжникиToolStripMenuItem.Name = "задолжникиToolStripMenuItem";
            this.задолжникиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.задолжникиToolStripMenuItem.Text = "Задолжники";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читателиToolStripMenuItem1,
            this.книгиToolStripMenuItem1,
            this.книгиИнфоToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // читателиToolStripMenuItem1
            // 
            this.читателиToolStripMenuItem1.Name = "читателиToolStripMenuItem1";
            this.читателиToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.читателиToolStripMenuItem1.Text = "Читатели";
            // 
            // книгиToolStripMenuItem1
            // 
            this.книгиToolStripMenuItem1.Name = "книгиToolStripMenuItem1";
            this.книгиToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.книгиToolStripMenuItem1.Text = "Книги";
            // 
            // книгиИнфоToolStripMenuItem
            // 
            this.книгиИнфоToolStripMenuItem.Name = "книгиИнфоToolStripMenuItem";
            this.книгиИнфоToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.книгиИнфоToolStripMenuItem.Text = "Книги инфо.";
            // 
            // bookLibraryDataSet
            // 
            this.bookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.bookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registryBindingSource
            // 
            this.registryBindingSource.DataMember = "registry";
            this.registryBindingSource.DataSource = this.bookLibraryDataSet;
            this.registryBindingSource.CurrentChanged += new System.EventHandler(this.registryBindingSource_CurrentChanged);
            // 
            // registryTableAdapter
            // 
            this.registryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookinfoTableAdapter = null;
            this.tableAdapterManager.bookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.genreTableAdapter = this.genreTableAdapter;
            this.tableAdapterManager.readerTableAdapter = null;
            this.tableAdapterManager.registryTableAdapter = this.registryTableAdapter;
            this.tableAdapterManager.UpdateOrder = BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // registryBindingNavigator
            // 
            this.registryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registryBindingNavigator.BindingSource = this.registryBindingSource;
            this.registryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registryBindingNavigatorSaveItem});
            this.registryBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.registryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registryBindingNavigator.Name = "registryBindingNavigator";
            this.registryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registryBindingNavigator.Size = new System.Drawing.Size(1218, 27);
            this.registryBindingNavigator.TabIndex = 1;
            this.registryBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // registryBindingNavigatorSaveItem
            // 
            this.registryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registryBindingNavigatorSaveItem.Image")));
            this.registryBindingNavigatorSaveItem.Name = "registryBindingNavigatorSaveItem";
            this.registryBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.registryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.registryBindingNavigatorSaveItem.Click += new System.EventHandler(this.registryBindingNavigatorSaveItem_Click);
            // 
            // registryDataGridView
            // 
            this.registryDataGridView.AutoGenerateColumns = false;
            this.registryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.registryDataGridView.DataSource = this.registryBindingSource;
            this.registryDataGridView.Location = new System.Drawing.Point(0, 68);
            this.registryDataGridView.Name = "registryDataGridView";
            this.registryDataGridView.RowTemplate.Height = 24;
            this.registryDataGridView.Size = new System.Drawing.Size(759, 492);
            this.registryDataGridView.TabIndex = 2;
            this.registryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registryDataGridView_CellContentClick);
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.Location = new System.Drawing.Point(776, 68);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(58, 17);
            book_idLabel.TabIndex = 5;
            book_idLabel.Text = "book id:";
            // 
            // book_idTextBox
            // 
            this.book_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registryBindingSource, "book_id", true));
            this.book_idTextBox.Location = new System.Drawing.Point(895, 65);
            this.book_idTextBox.Name = "book_idTextBox";
            this.book_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.book_idTextBox.TabIndex = 6;
            // 
            // reader_idLabel
            // 
            reader_idLabel.AutoSize = true;
            reader_idLabel.Location = new System.Drawing.Point(776, 96);
            reader_idLabel.Name = "reader_idLabel";
            reader_idLabel.Size = new System.Drawing.Size(69, 17);
            reader_idLabel.TabIndex = 7;
            reader_idLabel.Text = "reader id:";
            // 
            // reader_idTextBox
            // 
            this.reader_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registryBindingSource, "reader_id", true));
            this.reader_idTextBox.Location = new System.Drawing.Point(895, 93);
            this.reader_idTextBox.Name = "reader_idTextBox";
            this.reader_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.reader_idTextBox.TabIndex = 8;
            // 
            // issue_dateLabel
            // 
            issue_dateLabel.AutoSize = true;
            issue_dateLabel.Location = new System.Drawing.Point(776, 125);
            issue_dateLabel.Name = "issue_dateLabel";
            issue_dateLabel.Size = new System.Drawing.Size(77, 17);
            issue_dateLabel.TabIndex = 9;
            issue_dateLabel.Text = "issue date:";
            // 
            // issue_dateDateTimePicker
            // 
            this.issue_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registryBindingSource, "issue_date", true));
            this.issue_dateDateTimePicker.Location = new System.Drawing.Point(895, 121);
            this.issue_dateDateTimePicker.Name = "issue_dateDateTimePicker";
            this.issue_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.issue_dateDateTimePicker.TabIndex = 10;
            // 
            // plan_return_dateLabel
            // 
            plan_return_dateLabel.AutoSize = true;
            plan_return_dateLabel.Location = new System.Drawing.Point(776, 153);
            plan_return_dateLabel.Name = "plan_return_dateLabel";
            plan_return_dateLabel.Size = new System.Drawing.Size(113, 17);
            plan_return_dateLabel.TabIndex = 11;
            plan_return_dateLabel.Text = "plan return date:";
            // 
            // plan_return_dateDateTimePicker
            // 
            this.plan_return_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registryBindingSource, "plan_return_date", true));
            this.plan_return_dateDateTimePicker.Location = new System.Drawing.Point(895, 149);
            this.plan_return_dateDateTimePicker.Name = "plan_return_dateDateTimePicker";
            this.plan_return_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.plan_return_dateDateTimePicker.TabIndex = 12;
            // 
            // return_dateLabel
            // 
            return_dateLabel.AutoSize = true;
            return_dateLabel.Location = new System.Drawing.Point(776, 181);
            return_dateLabel.Name = "return_dateLabel";
            return_dateLabel.Size = new System.Drawing.Size(82, 17);
            return_dateLabel.TabIndex = 13;
            return_dateLabel.Text = "return date:";
            // 
            // return_dateDateTimePicker
            // 
            this.return_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registryBindingSource, "return_date", true));
            this.return_dateDateTimePicker.Location = new System.Drawing.Point(895, 177);
            this.return_dateDateTimePicker.Name = "return_dateDateTimePicker";
            this.return_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.return_dateDateTimePicker.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "return_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "return_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "plan_return_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "plan_return_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "issue_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "issue_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "reader_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "reader_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "book_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "book_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 604);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(this.book_idTextBox);
            this.Controls.Add(reader_idLabel);
            this.Controls.Add(this.reader_idTextBox);
            this.Controls.Add(issue_dateLabel);
            this.Controls.Add(this.issue_dateDateTimePicker);
            this.Controls.Add(plan_return_dateLabel);
            this.Controls.Add(this.plan_return_dateDateTimePicker);
            this.Controls.Add(return_dateLabel);
            this.Controls.Add(this.return_dateDateTimePicker);
            this.Controls.Add(this.registryDataGridView);
            this.Controls.Add(this.registryBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "registerForm";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingNavigator)).EndInit();
            this.registryBindingNavigator.ResumeLayout(false);
            this.registryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задолжникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem книгиИнфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private BookLibraryDataSet bookLibraryDataSet;
        private System.Windows.Forms.BindingSource registryBindingSource;
        private BookLibraryDataSetTableAdapters.registryTableAdapter registryTableAdapter;
        private BookLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registryDataGridView;
        private System.Windows.Forms.TextBox book_idTextBox;
        private System.Windows.Forms.TextBox reader_idTextBox;
        private System.Windows.Forms.DateTimePicker issue_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker plan_return_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker return_dateDateTimePicker;
        private BookLibraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BookLibraryDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource genreBindingSource;
    }
}