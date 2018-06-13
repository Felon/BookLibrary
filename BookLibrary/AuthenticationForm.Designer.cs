namespace BookLibrary
{
    partial class AuthenticationForm
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.bookLibraryDataSet = new BookLibrary.BookLibraryDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new BookLibrary.BookLibraryDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.logtextBox = new System.Windows.Forms.TextBox();
            this.passtextBox = new System.Windows.Forms.TextBox();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(12, 20);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(73, 29);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.Location = new System.Drawing.Point(12, 64);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(120, 29);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // bookLibraryDataSet
            // 
            this.bookLibraryDataSet.DataSetName = "BookLibraryDataSet";
            this.bookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.bookLibraryDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookinfoTableAdapter = null;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.readerTableAdapter = null;
            this.tableAdapterManager.registryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "login", true));
            this.loginTextEdit.Enabled = false;
            this.loginTextEdit.Location = new System.Drawing.Point(324, 27);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(205, 22);
            this.loginTextEdit.TabIndex = 2;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "password", true));
            this.passwordTextEdit.Enabled = false;
            this.passwordTextEdit.Location = new System.Drawing.Point(324, 71);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Size = new System.Drawing.Size(205, 22);
            this.passwordTextEdit.TabIndex = 4;
            this.passwordTextEdit.EditValueChanged += new System.EventHandler(this.passwordTextEdit_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logtextBox
            // 
            this.logtextBox.Location = new System.Drawing.Point(142, 27);
            this.logtextBox.Name = "logtextBox";
            this.logtextBox.Size = new System.Drawing.Size(147, 22);
            this.logtextBox.TabIndex = 6;
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(142, 71);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(147, 22);
            this.passtextBox.TabIndex = 7;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 164);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.logtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextEdit);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookLibraryDataSet bookLibraryDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private BookLibraryDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private BookLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox logtextBox;
        private System.Windows.Forms.TextBox passtextBox;
    }
}