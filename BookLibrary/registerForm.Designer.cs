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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задолжникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиИнфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.registryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registryTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.registryTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.bookTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.bookTableAdapter();
            this.genreTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.genreTableAdapter();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registriAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registriAllTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.RegistriAllTableAdapter();
            this.registriAllGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbook_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenrename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colissue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_return_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreturn_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.registriAllBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.registriAllBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.repositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllBindingNavigator)).BeginInit();
            this.registriAllBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задолжникиToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.читателиToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // задолжникиToolStripMenuItem
            // 
            this.задолжникиToolStripMenuItem.Name = "задолжникиToolStripMenuItem";
            this.задолжникиToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.задолжникиToolStripMenuItem.Text = "Задолжники";
            this.задолжникиToolStripMenuItem.Click += new System.EventHandler(this.задолжникиToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читателиToolStripMenuItem1,
            this.книгиToolStripMenuItem1,
            this.книгиИнфоToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // читателиToolStripMenuItem1
            // 
            this.читателиToolStripMenuItem1.Name = "читателиToolStripMenuItem1";
            this.читателиToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.читателиToolStripMenuItem1.Text = "Читатели";
            this.читателиToolStripMenuItem1.Click += new System.EventHandler(this.читателиToolStripMenuItem1_Click);
            // 
            // книгиToolStripMenuItem1
            // 
            this.книгиToolStripMenuItem1.Name = "книгиToolStripMenuItem1";
            this.книгиToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.книгиToolStripMenuItem1.Text = "Книги";
            this.книгиToolStripMenuItem1.Click += new System.EventHandler(this.книгиToolStripMenuItem1_Click);
            // 
            // книгиИнфоToolStripMenuItem
            // 
            this.книгиИнфоToolStripMenuItem.Name = "книгиИнфоToolStripMenuItem";
            this.книгиИнфоToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.книгиИнфоToolStripMenuItem.Text = "Книги инфо.";
            this.книгиИнфоToolStripMenuItem.Click += new System.EventHandler(this.книгиИнфоToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
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
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // registriAllBindingSource
            // 
            this.registriAllBindingSource.DataMember = "RegistriAll";
            this.registriAllBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // registriAllTableAdapter
            // 
            this.registriAllTableAdapter.ClearBeforeFill = true;
            // 
            // registriAllGridControl
            // 
            this.registriAllGridControl.DataSource = this.registriAllBindingSource;
            this.registriAllGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.registriAllGridControl.Location = new System.Drawing.Point(0, 47);
            this.registriAllGridControl.MainView = this.gridView1;
            this.registriAllGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.registriAllGridControl.Name = "registriAllGridControl";
            this.registriAllGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemResourcesComboBox1});
            this.registriAllGridControl.Size = new System.Drawing.Size(1426, 366);
            this.registriAllGridControl.TabIndex = 1;
            this.registriAllGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.registriAllGridControl.Click += new System.EventHandler(this.registriAllGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbook_name,
            this.colauthor,
            this.colprice,
            this.colgenrename,
            this.colfirst_name,
            this.collast_name,
            this.colcode,
            this.colissue_date,
            this.colplan_return_date,
            this.colreturn_date});
            this.gridView1.GridControl = this.registriAllGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colbook_name
            // 
            this.colbook_name.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colbook_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colbook_name.AppearanceCell.BorderColor = System.Drawing.Color.White;
            this.colbook_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colbook_name.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colbook_name.AppearanceCell.Options.UseBackColor = true;
            this.colbook_name.AppearanceCell.Options.UseBorderColor = true;
            this.colbook_name.AppearanceCell.Options.UseFont = true;
            this.colbook_name.AppearanceCell.Options.UseForeColor = true;
            this.colbook_name.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colbook_name.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colbook_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colbook_name.AppearanceHeader.Options.UseBackColor = true;
            this.colbook_name.AppearanceHeader.Options.UseFont = true;
            this.colbook_name.Caption = "Название книги";
            this.colbook_name.FieldName = "book_name";
            this.colbook_name.MinWidth = 30;
            this.colbook_name.Name = "colbook_name";
            this.colbook_name.Visible = true;
            this.colbook_name.VisibleIndex = 0;
            this.colbook_name.Width = 200;
            // 
            // colauthor
            // 
            this.colauthor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colauthor.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colauthor.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colauthor.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colauthor.AppearanceCell.Options.UseBackColor = true;
            this.colauthor.AppearanceCell.Options.UseFont = true;
            this.colauthor.AppearanceCell.Options.UseForeColor = true;
            this.colauthor.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colauthor.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colauthor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colauthor.AppearanceHeader.Options.UseBackColor = true;
            this.colauthor.AppearanceHeader.Options.UseFont = true;
            this.colauthor.Caption = "Автор";
            this.colauthor.ColumnEdit = this.repositoryItemResourcesComboBox1;
            this.colauthor.FieldName = "author";
            this.colauthor.MinWidth = 30;
            this.colauthor.Name = "colauthor";
            this.colauthor.Visible = true;
            this.colauthor.VisibleIndex = 1;
            this.colauthor.Width = 200;
            // 
            // colprice
            // 
            this.colprice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colprice.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colprice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colprice.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colprice.AppearanceCell.Options.UseBackColor = true;
            this.colprice.AppearanceCell.Options.UseFont = true;
            this.colprice.AppearanceCell.Options.UseForeColor = true;
            this.colprice.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colprice.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colprice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colprice.AppearanceHeader.Options.UseBackColor = true;
            this.colprice.AppearanceHeader.Options.UseFont = true;
            this.colprice.Caption = "Цена";
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 30;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 100;
            // 
            // colgenrename
            // 
            this.colgenrename.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colgenrename.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colgenrename.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colgenrename.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colgenrename.AppearanceCell.Options.UseBackColor = true;
            this.colgenrename.AppearanceCell.Options.UseFont = true;
            this.colgenrename.AppearanceCell.Options.UseForeColor = true;
            this.colgenrename.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colgenrename.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colgenrename.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colgenrename.AppearanceHeader.Options.UseBackColor = true;
            this.colgenrename.AppearanceHeader.Options.UseFont = true;
            this.colgenrename.Caption = "Жанр";
            this.colgenrename.FieldName = "genrename";
            this.colgenrename.MinWidth = 30;
            this.colgenrename.Name = "colgenrename";
            this.colgenrename.Visible = true;
            this.colgenrename.VisibleIndex = 3;
            this.colgenrename.Width = 200;
            // 
            // colfirst_name
            // 
            this.colfirst_name.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colfirst_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colfirst_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colfirst_name.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colfirst_name.AppearanceCell.Options.UseBackColor = true;
            this.colfirst_name.AppearanceCell.Options.UseFont = true;
            this.colfirst_name.AppearanceCell.Options.UseForeColor = true;
            this.colfirst_name.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colfirst_name.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colfirst_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colfirst_name.AppearanceHeader.Options.UseBackColor = true;
            this.colfirst_name.AppearanceHeader.Options.UseFont = true;
            this.colfirst_name.Caption = "Имя читателя";
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.MinWidth = 30;
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 4;
            this.colfirst_name.Width = 200;
            // 
            // collast_name
            // 
            this.collast_name.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.collast_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.collast_name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collast_name.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.collast_name.AppearanceCell.Options.UseBackColor = true;
            this.collast_name.AppearanceCell.Options.UseFont = true;
            this.collast_name.AppearanceCell.Options.UseForeColor = true;
            this.collast_name.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.collast_name.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.collast_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collast_name.AppearanceHeader.Options.UseBackColor = true;
            this.collast_name.AppearanceHeader.Options.UseFont = true;
            this.collast_name.Caption = "Фамилия читателя";
            this.collast_name.FieldName = "last_name";
            this.collast_name.MinWidth = 30;
            this.collast_name.Name = "collast_name";
            this.collast_name.Visible = true;
            this.collast_name.VisibleIndex = 5;
            this.collast_name.Width = 200;
            // 
            // colcode
            // 
            this.colcode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colcode.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colcode.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colcode.AppearanceCell.Options.UseBackColor = true;
            this.colcode.AppearanceCell.Options.UseFont = true;
            this.colcode.AppearanceCell.Options.UseForeColor = true;
            this.colcode.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colcode.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colcode.AppearanceHeader.Options.UseBackColor = true;
            this.colcode.AppearanceHeader.Options.UseFont = true;
            this.colcode.Caption = "Код читателя";
            this.colcode.FieldName = "code";
            this.colcode.MinWidth = 30;
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 6;
            this.colcode.Width = 130;
            // 
            // colissue_date
            // 
            this.colissue_date.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colissue_date.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colissue_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colissue_date.AppearanceCell.Options.UseBackColor = true;
            this.colissue_date.AppearanceCell.Options.UseFont = true;
            this.colissue_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colissue_date.AppearanceHeader.Options.UseFont = true;
            this.colissue_date.Caption = "Дата выдачи";
            this.colissue_date.FieldName = "issue_date";
            this.colissue_date.Name = "colissue_date";
            this.colissue_date.Visible = true;
            this.colissue_date.VisibleIndex = 7;
            this.colissue_date.Width = 150;
            // 
            // colplan_return_date
            // 
            this.colplan_return_date.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colplan_return_date.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colplan_return_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colplan_return_date.AppearanceCell.Options.UseBackColor = true;
            this.colplan_return_date.AppearanceCell.Options.UseFont = true;
            this.colplan_return_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colplan_return_date.AppearanceHeader.Options.UseFont = true;
            this.colplan_return_date.Caption = "Дата возврата Пл.";
            this.colplan_return_date.FieldName = "plan_return_date";
            this.colplan_return_date.Name = "colplan_return_date";
            this.colplan_return_date.Visible = true;
            this.colplan_return_date.VisibleIndex = 8;
            this.colplan_return_date.Width = 160;
            // 
            // colreturn_date
            // 
            this.colreturn_date.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.colreturn_date.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colreturn_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colreturn_date.AppearanceCell.Options.UseBackColor = true;
            this.colreturn_date.AppearanceCell.Options.UseFont = true;
            this.colreturn_date.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colreturn_date.AppearanceHeader.Options.UseFont = true;
            this.colreturn_date.Caption = "Дата возврата";
            this.colreturn_date.FieldName = "return_date";
            this.colreturn_date.Name = "colreturn_date";
            this.colreturn_date.Visible = true;
            this.colreturn_date.VisibleIndex = 9;
            this.colreturn_date.Width = 120;
            // 
            // registriAllBindingNavigator
            // 
            this.registriAllBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registriAllBindingNavigator.BindingSource = this.registriAllBindingSource;
            this.registriAllBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registriAllBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registriAllBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registriAllBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registriAllBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.registriAllBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.registriAllBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registriAllBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registriAllBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registriAllBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registriAllBindingNavigator.Name = "registriAllBindingNavigator";
            this.registriAllBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registriAllBindingNavigator.Size = new System.Drawing.Size(1426, 27);
            this.registriAllBindingNavigator.TabIndex = 3;
            this.registriAllBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            // registriAllBindingNavigatorSaveItem
            // 
            this.registriAllBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registriAllBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registriAllBindingNavigatorSaveItem.Image")));
            this.registriAllBindingNavigatorSaveItem.Name = "registriAllBindingNavigatorSaveItem";
            this.registriAllBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.registriAllBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.registriAllGridControl;
            this.searchControl1.Location = new System.Drawing.Point(309, 27);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.registriAllGridControl;
            this.searchControl1.Size = new System.Drawing.Size(214, 20);
            this.searchControl1.TabIndex = 5;
            // 
            // repositoryItemResourcesComboBox1
            // 
            this.repositoryItemResourcesComboBox1.AutoHeight = false;
            this.repositoryItemResourcesComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox1.Name = "repositoryItemResourcesComboBox1";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.GridControl = this.registriAllGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1426, 418);
            this.ControlBox = false;
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.registriAllBindingNavigator);
            this.Controls.Add(this.registriAllGridControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registriAllBindingNavigator)).EndInit();
            this.registriAllBindingNavigator.ResumeLayout(false);
            this.registriAllBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private BookLibraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private BookLibraryDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource registriAllBindingSource;
        private BookLibraryDataSetTableAdapters.RegistriAllTableAdapter registriAllTableAdapter;
        private DevExpress.XtraGrid.GridControl registriAllGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colbook_name;
        private DevExpress.XtraGrid.Columns.GridColumn colauthor;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colgenrename;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private System.Windows.Forms.BindingNavigator registriAllBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registriAllBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.Columns.GridColumn colissue_date;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_return_date;
        private DevExpress.XtraGrid.Columns.GridColumn colreturn_date;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}