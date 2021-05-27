
namespace Dementia
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнениеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опекуныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fToolStripMenuItem.Text = "Files";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнениеДанныхToolStripMenuItem,
            this.медицинскаяКартаToolStripMenuItem,
            this.опекуныToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // заполнениеДанныхToolStripMenuItem
            // 
            this.заполнениеДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентToolStripMenuItem,
            this.врачToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.заполнениеДанныхToolStripMenuItem.Name = "заполнениеДанныхToolStripMenuItem";
            this.заполнениеДанныхToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.заполнениеДанныхToolStripMenuItem.Text = "Заполнение данных";
            this.заполнениеДанныхToolStripMenuItem.Click += new System.EventHandler(this.заполнениеДанныхToolStripMenuItem_Click);
            // 
            // медицинскаяКартаToolStripMenuItem
            // 
            this.медицинскаяКартаToolStripMenuItem.Name = "медицинскаяКартаToolStripMenuItem";
            this.медицинскаяКартаToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.медицинскаяКартаToolStripMenuItem.Text = "Медицинская карта";
            this.медицинскаяКартаToolStripMenuItem.Click += new System.EventHandler(this.медицинскаяКартаToolStripMenuItem_Click);
            // 
            // опекуныToolStripMenuItem
            // 
            this.опекуныToolStripMenuItem.Name = "опекуныToolStripMenuItem";
            this.опекуныToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.опекуныToolStripMenuItem.Text = "Опекуны";
            this.опекуныToolStripMenuItem.Click += new System.EventHandler(this.опекуныToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пациентToolStripMenuItem
            // 
            this.пациентToolStripMenuItem.Name = "пациентToolStripMenuItem";
            this.пациентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пациентToolStripMenuItem.Text = "Пациент";
            this.пациентToolStripMenuItem.Click += new System.EventHandler(this.пациентToolStripMenuItem_Click);
            // 
            // врачToolStripMenuItem
            // 
            this.врачToolStripMenuItem.Name = "врачToolStripMenuItem";
            this.врачToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.врачToolStripMenuItem.Text = "Врач";
            this.врачToolStripMenuItem.Click += new System.EventHandler(this.врачToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.анализToolStripMenuItem.Text = "Анализ";
            this.анализToolStripMenuItem.Click += new System.EventHandler(this.анализToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнениеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медицинскаяКартаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опекуныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
    }
}