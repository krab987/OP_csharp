namespace Lab_2
{
    partial class Lab2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inf = new System.Windows.Forms.Label();
            this.lblcalc = new System.Windows.Forms.Label();
            this.put = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.tbres = new System.Windows.Forms.TextBox();
            this.target = new System.Windows.Forms.PictureBox();
            this.rbwith = new System.Windows.Forms.RadioButton();
            this.rbwithout = new System.Windows.Forms.RadioButton();
            this.lbld = new System.Windows.Forms.Label();
            this.tbd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            this.SuspendLayout();
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf.Location = new System.Drawing.Point(212, 9);
            this.inf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(197, 46);
            this.inf.TabIndex = 0;
            this.inf.Text = "Лабораторна робота №2\r\nВаріант №15\r\n";
            this.inf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblcalc
            // 
            this.lblcalc.AutoSize = true;
            this.lblcalc.Location = new System.Drawing.Point(28, 106);
            this.lblcalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcalc.Name = "lblcalc";
            this.lblcalc.Size = new System.Drawing.Size(101, 23);
            this.lblcalc.TabIndex = 1;
            this.lblcalc.Text = "Обчислити:";
            // 
            // put
            // 
            this.put.AutoSize = true;
            this.put.Location = new System.Drawing.Point(28, 188);
            this.put.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(103, 23);
            this.put.TabIndex = 2;
            this.put.Text = "Ввести дані:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(28, 228);
            this.lbla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(36, 23);
            this.lbla.TabIndex = 3;
            this.lbla.Text = "a = ";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(178, 228);
            this.lblb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(38, 23);
            this.lblb.TabIndex = 4;
            this.lblb.Text = "b = ";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(331, 228);
            this.lblc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(36, 23);
            this.lblc.TabIndex = 5;
            this.lblc.Text = "с = ";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(37, 289);
            this.lblres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(97, 23);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "Розв\'язання";
            this.lblres.Visible = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(11, 347);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(264, 37);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Обчислити";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(335, 347);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(264, 37);
            this.exit.TabIndex = 8;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(71, 225);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 30);
            this.tba.TabIndex = 9;
            this.tba.TextChanged += new System.EventHandler(this.tba_TextChanged);
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(223, 225);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 30);
            this.tbb.TabIndex = 10;
            this.tbb.TextChanged += new System.EventHandler(this.tbb_TextChanged);
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(374, 225);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(100, 30);
            this.tbc.TabIndex = 11;
            this.tbc.TextChanged += new System.EventHandler(this.tbc_TextChanged);
            // 
            // tbres
            // 
            this.tbres.Location = new System.Drawing.Point(150, 286);
            this.tbres.Name = "tbres";
            this.tbres.Size = new System.Drawing.Size(100, 30);
            this.tbres.TabIndex = 12;
            this.tbres.Visible = false;
            this.tbres.TextChanged += new System.EventHandler(this.tbres_TextChanged);
            // 
            // target
            // 
            this.target.Image = global::Lab_2.Properties.Resources.Screenshot_2;
            this.target.Location = new System.Drawing.Point(136, 79);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(141, 87);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.target.TabIndex = 13;
            this.target.TabStop = false;
            // 
            // rbwith
            // 
            this.rbwith.AutoSize = true;
            this.rbwith.Location = new System.Drawing.Point(335, 139);
            this.rbwith.Name = "rbwith";
            this.rbwith.Size = new System.Drawing.Size(194, 27);
            this.rbwith.TabIndex = 14;
            this.rbwith.Text = "З контролем винятків";
            this.rbwith.UseVisualStyleBackColor = true;
            // 
            // rbwithout
            // 
            this.rbwithout.AutoSize = true;
            this.rbwithout.Checked = true;
            this.rbwithout.Location = new System.Drawing.Point(335, 93);
            this.rbwithout.Name = "rbwithout";
            this.rbwithout.Size = new System.Drawing.Size(197, 27);
            this.rbwithout.TabIndex = 15;
            this.rbwithout.TabStop = true;
            this.rbwithout.Text = "Без контроля винятків";
            this.rbwithout.UseVisualStyleBackColor = true;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(480, 228);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(37, 23);
            this.lbld.TabIndex = 16;
            this.lbld.Text = "d = ";
            // 
            // tbd
            // 
            this.tbd.Location = new System.Drawing.Point(509, 225);
            this.tbd.Name = "tbd";
            this.tbd.Size = new System.Drawing.Size(100, 30);
            this.tbd.TabIndex = 17;
            this.tbd.TextChanged += new System.EventHandler(this.tbd_TextChanged);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 414);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.rbwithout);
            this.Controls.Add(this.rbwith);
            this.Controls.Add(this.target);
            this.Controls.Add(this.tbres);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.put);
            this.Controls.Add(this.lblcalc);
            this.Controls.Add(this.inf);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Lab2";
            this.Text = "Palochkin_Vitalii_611p";
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inf;
        private System.Windows.Forms.Label lblcalc;
        private System.Windows.Forms.Label put;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.TextBox tbres;
        private System.Windows.Forms.PictureBox target;
        private System.Windows.Forms.RadioButton rbwith;
        private System.Windows.Forms.RadioButton rbwithout;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.TextBox tbd;
    }
}

