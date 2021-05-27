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
    public partial class PatientForm : BaseForm
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void analyzesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analyzesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dementiaDataSet);

        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dementiaDataSet);

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Analyzes". При необходимости она может быть перемещена или удалена.
            this.analyzesTableAdapter.Fill(this.dementiaDataSet.Analyzes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dementiaDataSet.Patient);

        }

        private void analyzesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
