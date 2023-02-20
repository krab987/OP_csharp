namespace Lab_5
{
    partial class Lab_5
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.введенняДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обробленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_vvod = new System.Windows.Forms.Label();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.tb_vvod = new System.Windows.Forms.TextBox();
            this.lbl_res = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(104, 35);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(339, 95);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Лабораторна робота №5\r\nВід 1 до 8 маленьких латинських букв, \r\nрозділених крапкою" +
    " з комою, \r\nпісляостаннього слова крапка.\r\nВидалити всі символи, що повторюються" +
    " підряд";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.введенняДанихToolStripMenuItem,
            this.обробленняToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // введенняДанихToolStripMenuItem
            // 
            this.введенняДанихToolStripMenuItem.Name = "введенняДанихToolStripMenuItem";
            this.введенняДанихToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.введенняДанихToolStripMenuItem.Text = "Введення даних";
            this.введенняДанихToolStripMenuItem.Click += new System.EventHandler(this.введенняДанихToolStripMenuItem_Click);
            // 
            // обробленняToolStripMenuItem
            // 
            this.обробленняToolStripMenuItem.Name = "обробленняToolStripMenuItem";
            this.обробленняToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.обробленняToolStripMenuItem.Text = "Оброблення";
            this.обробленняToolStripMenuItem.Click += new System.EventHandler(this.обробленняToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // lbl_vvod
            // 
            this.lbl_vvod.AutoSize = true;
            this.lbl_vvod.Location = new System.Drawing.Point(24, 160);
            this.lbl_vvod.Name = "lbl_vvod";
            this.lbl_vvod.Size = new System.Drawing.Size(132, 19);
            this.lbl_vvod.TabIndex = 2;
            this.lbl_vvod.Text = "Початковий рядок";
            this.lbl_vvod.Visible = false;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 19;
            this.lb_res.Location = new System.Drawing.Point(24, 302);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(474, 213);
            this.lb_res.TabIndex = 3;
            this.lb_res.Visible = false;
            // 
            // tb_vvod
            // 
            this.tb_vvod.Location = new System.Drawing.Point(24, 206);
            this.tb_vvod.Name = "tb_vvod";
            this.tb_vvod.Size = new System.Drawing.Size(474, 26);
            this.tb_vvod.TabIndex = 4;
            this.tb_vvod.Visible = false;
            this.tb_vvod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vvod_KeyPress);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(24, 265);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(75, 19);
            this.lbl_res.TabIndex = 5;
            this.lbl_res.Text = "Результат:";
            this.lbl_res.Visible = false;
            // 
            // Lab_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 527);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.tb_vvod);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lbl_vvod);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Lab_5";
            this.Text = "Vitalii_Palochkin_611p";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_info;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem введенняДанихToolStripMenuItem;
        private ToolStripMenuItem обробленняToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private Label lbl_vvod;
        private ListBox lb_res;
        private TextBox tb_vvod;
        private Label lbl_res;
    }
}