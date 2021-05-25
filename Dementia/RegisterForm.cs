using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dementia
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginField1.Text))
            {
                MessageBox.Show("Введите логин.");
                return;
            }
            if (string.IsNullOrEmpty(PassField1.Text))
            {
                MessageBox.Show("Введите пароль.");
                return;
            }

            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            const string command = "USE [Dementia]  INSERT INTO [dbo].[Users] ([Login],[Password]) VALUES (@Login, @Password)";

               using (SqlCommand sqlCommand = new SqlCommand(command, dbConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("@Login", SqlDbType.VarChar));
                    sqlCommand.Parameters["@Login"].Value = LoginField1.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar));
                sqlCommand.Parameters["@Password"].Value = PassField1.Text;

                try
                {
                    dbConnection.Open();
                    var t = sqlCommand.ExecuteScalar();
                    MessageBox.Show("Аккаунт был сохранен.");
                }
                catch  /*(Exception ex)*/
                {
                    MessageBox.Show("Аккаунт не может быть сохранен.");
                }
                finally
                {
                    dbConnection.Close();
                }
                }

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
