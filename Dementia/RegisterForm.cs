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
            LoginField1.Text = "Логин";
            LoginField1.ForeColor = Color.Gray;
            PassField1.Text = "Пароль";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
        }

        private void LoginField1_Enter(object sender, EventArgs e)
        {
            if (LoginField1.Text == "Логин")
            {
                LoginField1.Text = "";
                LoginField1.ForeColor = Color.Black;
            }
        }

        private void PassField1_Enter(object sender, EventArgs e)
        {
            if (PassField1.Text == "Пароль")
            {
                PassField1.Text = "";
            }
        }

        private void LoginField1_Leave(object sender, EventArgs e)
        {
            if (LoginField1.Text == "")
            {
                LoginField1.Text = "Логин";
                LoginField1.ForeColor = Color.Gray;
            }
        }

        private void PassField1_Leave(object sender, EventArgs e)
        {
            if (PassField1.Text == "")
            {
                PassField1.Text = "Пароль";
            }
        }
    }
}
