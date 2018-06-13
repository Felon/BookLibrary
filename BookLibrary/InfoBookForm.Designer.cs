namespace BookLibrary
{
    partial class InfoBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoBookForm));
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.bookinfoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookinfoAllTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.BookinfoAllTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.bookinfoAllBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookinfoAllBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookinfoAllGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbook_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyear_publishing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colissued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colannotation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllBindingNavigator)).BeginInit();
            this.bookinfoAllBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookLibraryDataSet
            // 
            this.bookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.bookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookinfoAllBindingSource
            // 
            this.bookinfoAllBindingSource.DataMember = "BookinfoAll";
            this.bookinfoAllBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // bookinfoAllTableAdapter
            // 
            this.bookinfoAllTableAdapter.ClearBeforeFill = true;
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
            // bookinfoAllBindingNavigator
            // 
            this.bookinfoAllBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookinfoAllBindingNavigator.BindingSource = this.bookinfoAllBindingSource;
            this.bookinfoAllBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookinfoAllBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookinfoAllBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookinfoAllBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookinfoAllBindingNavigatorSaveItem});
            this.bookinfoAllBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookinfoAllBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookinfoAllBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookinfoAllBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookinfoAllBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookinfoAllBindingNavigator.Name = "bookinfoAllBindingNavigator";
            this.bookinfoAllBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookinfoAllBindingNavigator.Size = new System.Drawing.Size(877, 27);
            this.bookinfoAllBindingNavigator.TabIndex = 0;
            this.bookinfoAllBindingNavigator.Text = "bindingNavigator1";
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
            // bookinfoAllBindingNavigatorSaveItem
            // 
            this.bookinfoAllBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookinfoAllBindingNavigatorSaveItem.Enabled = false;
            this.bookinfoAllBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookinfoAllBindingNavigatorSaveItem.Image")));
            this.bookinfoAllBindingNavigatorSaveItem.Name = "bookinfoAllBindingNavigatorSaveItem";
            this.bookinfoAllBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.bookinfoAllBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // bookinfoAllGridControl
            // 
            this.bookinfoAllGridControl.DataSource = this.bookinfoAllBindingSource;
            this.bookinfoAllGridControl.Location = new System.Drawing.Point(0, 30);
            this.bookinfoAllGridControl.MainView = this.gridView1;
            this.bookinfoAllGridControl.Name = "bookinfoAllGridControl";
            this.bookinfoAllGridControl.Size = new System.Drawing.Size(877, 392);
            this.bookinfoAllGridControl.TabIndex = 1;
            this.bookinfoAllGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbook_name,
            this.colauthor,
            this.colyear_publishing,
            this.colquantity,
            this.colissued,
            this.colannotation});
            this.gridView1.GridControl = this.bookinfoAllGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colbook_name
            // 
            this.colbook_name.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colbook_name.AppearanceCell.Options.UseBackColor = true;
            this.colbook_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colbook_name.AppearanceHeader.Options.UseFont = true;
            this.colbook_name.Caption = "Название книги";
            this.colbook_name.FieldName = "book_name";
            this.colbook_name.Name = "colbook_name";
            this.colbook_name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colbook_name.Visible = true;
            this.colbook_name.VisibleIndex = 0;
            // 
            // colauthor
            // 
            this.colauthor.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colauthor.AppearanceCell.Options.UseBackColor = true;
            this.colauthor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colauthor.AppearanceHeader.Options.UseFont = true;
            this.colauthor.Caption = "Автор";
            this.colauthor.FieldName = "author";
            this.colauthor.Name = "colauthor";
            this.colauthor.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colauthor.Visible = true;
            this.colauthor.VisibleIndex = 1;
            // 
            // colyear_publishing
            // 
            this.colyear_publishing.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colyear_publishing.AppearanceCell.Options.UseBackColor = true;
            this.colyear_publishing.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colyear_publishing.AppearanceHeader.Options.UseFont = true;
            this.colyear_publishing.Caption = "Год публикации";
            this.colyear_publishing.FieldName = "year_publishing";
            this.colyear_publishing.Name = "colyear_publishing";
            this.colyear_publishing.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colyear_publishing.Visible = true;
            this.colyear_publishing.VisibleIndex = 2;
            // 
            // colquantity
            // 
            this.colquantity.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colquantity.AppearanceCell.Options.UseBackColor = true;
            this.colquantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colquantity.AppearanceHeader.Options.UseFont = true;
            this.colquantity.Caption = "Кол-во";
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 3;
            // 
            // colissued
            // 
            this.colissued.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colissued.AppearanceCell.Options.UseBackColor = true;
            this.colissued.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colissued.AppearanceHeader.Options.UseFont = true;
            this.colissued.Caption = "Выдано";
            this.colissued.FieldName = "issued";
            this.colissued.Name = "colissued";
            this.colissued.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colissued.Visible = true;
            this.colissued.VisibleIndex = 4;
            // 
            // colannotation
            // 
            this.colannotation.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.colannotation.AppearanceCell.Options.UseBackColor = true;
            this.colannotation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colannotation.AppearanceHeader.Options.UseFont = true;
            this.colannotation.Caption = "Аннотация";
            this.colannotation.FieldName = "annotation";
            this.colannotation.Name = "colannotation";
            this.colannotation.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.colannotation.Visible = true;
            this.colannotation.VisibleIndex = 5;
            // 
            // InfoBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 428);
            this.Controls.Add(this.bookinfoAllGridControl);
            this.Controls.Add(this.bookinfoAllBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InfoBookForm";
            this.Text = "Информация о книгах";
            this.Load += new System.EventHandler(this.InfoBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllBindingNavigator)).EndInit();
            this.bookinfoAllBindingNavigator.ResumeLayout(false);
            this.bookinfoAllBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoAllGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookLibraryDataSet bookLibraryDataSet;
        private System.Windows.Forms.BindingSource bookinfoAllBindingSource;
        private BookLibraryDataSetTableAdapters.BookinfoAllTableAdapter bookinfoAllTableAdapter;
        private BookLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookinfoAllBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookinfoAllBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl bookinfoAllGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colbook_name;
        private DevExpress.XtraGrid.Columns.GridColumn colauthor;
        private DevExpress.XtraGrid.Columns.GridColumn colyear_publishing;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colissued;
        private DevExpress.XtraGrid.Columns.GridColumn colannotation;
    }
}