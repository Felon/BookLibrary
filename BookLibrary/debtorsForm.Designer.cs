namespace BookLibrary
{
    partial class debtorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debtorsForm));
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.debtorsTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.debtorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.debtorsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbook_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiddle_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_return_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistration_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobile_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingNavigator)).BeginInit();
            this.debtorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookLibraryDataSet
            // 
            this.bookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.bookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtorsBindingSource
            // 
            this.debtorsBindingSource.DataMember = "debtors";
            this.debtorsBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookinfoTableAdapter = null;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.readerTableAdapter = null;
            this.tableAdapterManager.registryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // debtorsBindingNavigator
            // 
            this.debtorsBindingNavigator.AddNewItem = null;
            this.debtorsBindingNavigator.BindingSource = this.debtorsBindingSource;
            this.debtorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.debtorsBindingNavigator.DeleteItem = null;
            this.debtorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.debtorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.debtorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.debtorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.debtorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.debtorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.debtorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.debtorsBindingNavigator.Name = "debtorsBindingNavigator";
            this.debtorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.debtorsBindingNavigator.Size = new System.Drawing.Size(1271, 27);
            this.debtorsBindingNavigator.TabIndex = 0;
            this.debtorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // debtorsGridControl
            // 
            this.debtorsGridControl.DataSource = this.debtorsBindingSource;
            this.debtorsGridControl.Location = new System.Drawing.Point(0, 42);
            this.debtorsGridControl.MainView = this.gridView1;
            this.debtorsGridControl.Name = "debtorsGridControl";
            this.debtorsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.debtorsGridControl.Size = new System.Drawing.Size(1271, 311);
            this.debtorsGridControl.TabIndex = 1;
            this.debtorsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbook_name,
            this.colauthor,
            this.colcode,
            this.colfirst_name,
            this.collast_name,
            this.colmiddle_name,
            this.colplan_return_date,
            this.colregistration_address,
            this.colmobile_phone});
            this.gridView1.GridControl = this.debtorsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colbook_name
            // 
            this.colbook_name.Caption = "Название книги";
            this.colbook_name.FieldName = "book_name";
            this.colbook_name.Name = "colbook_name";
            this.colbook_name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colbook_name.OptionsColumn.ReadOnly = true;
            this.colbook_name.Visible = true;
            this.colbook_name.VisibleIndex = 0;
            // 
            // colauthor
            // 
            this.colauthor.Caption = "Автор";
            this.colauthor.FieldName = "author";
            this.colauthor.Name = "colauthor";
            this.colauthor.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colauthor.OptionsColumn.ReadOnly = true;
            this.colauthor.Visible = true;
            this.colauthor.VisibleIndex = 1;
            // 
            // colcode
            // 
            this.colcode.Caption = "Код";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 2;
            // 
            // colfirst_name
            // 
            this.colfirst_name.Caption = "Имя";
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colfirst_name.OptionsColumn.ReadOnly = true;
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 3;
            // 
            // collast_name
            // 
            this.collast_name.Caption = "Фамилия";
            this.collast_name.FieldName = "last_name";
            this.collast_name.Name = "collast_name";
            this.collast_name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.collast_name.OptionsColumn.ReadOnly = true;
            this.collast_name.Visible = true;
            this.collast_name.VisibleIndex = 4;
            // 
            // colmiddle_name
            // 
            this.colmiddle_name.Caption = "Отчество";
            this.colmiddle_name.FieldName = "middle_name";
            this.colmiddle_name.Name = "colmiddle_name";
            this.colmiddle_name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colmiddle_name.OptionsColumn.ReadOnly = true;
            this.colmiddle_name.Visible = true;
            this.colmiddle_name.VisibleIndex = 5;
            // 
            // colplan_return_date
            // 
            this.colplan_return_date.Caption = "план. Дата возврата";
            this.colplan_return_date.FieldName = "plan_return_date";
            this.colplan_return_date.Name = "colplan_return_date";
            this.colplan_return_date.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colplan_return_date.OptionsColumn.ReadOnly = true;
            this.colplan_return_date.Visible = true;
            this.colplan_return_date.VisibleIndex = 6;
            // 
            // colregistration_address
            // 
            this.colregistration_address.Caption = "Адрес регистрации";
            this.colregistration_address.FieldName = "registration_address";
            this.colregistration_address.Name = "colregistration_address";
            this.colregistration_address.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colregistration_address.OptionsColumn.ReadOnly = true;
            this.colregistration_address.Visible = true;
            this.colregistration_address.VisibleIndex = 7;
            // 
            // colmobile_phone
            // 
            this.colmobile_phone.Caption = "Мобильный телефон";
            this.colmobile_phone.FieldName = "mobile_phone";
            this.colmobile_phone.Name = "colmobile_phone";
            this.colmobile_phone.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colmobile_phone.OptionsColumn.ReadOnly = true;
            this.colmobile_phone.Visible = true;
            this.colmobile_phone.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            // debtorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 354);
            this.Controls.Add(this.debtorsGridControl);
            this.Controls.Add(this.debtorsBindingNavigator);
            this.Name = "debtorsForm";
            this.Text = "Должники книг";
            this.Load += new System.EventHandler(this.debtorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingNavigator)).EndInit();
            this.debtorsBindingNavigator.ResumeLayout(false);
            this.debtorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookLibraryDataSet bookLibraryDataSet;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private BookLibraryDataSetTableAdapters.debtorsTableAdapter debtorsTableAdapter;
        private BookLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator debtorsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl debtorsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colbook_name;
        private DevExpress.XtraGrid.Columns.GridColumn colauthor;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmiddle_name;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_return_date;
        private DevExpress.XtraGrid.Columns.GridColumn colregistration_address;
        private DevExpress.XtraGrid.Columns.GridColumn colmobile_phone;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}