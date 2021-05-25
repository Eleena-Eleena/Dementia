﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();

            bool success = false;
            try
            {
                const string comand = "Select * From [Users] WHERE Login=@Login AND Password=@Password";
                SqlCommand check = new SqlCommand(comand, dbConnection);

                check.Parameters.AddWithValue("@Login", LoginField.Text);
                check.Parameters.AddWithValue("@Password", PassField.Text);


                using (SqlDataReader dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                dbConnection.Close();
            }

            if (success)
            {
                MessageBox.Show("Все верно.");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

    }
}
