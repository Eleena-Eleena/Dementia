﻿
namespace Dementia
{
    partial class MecicalFilesForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label numberPassportLabel;
            System.Windows.Forms.Label numberPhoneLabel;
            System.Windows.Forms.Label othernameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MecicalFilesForm));
            this.dementiaDataSet = new Dementia.DementiaDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Dementia.DementiaDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new Dementia.DementiaDataSetTableAdapters.TableAdapterManager();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.othernameTextBox = new System.Windows.Forms.TextBox();
            this.numberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.numberPassportTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ButtonPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCurrentPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonAna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            numberPassportLabel = new System.Windows.Forms.Label();
            numberPhoneLabel = new System.Windows.Forms.Label();
            othernameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            addressLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            addressLabel.Location = new System.Drawing.Point(19, 324);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 24);
            addressLabel.TabIndex = 49;
            addressLabel.Text = "Адрес";
            // 
            // numberPassportLabel
            // 
            numberPassportLabel.AutoSize = true;
            numberPassportLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            numberPassportLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            numberPassportLabel.ForeColor = System.Drawing.SystemColors.Control;
            numberPassportLabel.Location = new System.Drawing.Point(19, 288);
            numberPassportLabel.Name = "numberPassportLabel";
            numberPassportLabel.Size = new System.Drawing.Size(76, 24);
            numberPassportLabel.TabIndex = 48;
            numberPassportLabel.Text = "Паспорт";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            numberPhoneLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            numberPhoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            numberPhoneLabel.Location = new System.Drawing.Point(19, 256);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new System.Drawing.Size(70, 24);
            numberPhoneLabel.TabIndex = 47;
            numberPhoneLabel.Text = "Телефон\r\n";
            // 
            // othernameLabel
            // 
            othernameLabel.AutoSize = true;
            othernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            othernameLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            othernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            othernameLabel.Location = new System.Drawing.Point(19, 225);
            othernameLabel.Name = "othernameLabel";
            othernameLabel.Size = new System.Drawing.Size(88, 24);
            othernameLabel.TabIndex = 46;
            othernameLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            nameLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(19, 194);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 24);
            nameLabel.TabIndex = 45;
            nameLabel.Text = "Имя ";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            surnameLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            surnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            surnameLabel.Location = new System.Drawing.Point(19, 157);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(81, 24);
            surnameLabel.TabIndex = 44;
            surnameLabel.Text = "Фамилия ";
            // 
            // dementiaDataSet
            // 
            this.dementiaDataSet.DataSetName = "DementiaDataSet";
            this.dementiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dementiaDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnalyzesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.MedicalFileTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dementia.DementiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(1338, 25);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
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
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(113, 159);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(198, 22);
            this.surnameTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.nameTextBox.Location = new System.Drawing.Point(113, 194);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // othernameTextBox
            // 
            this.othernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.othernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Othername", true));
            this.othernameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.othernameTextBox.Location = new System.Drawing.Point(113, 227);
            this.othernameTextBox.Name = "othernameTextBox";
            this.othernameTextBox.Size = new System.Drawing.Size(198, 22);
            this.othernameTextBox.TabIndex = 6;
            // 
            // numberPhoneTextBox
            // 
            this.numberPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.numberPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "NumberPhone", true));
            this.numberPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.numberPhoneTextBox.Location = new System.Drawing.Point(113, 256);
            this.numberPhoneTextBox.Name = "numberPhoneTextBox";
            this.numberPhoneTextBox.Size = new System.Drawing.Size(198, 22);
            this.numberPhoneTextBox.TabIndex = 8;
            // 
            // numberPassportTextBox
            // 
            this.numberPassportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.numberPassportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "NumberPassport", true));
            this.numberPassportTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.numberPassportTextBox.Location = new System.Drawing.Point(113, 288);
            this.numberPassportTextBox.Name = "numberPassportTextBox";
            this.numberPassportTextBox.Size = new System.Drawing.Size(198, 22);
            this.numberPassportTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.addressTextBox.Location = new System.Drawing.Point(113, 324);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(198, 22);
            this.addressTextBox.TabIndex = 12;
            // 
            // ButtonPatient
            // 
            this.ButtonPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.ButtonPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPatient.FlatAppearance.BorderSize = 0;
            this.ButtonPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.ButtonPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.ButtonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPatient.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.ButtonPatient.Location = new System.Drawing.Point(216, 357);
            this.ButtonPatient.Name = "ButtonPatient";
            this.ButtonPatient.Size = new System.Drawing.Size(95, 25);
            this.ButtonPatient.TabIndex = 13;
            this.ButtonPatient.Text = "Сохранить";
            this.ButtonPatient.UseVisualStyleBackColor = false;
            this.ButtonPatient.Click += new System.EventHandler(this.ButtonPatient_Click);
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(23, 412);
            this.dataGridViewPatient.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPatient.MultiSelect = false;
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersWidth = 51;
            this.dataGridViewPatient.RowTemplate.Height = 24;
            this.dataGridViewPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatient.Size = new System.Drawing.Size(646, 208);
            this.dataGridViewPatient.TabIndex = 14;
            this.dataGridViewPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.label10.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(366, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Текущий пациент";
            // 
            // textBoxCurrentPatient
            // 
            this.textBoxCurrentPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.textBoxCurrentPatient.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurrentPatient.Location = new System.Drawing.Point(370, 328);
            this.textBoxCurrentPatient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCurrentPatient.Name = "textBoxCurrentPatient";
            this.textBoxCurrentPatient.Size = new System.Drawing.Size(299, 20);
            this.textBoxCurrentPatient.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(110, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "Пациент";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ButtonAna);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxCurrentPatient);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(surnameLabel);
            this.panel2.Controls.Add(addressLabel);
            this.panel2.Controls.Add(this.dataGridViewPatient);
            this.panel2.Controls.Add(this.surnameTextBox);
            this.panel2.Controls.Add(numberPassportLabel);
            this.panel2.Controls.Add(this.ButtonPatient);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(numberPhoneLabel);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(othernameLabel);
            this.panel2.Controls.Add(this.othernameTextBox);
            this.panel2.Controls.Add(this.numberPhoneTextBox);
            this.panel2.Controls.Add(this.numberPassportTextBox);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 641);
            this.panel2.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 67);
            this.panel1.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label9.Location = new System.Drawing.Point(404, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(539, 57);
            this.label9.TabIndex = 1;
            this.label9.Text = "Медицинская карта пациента";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAna
            // 
            this.ButtonAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.ButtonAna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAna.FlatAppearance.BorderSize = 0;
            this.ButtonAna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.ButtonAna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.ButtonAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAna.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.ButtonAna.Location = new System.Drawing.Point(574, 357);
            this.ButtonAna.Name = "ButtonAna";
            this.ButtonAna.Size = new System.Drawing.Size(95, 25);
            this.ButtonAna.TabIndex = 50;
            this.ButtonAna.Text = "Сохранить";
            this.ButtonAna.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(457, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Анализ";
            // 
            // MecicalFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Name = "MecicalFilesForm";
            this.Text = "MecicalFilesForm";
            this.Load += new System.EventHandler(this.MecicalFilesForm_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.patientBindingNavigator, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dementiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DementiaDataSet dementiaDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DementiaDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private DementiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox othernameTextBox;
        private System.Windows.Forms.TextBox numberPhoneTextBox;
        private System.Windows.Forms.TextBox numberPassportTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button ButtonPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCurrentPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAna;
    }
}