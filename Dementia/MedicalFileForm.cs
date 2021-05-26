using Dementia.Models;
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
    public partial class MedicalFileForm : BaseForm
    {

        private string sqlPatient = "USE [Dementia] SELECT * FROM [dbo].Patient";
        private string sqlInsertPatient = "USE [Dementia] INSERT INTO [dbo].[Patient]([Surname],[Name],[Othername],[NumberPhone],[NumberPassport],[Address])VALUES(@Surname,@Name,@Othername,@NumberPhone,@NumberPassport,@Address)";

        public int IdPatient;

        private List<PatientDto> listPatient = new List<PatientDto>();

        public MedicalFileForm()
        {
            InitializeComponent();
        }

        private List<PatientDto> GetPatient()
        {
            var list = new List<PatientDto>();
            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            using (SqlCommand sqlCommand = new SqlCommand(sqlPatient, dbConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    try
                    {
                    dbConnection.Open();
                    var reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(new PatientDto
                            {
                                IdPatient = reader.GetInt32(0),
                                Surname = reader.GetString(1),
                                Name = reader.GetString(2),
                                Othername = reader.GetString(3),
                                NumberPhone = reader.GetDecimal(4),
                                NumberPassport = reader.GetDecimal(5),
                                Address = reader.GetString(6),

                            });
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет пациента.");
                    }
                        reader.Close();
                        listPatient = list;
                        return list;
                    }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Не может взять пациента.");
                        return new List<PatientDto>();
                    }
                }

  
        }


        private void medicalFileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicalFileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dementiaDataSet);

        }

        private void MedicalFileForm_Load(object sender, EventArgs e)
        {
            listPatient = GetPatient();
            dataGridViewPatient.DataSource = listPatient;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Analyzes". При необходимости она может быть перемещена или удалена.
            this.analyzesTableAdapter.Fill(this.dementiaDataSet.Analyzes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dementiaDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dementiaDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.MedicalFile". При необходимости она может быть перемещена или удалена.
            this.medicalFileTableAdapter.Fill(this.dementiaDataSet.MedicalFile);

        }


        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPatient = listPatient[e.RowIndex].IdPatient;

            textBoxCurrentPatient.Text = listPatient[e.RowIndex].Surname + " " + listPatient[e.RowIndex].Name + " " + listPatient[e.RowIndex].Othername;

        }

        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Введите фамилию.");
                return;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Введите имя.");
                return;
            }
            if (string.IsNullOrEmpty(othernameTextBox.Text))
            {
                MessageBox.Show("Введите отчество.");
                return;
            }
            if (string.IsNullOrEmpty(numberPhoneTextBox.Text))
            {
                MessageBox.Show("Введите номер телефона.");
                return;
            }
            if (string.IsNullOrEmpty(numberPassportTextBox.Text))
            {
                MessageBox.Show("Введите паспорта.");
                return;
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Введите адрес.");
                return;
            }

            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            
            using (SqlCommand sqlCommand = new SqlCommand(sqlInsertPatient, dbConnection))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Surname"].Value = surnameTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Name"].Value = nameTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Othername", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Othername"].Value = othernameTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@NumberPhone", SqlDbType.Decimal));
                sqlCommand.Parameters["@NumberPhone"].Value = numberPhoneTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@NumberPassport", SqlDbType.Decimal));
                sqlCommand.Parameters["@NumberPassport"].Value = numberPassportTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar));
                sqlCommand.Parameters["@Address"].Value = addressTextBox.Text;

              try
                {
                    dbConnection.Open();
                    var t = sqlCommand.ExecuteScalar();
                    MessageBox.Show("Запись сохранена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Запись не сохранена.");
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
    }
}
