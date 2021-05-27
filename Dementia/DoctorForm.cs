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
    public partial class DoctorForm : BaseForm
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dementiaDataSet);

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.MedicalFile". При необходимости она может быть перемещена или удалена.
            this.medicalFileTableAdapter.Fill(this.dementiaDataSet.MedicalFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dementiaDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dementiaDataSet.Doctor);

        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
