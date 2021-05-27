
namespace Dementia
{
    partial class AnalyzeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dementiaDataSet = new Dementia.DementiaDataSet();
            this.analyzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analyzesTableAdapter = new Dementia.DementiaDataSetTableAdapters.AnalyzesTableAdapter();
            this.tableAdapterManager = new Dementia.DementiaDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label8.Font = new System.Drawing.Font("Segoe Print", 10F);
            label8.ForeColor = System.Drawing.SystemColors.Control;
            label8.Location = new System.Drawing.Point(12, 217);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(142, 24);
            label8.TabIndex = 58;
            label8.Text = "Текущий пациент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label2.Font = new System.Drawing.Font("Segoe Print", 10F);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(12, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 24);
            label2.TabIndex = 59;
            label2.Text = "Анализ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label5.Font = new System.Drawing.Font("Segoe Print", 10F);
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(12, 141);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 24);
            label5.TabIndex = 60;
            label5.Text = "Результат";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label7.Font = new System.Drawing.Font("Segoe Print", 10F);
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(12, 178);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 24);
            label7.TabIndex = 61;
            label7.Text = "Дата";
            // 
            // dementiaDataSet
            // 
            this.dementiaDataSet.DataSetName = "DementiaDataSet";
            this.dementiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analyzesBindingSource
            // 
            this.analyzesBindingSource.DataMember = "Analyzes";
            this.analyzesBindingSource.DataSource = this.dementiaDataSet;
            // 
            // analyzesTableAdapter
            // 
            this.analyzesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnalyzesTableAdapter = this.analyzesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.MedicalFileTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dementia.DementiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzesBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.nameTextBox.Location = new System.Drawing.Point(121, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.resultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzesBindingSource, "Result", true));
            this.resultTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.resultTextBox.Location = new System.Drawing.Point(121, 143);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(201, 22);
            this.resultTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.analyzesBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(121, 182);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.button1.Location = new System.Drawing.Point(420, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 141);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(12, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 22);
            this.textBox1.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label9.Location = new System.Drawing.Point(308, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 57);
            this.label9.TabIndex = 1;
            this.label9.Text = "Анализы";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 426);
            this.panel2.TabIndex = 64;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label2);
            this.Controls.Add(label5);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.panel2);
            this.Name = "AnalyzeForm";
            this.Text = "Анализы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyzeForm_FormClosed);
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dateDateTimePicker, 0);
            this.Controls.SetChildIndex(this.resultTextBox, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(label8, 0);
            this.Controls.SetChildIndex(label7, 0);
            this.Controls.SetChildIndex(label5, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DementiaDataSet dementiaDataSet;
        private System.Windows.Forms.BindingSource analyzesBindingSource;
        private DementiaDataSetTableAdapters.AnalyzesTableAdapter analyzesTableAdapter;
        private DementiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
    }
}