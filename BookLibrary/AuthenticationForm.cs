using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookLibraryDataSet);

        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookLibraryDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.bookLibraryDataSet.User);

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string pass = passtextBox.Text;
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            string resultPass = BitConverter.ToString(checkSum).Replace("-", String.Empty).ToLower();

            string login = logtextBox.Text;
            checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(login));
            string resultLog = BitConverter.ToString(checkSum).Replace("-", String.Empty).ToLower();

            
            if (loginTextEdit.Text == resultLog & passwordTextEdit.Text == resultPass)
            {
                registerForm registerForm = new registerForm();
                this.Hide();
                registerForm.Show();
                
       
            }
            else
            {
                MessageBox.Show("Пароль введён неправильно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
