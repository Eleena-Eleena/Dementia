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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

      
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void заполнениеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void медицинскаяКартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MFForm registerform = new MFForm();
            registerform.Show();
        }

        private void опекуныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorForm registerform = new TutorForm();
            registerform.Show();
        }

        private void пациентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm registerform = new PatientForm();
            registerform.Show();
        }

        private void врачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm registerform = new DoctorForm();
            registerform.Show();
        }

        private void анализToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyzeForm registerform = new AnalyzeForm();
            registerform.Show();
        }
    }
}
