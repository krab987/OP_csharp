namespace Lab_6
{
    partial class Lab_6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зверегтиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.результатToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиФайлToolStripMenuItem,
            this.зверегтиУФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиФайлToolStripMenuItem
            // 
            this.відкритиФайлToolStripMenuItem.Name = "відкритиФайлToolStripMenuItem";
            this.відкритиФайлToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.відкритиФайлToolStripMenuItem.Text = "Відкрити файл";
            this.відкритиФайлToolStripMenuItem.Click += new System.EventHandler(this.відкритиФайлToolStripMenuItem_Click);
            // 
            // зверегтиУФайлToolStripMenuItem
            // 
            this.зверегтиУФайлToolStripMenuItem.Name = "зверегтиУФайлToolStripMenuItem";
            this.зверегтиУФайлToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.зверегтиУФайлToolStripMenuItem.Text = "Зверегти у файл";
            this.зверегтиУФайлToolStripMenuItem.Click += new System.EventHandler(this.зверегтиУФайлToolStripMenuItem_Click);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.Enabled = false;
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.результатToolStripMenuItem.Text = "Результат";
            this.результатToolStripMenuItem.Click += new System.EventHandler(this.результатToolStripMenuItem_Click);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 17;
            this.lb_res.Location = new System.Drawing.Point(28, 56);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(726, 344);
            this.lb_res.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lab_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 446);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab_6";
            this.Text = "Palochkin_Vitalii_611p";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиФайлToolStripMenuItem;
        private ToolStripMenuItem зверегтиУФайлToolStripMenuItem;
        private ToolStripMenuItem результатToolStripMenuItem;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private TextBox tb_res;
        private ListBox lb_res;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}