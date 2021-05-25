
namespace Dementia
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PassField1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginField1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(122, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.RegisterButton);
            this.panel2.Controls.Add(this.PassField1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LoginField1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 209);
            this.panel2.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(191, 140);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(211, 38);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PassField1
            // 
            this.PassField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.PassField1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PassField1.Location = new System.Drawing.Point(132, 86);
            this.PassField1.Name = "PassField1";
            this.PassField1.Size = new System.Drawing.Size(270, 29);
            this.PassField1.TabIndex = 8;
            this.PassField1.UseSystemPasswordChar = true;
            this.PassField1.Enter += new System.EventHandler(this.PassField1_Enter);
            this.PassField1.Leave += new System.EventHandler(this.PassField1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(36, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Пароль";
            // 
            // LoginField1
            // 
            this.LoginField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
            this.LoginField1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField1.Location = new System.Drawing.Point(132, 35);
            this.LoginField1.Name = "LoginField1";
            this.LoginField1.Size = new System.Drawing.Size(270, 29);
            this.LoginField1.TabIndex = 6;
            this.LoginField1.Enter += new System.EventHandler(this.LoginField1_Enter);
            this.LoginField1.Leave += new System.EventHandler(this.LoginField1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Логин";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 276);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassField1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginField1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterButton;
    }
}