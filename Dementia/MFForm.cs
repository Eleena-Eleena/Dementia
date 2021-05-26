using Dementia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dementia
{
    public partial class MFForm : BaseForm
    {
        private List<PatientDto> listPatient = new List<PatientDto>();
        public int IdPatient;
        public MFForm()
        {
            InitializeComponent();
        }

        private void MFForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Analyzes". При необходимости она может быть перемещена или удалена.
            this.analyzesTableAdapter.Fill(this.dementiaDataSet.Analyzes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dementiaDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dementiaDataSet.Patient);

        }

        private void medicalFileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
