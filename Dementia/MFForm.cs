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
    public partial class MFForm : BaseForm
    {
        private List<MFDto> listMF = new List<MFDto>();
        public int IdMedicalFiles;
        private string sqlMedicalFile = "USE [Dementia] SELECT * FROM [dbo].MedicalFile";
        private string sqlMedicalFile1 = "USE [Dementia] INSERT INTO [dbo].[MedicalFile]([IdPatient],[IdDoctor],[IdAnalyzes]) VALUES(@IdPatient,@IdDoctor,@IdAnalyzes)";
        private List<MFDto> GetPatient()
        {

            var list = new List<MFDto>();

            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            using (SqlCommand sqlCommand = new SqlCommand(sqlMedicalFile, dbConnection))
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
                            list.Add(new MFDto
                            {
                                IdMedicalFile = reader.GetInt32(0),
                                IdPatient = reader.GetInt32(1),
                                IdDoctor = reader.GetInt32(2),
                                IdAnalyzes = reader.GetInt32(3),
                            });
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет пациента.");
                    }
                    reader.Close();
                    listMF = list;
                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Не может взять пациента.");
                    return new List<MFDto>();
                }
            }


        }


        public MFForm()
        {
            InitializeComponent();
        }

        private void MFForm_Load(object sender, EventArgs e)
        {
            listMF = GetPatient();
            dataGridView4.DataSource = listMF;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Analyzes". При необходимости она может быть перемещена или удалена.
            this.analyzesTableAdapter.Fill(this.dementiaDataSet.Analyzes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dementiaDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dementiaDataSet.Patient);

        }


        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPatientTextBox.Text))
            {
                MessageBox.Show("Введите код пациента.");
                return;
            }
            if (string.IsNullOrEmpty(idDoctorTextBox.Text))
            {
                MessageBox.Show("Введите код доктора.");
                return;
            }
            if (string.IsNullOrEmpty(idAnalyzesTextBox.Text))
            {
                MessageBox.Show("Введите код анализа.");
                return;
            }
            

            string ConnStr = @"Data Source=eleena\sqlexpress;Initial Catalog=Dementia;Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);


            using (SqlCommand sqlCommand = new SqlCommand(sqlMedicalFile1, dbConnection))
            {
                sqlCommand.CommandType = CommandType.Text;
              
                sqlCommand.Parameters.Add(new SqlParameter("@IdPatient", SqlDbType.Int));
                sqlCommand.Parameters["@IdPatient"].Value = idPatientTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@IdDoctor", SqlDbType.Int));
                sqlCommand.Parameters["@IdDoctor"].Value = idDoctorTextBox.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@IdAnalyzes", SqlDbType.Int));
                sqlCommand.Parameters["@IdAnalyzes"].Value = idAnalyzesTextBox.Text;

               

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

        private void MFForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
