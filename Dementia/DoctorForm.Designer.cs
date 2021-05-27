
namespace Dementia
{
    partial class DoctorForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dementiaDataSet = new Dementia.DementiaDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Dementia.DementiaDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new Dementia.DementiaDataSetTableAdapters.TableAdapterManager();
            this.medicalFileTableAdapter = new Dementia.DementiaDataSetTableAdapters.MedicalFileTableAdapter();
            this.doctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.medicalFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.othernameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.numberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).BeginInit();
            this.doctorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalFileBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label1.Font = new System.Drawing.Font("Segoe Print", 10F);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(27, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 24);
            label1.TabIndex = 60;
            label1.Text = "Фамилия ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label2.Font = new System.Drawing.Font("Segoe Print", 10F);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(27, 298);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 24);
            label2.TabIndex = 65;
            label2.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label4.Font = new System.Drawing.Font("Segoe Print", 10F);
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(27, 219);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 24);
            label4.TabIndex = 61;
            label4.Text = "Имя ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label5.Font = new System.Drawing.Font("Segoe Print", 10F);
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(27, 339);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 24);
            label5.TabIndex = 63;
            label5.Text = "Телефон\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            label6.Font = new System.Drawing.Font("Segoe Print", 10F);
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(27, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 24);
            label6.TabIndex = 62;
            label6.Text = "Отчество";
            // 
            // dementiaDataSet
            // 
            this.dementiaDataSet.DataSetName = "DementiaDataSet";
            this.dementiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dementiaDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnalyzesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.MedicalFileTableAdapter = this.medicalFileTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dementia.DementiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // medicalFileTableAdapter
            // 
            this.medicalFileTableAdapter.ClearBeforeFill = true;
            // 
            // doctorBindingNavigator
            // 
            this.doctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.doctorBindingNavigator.BindingSource = this.doctorBindingSource;
            this.doctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.doctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.doctorBindingNavigatorSaveItem});
            this.doctorBindingNavigator.Location = new System.Drawing.Point(22, 142);
            this.doctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorBindingNavigator.Name = "doctorBindingNavigator";
            this.doctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.doctorBindingNavigator.TabIndex = 0;
            this.doctorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // doctorBindingNavigatorSaveItem
            // 
            this.doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorBindingNavigatorSaveItem.Image")));
            this.doctorBindingNavigatorSaveItem.Name = "doctorBindingNavigatorSaveItem";
            this.doctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.doctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorBindingNavigatorSaveItem_Click);
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.doctorDataGridView.Location = new System.Drawing.Point(22, 377);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowHeadersVisible = false;
            this.doctorDataGridView.Size = new System.Drawing.Size(738, 187);
            this.doctorDataGridView.TabIndex = 1;
            // 
            // medicalFileBindingSource
            // 
            this.medicalFileBindingSource.DataMember = "FK_MedicalFile_Doctor";
            this.medicalFileBindingSource.DataSource = this.doctorBindingSource;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(139, 180);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(182, 22);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.nameTextBox.Location = new System.Drawing.Point(139, 223);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // othernameTextBox
            // 
            this.othernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.othernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Othername", true));
            this.othernameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.othernameTextBox.Location = new System.Drawing.Point(139, 259);
            this.othernameTextBox.Name = "othernameTextBox";
            this.othernameTextBox.Size = new System.Drawing.Size(182, 22);
            this.othernameTextBox.TabIndex = 10;
            // 
            // positionTextBox
            // 
            this.positionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.positionTextBox.Location = new System.Drawing.Point(139, 298);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(182, 22);
            this.positionTextBox.TabIndex = 12;
            // 
            // numberPhoneTextBox
            // 
            this.numberPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.numberPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "NumberPhone", true));
            this.numberPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.numberPhoneTextBox.Location = new System.Drawing.Point(139, 339);
            this.numberPhoneTextBox.Name = "numberPhoneTextBox";
            this.numberPhoneTextBox.Size = new System.Drawing.Size(182, 22);
            this.numberPhoneTextBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 543);
            this.panel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 98);
            this.panel1.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label9.Location = new System.Drawing.Point(407, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 57);
            this.label9.TabIndex = 1;
            this.label9.Text = "Врачи";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Othername";
            this.dataGridViewTextBoxColumn4.HeaderText = "Othername";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumberPhone";
            this.dataGridViewTextBoxColumn6.HeaderText = "NumberPhone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 567);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.othernameTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.numberPhoneTextBox);
            this.Controls.Add(this.doctorDataGridView);
            this.Controls.Add(this.doctorBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Name = "DoctorForm";
            this.Text = "Врачи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.doctorBindingNavigator, 0);
            this.Controls.SetChildIndex(this.doctorDataGridView, 0);
            this.Controls.SetChildIndex(this.numberPhoneTextBox, 0);
            this.Controls.SetChildIndex(this.positionTextBox, 0);
            this.Controls.SetChildIndex(this.othernameTextBox, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(this.surnameTextBox, 0);
            this.Controls.SetChildIndex(label6, 0);
            this.Controls.SetChildIndex(label5, 0);
            this.Controls.SetChildIndex(label4, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).EndInit();
            this.doctorBindingNavigator.ResumeLayout(false);
            this.doctorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalFileBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DementiaDataSet dementiaDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DementiaDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private DementiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton doctorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private DementiaDataSetTableAdapters.MedicalFileTableAdapter medicalFileTableAdapter;
        private System.Windows.Forms.BindingSource medicalFileBindingSource;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox othernameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox numberPhoneTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}