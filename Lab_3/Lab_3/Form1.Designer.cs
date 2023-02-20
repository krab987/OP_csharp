namespace Lab_3
{
    partial class Vitalii_Palochkin_611p
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
            this.lbl_inf = new System.Windows.Forms.Label();
            this.lbl_roz = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.tb_roz = new System.Windows.Forms.TextBox();
            this.tb_dob = new System.Windows.Forms.TextBox();
            this.lbl_poch = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.lb_poch = new System.Windows.Forms.ListBox();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.formuv = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inf
            // 
            this.lbl_inf.AutoSize = true;
            this.lbl_inf.Location = new System.Drawing.Point(176, 19);
            this.lbl_inf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inf.Name = "lbl_inf";
            this.lbl_inf.Size = new System.Drawing.Size(381, 104);
            this.lbl_inf.TabIndex = 0;
            this.lbl_inf.Text = "Лабораторна робота №3\r\nВаріант 15\r\nРезультат: добуток додатних елементів, \r\nподво" +
    "єні додатні елементи\r\n";
            this.lbl_inf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_roz
            // 
            this.lbl_roz.AutoSize = true;
            this.lbl_roz.Location = new System.Drawing.Point(35, 202);
            this.lbl_roz.Name = "lbl_roz";
            this.lbl_roz.Size = new System.Drawing.Size(69, 26);
            this.lbl_roz.TabIndex = 1;
            this.lbl_roz.Text = "Розмір";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(35, 312);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(87, 26);
            this.lbl_dob.TabIndex = 2;
            this.lbl_dob.Text = "Добуток";
            this.lbl_dob.Visible = false;
            // 
            // tb_roz
            // 
            this.tb_roz.Location = new System.Drawing.Point(35, 250);
            this.tb_roz.Name = "tb_roz";
            this.tb_roz.Size = new System.Drawing.Size(140, 34);
            this.tb_roz.TabIndex = 3;
            this.tb_roz.TextChanged += new System.EventHandler(this.tb_roz_TextChanged);
            // 
            // tb_dob
            // 
            this.tb_dob.Location = new System.Drawing.Point(35, 352);
            this.tb_dob.Name = "tb_dob";
            this.tb_dob.Size = new System.Drawing.Size(140, 34);
            this.tb_dob.TabIndex = 4;
            this.tb_dob.Visible = false;
          
            // 
            // lbl_poch
            // 
            this.lbl_poch.AutoSize = true;
            this.lbl_poch.Location = new System.Drawing.Point(246, 202);
            this.lbl_poch.Name = "lbl_poch";
            this.lbl_poch.Size = new System.Drawing.Size(188, 26);
            this.lbl_poch.TabIndex = 5;
            this.lbl_poch.Text = "Початковий вектор";
            this.lbl_poch.Visible = false;
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(463, 202);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(206, 26);
            this.lbl_res.TabIndex = 6;
            this.lbl_res.Text = "Результуючий вектор";
            this.lbl_res.Visible = false;
            // 
            // lb_poch
            // 
            this.lb_poch.FormattingEnabled = true;
            this.lb_poch.ItemHeight = 26;
            this.lb_poch.Location = new System.Drawing.Point(277, 250);
            this.lb_poch.Name = "lb_poch";
            this.lb_poch.Size = new System.Drawing.Size(120, 290);
            this.lb_poch.TabIndex = 7;
            this.lb_poch.Visible = false;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 26;
            this.lb_res.Location = new System.Drawing.Point(496, 250);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(120, 290);
            this.lb_res.TabIndex = 8;
            this.lb_res.Visible = false;
            // 
            // formuv
            // 
            this.formuv.Location = new System.Drawing.Point(35, 420);
            this.formuv.Name = "formuv";
            this.formuv.Size = new System.Drawing.Size(140, 40);
            this.formuv.TabIndex = 9;
            this.formuv.Text = "Сформувати";
            this.formuv.UseVisualStyleBackColor = true;
            this.formuv.Click += new System.EventHandler(this.formuv_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(35, 489);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(140, 62);
            this.result.TabIndex = 10;
            this.result.Text = "Отримати результат";
            this.result.UseVisualStyleBackColor = true;
            this.result.Visible = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Vitalii_Palochkin_611p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 574);
            this.Controls.Add(this.result);
            this.Controls.Add(this.formuv);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lb_poch);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_poch);
            this.Controls.Add(this.tb_dob);
            this.Controls.Add(this.tb_roz);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_roz);
            this.Controls.Add(this.lbl_inf);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vitalii_Palochkin_611p";
            this.Text = "Vitalii_Palochkin_611p";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_inf;
        private Label lbl_roz;
        private Label lbl_dob;
        private TextBox tb_roz;
        private TextBox tb_dob;
        private Label lbl_poch;
        private Label lbl_res;
        private ListBox lb_poch;
        private ListBox lb_res;
        private Button formuv;
        private Button result;
    }
}