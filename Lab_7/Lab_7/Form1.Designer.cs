namespace Lab_7
{
    partial class Lab_7
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_7));
            this.lbl_info = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЕкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_kol = new System.Windows.Forms.TextBox();
            this.lbl_kol = new System.Windows.Forms.Label();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.rb_own = new System.Windows.Forms.RadioButton();
            this.rb_rand = new System.Windows.Forms.RadioButton();
            this.lbl_chisla = new System.Windows.Forms.Label();
            this.tb_chisla = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(198, 36);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(431, 76);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Лабораторна робота №7\r\nПрочитати з файла дійсні восьмибайтні елементи, підрахуват" +
    "и\r\nзагальну кількість елементів файла, а також замінити у файлі \r\nусі від’ємні е" +
    "лементи на суму всіх додатних чисел";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.результатToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиФайлToolStripMenuItem,
            this.відкритиФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиФайлToolStripMenuItem
            // 
            this.створитиФайлToolStripMenuItem.Name = "створитиФайлToolStripMenuItem";
            this.створитиФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.створитиФайлToolStripMenuItem.Text = "Створити файл";
            this.створитиФайлToolStripMenuItem.Click += new System.EventHandler(this.створитиФайлToolStripMenuItem_Click);
            // 
            // відкритиФайлToolStripMenuItem
            // 
            this.відкритиФайлToolStripMenuItem.Name = "відкритиФайлToolStripMenuItem";
            this.відкритиФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиФайлToolStripMenuItem.Text = "Відкрити файл";
            this.відкритиФайлToolStripMenuItem.Click += new System.EventHandler(this.відкритиФайлToolStripMenuItem_Click_1);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наЕкранToolStripMenuItem,
            this.вФайлToolStripMenuItem});
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.результатToolStripMenuItem.Text = "Результат";
            // 
            // наЕкранToolStripMenuItem
            // 
            this.наЕкранToolStripMenuItem.Name = "наЕкранToolStripMenuItem";
            this.наЕкранToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.наЕкранToolStripMenuItem.Text = "На екран";
            this.наЕкранToolStripMenuItem.Click += new System.EventHandler(this.наЕкранToolStripMenuItem_Click);
            // 
            // вФайлToolStripMenuItem
            // 
            this.вФайлToolStripMenuItem.Name = "вФайлToolStripMenuItem";
            this.вФайлToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.вФайлToolStripMenuItem.Text = "В файл";
            this.вФайлToolStripMenuItem.Click += new System.EventHandler(this.вФайлToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // tb_kol
            // 
            this.tb_kol.Location = new System.Drawing.Point(29, 244);
            this.tb_kol.Name = "tb_kol";
            this.tb_kol.Size = new System.Drawing.Size(188, 26);
            this.tb_kol.TabIndex = 3;
            this.tb_kol.Visible = false;
            this.tb_kol.TextChanged += new System.EventHandler(this.tb_kol_TextChanged);
            // 
            // lbl_kol
            // 
            this.lbl_kol.AutoSize = true;
            this.lbl_kol.Location = new System.Drawing.Point(29, 208);
            this.lbl_kol.Name = "lbl_kol";
            this.lbl_kol.Size = new System.Drawing.Size(139, 19);
            this.lbl_kol.TabIndex = 5;
            this.lbl_kol.Text = "Кількість елементів";
            this.lbl_kol.Visible = false;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 19;
            this.lb_res.Location = new System.Drawing.Point(258, 132);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(335, 289);
            this.lb_res.TabIndex = 6;
            // 
            // rb_own
            // 
            this.rb_own.AutoSize = true;
            this.rb_own.Location = new System.Drawing.Point(611, 153);
            this.rb_own.Name = "rb_own";
            this.rb_own.Size = new System.Drawing.Size(163, 23);
            this.rb_own.TabIndex = 7;
            this.rb_own.Text = "Вводити самотушки";
            this.rb_own.UseVisualStyleBackColor = true;
            this.rb_own.CheckedChanged += new System.EventHandler(this.rb_own_CheckedChanged);
            // 
            // rb_rand
            // 
            this.rb_rand.AutoSize = true;
            this.rb_rand.Checked = true;
            this.rb_rand.Location = new System.Drawing.Point(611, 206);
            this.rb_rand.Name = "rb_rand";
            this.rb_rand.Size = new System.Drawing.Size(78, 23);
            this.rb_rand.TabIndex = 8;
            this.rb_rand.TabStop = true;
            this.rb_rand.Text = "Рандом";
            this.rb_rand.UseVisualStyleBackColor = true;
            this.rb_rand.CheckedChanged += new System.EventHandler(this.rb_rand_CheckedChanged);
            // 
            // lbl_chisla
            // 
            this.lbl_chisla.AutoSize = true;
            this.lbl_chisla.Location = new System.Drawing.Point(29, 289);
            this.lbl_chisla.Name = "lbl_chisla";
            this.lbl_chisla.Size = new System.Drawing.Size(210, 19);
            this.lbl_chisla.TabIndex = 9;
            this.lbl_chisla.Text = "Введіть ваші числа через кому";
            this.lbl_chisla.Visible = false;
            // 
            // tb_chisla
            // 
            this.tb_chisla.Location = new System.Drawing.Point(29, 334);
            this.tb_chisla.Name = "tb_chisla";
            this.tb_chisla.Size = new System.Drawing.Size(188, 26);
            this.tb_chisla.TabIndex = 10;
            this.tb_chisla.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lab_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 439);
            this.Controls.Add(this.tb_chisla);
            this.Controls.Add(this.lbl_chisla);
            this.Controls.Add(this.rb_rand);
            this.Controls.Add(this.rb_own);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lbl_kol);
            this.Controls.Add(this.tb_kol);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab_7";
            this.Text = "Vitalii_Palochkin_611p";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_info;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem створитиФайлToolStripMenuItem;
        private ToolStripMenuItem відкритиФайлToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private TextBox tb_kol;
        private Label lbl_kol;
        private ListBox lb_res;
        private RadioButton rb_own;
        private RadioButton rb_rand;
        private Label lbl_chisla;
        private TextBox tb_chisla;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem результатToolStripMenuItem;
        private ToolStripMenuItem наЕкранToolStripMenuItem;
        private ToolStripMenuItem вФайлToolStripMenuItem;
    }
}