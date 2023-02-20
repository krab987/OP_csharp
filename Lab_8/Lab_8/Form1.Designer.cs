namespace Lab_8
{
    partial class v
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v));
            this.pb_inf = new System.Windows.Forms.PictureBox();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.lbl_res = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.rb_kv = new System.Windows.Forms.RadioButton();
            this.rb_trik = new System.Windows.Forms.RadioButton();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.ClearLB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inf)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_inf
            // 
            this.pb_inf.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_inf.ErrorImage")));
            this.pb_inf.Image = ((System.Drawing.Image)(resources.GetObject("pb_inf.Image")));
            this.pb_inf.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_inf.InitialImage")));
            this.pb_inf.Location = new System.Drawing.Point(42, 24);
            this.pb_inf.Name = "pb_inf";
            this.pb_inf.Size = new System.Drawing.Size(627, 128);
            this.pb_inf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_inf.TabIndex = 0;
            this.pb_inf.TabStop = false;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 21;
            this.lb_res.Location = new System.Drawing.Point(42, 242);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(627, 172);
            this.lb_res.TabIndex = 1;
            this.lb_res.Visible = false;
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(42, 201);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(90, 21);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Результат:";
            this.lbl_res.Visible = false;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(42, 458);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(627, 34);
            this.result.TabIndex = 3;
            this.result.Text = "Результат";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // rb_kv
            // 
            this.rb_kv.AutoSize = true;
            this.rb_kv.Checked = true;
            this.rb_kv.Location = new System.Drawing.Point(716, 127);
            this.rb_kv.Name = "rb_kv";
            this.rb_kv.Size = new System.Drawing.Size(94, 25);
            this.rb_kv.TabIndex = 4;
            this.rb_kv.TabStop = true;
            this.rb_kv.Text = "Квадрат";
            this.rb_kv.UseVisualStyleBackColor = true;
            this.rb_kv.CheckedChanged += new System.EventHandler(this.rb_kv_CheckedChanged);
            // 
            // rb_trik
            // 
            this.rb_trik.AutoSize = true;
            this.rb_trik.Location = new System.Drawing.Point(716, 186);
            this.rb_trik.Name = "rb_trik";
            this.rb_trik.Size = new System.Drawing.Size(114, 25);
            this.rb_trik.TabIndex = 5;
            this.rb_trik.Text = "Трикутник";
            this.rb_trik.UseVisualStyleBackColor = true;
            this.rb_trik.CheckedChanged += new System.EventHandler(this.rb_trik_CheckedChanged);
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(716, 252);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(180, 29);
            this.tb_a.TabIndex = 6;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(716, 320);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(180, 29);
            this.tb_b.TabIndex = 7;
            this.tb_b.Visible = false;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(716, 385);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(180, 29);
            this.tb_c.TabIndex = 8;
            this.tb_c.Visible = false;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(716, 228);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(39, 21);
            this.lbl_a.TabIndex = 9;
            this.lbl_a.Text = "а = ";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(716, 296);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(41, 21);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "b = ";
            this.lbl_b.Visible = false;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(716, 361);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(40, 21);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c = ";
            this.lbl_c.Visible = false;
            // 
            // ClearLB
            // 
            this.ClearLB.Location = new System.Drawing.Point(716, 458);
            this.ClearLB.Name = "ClearLB";
            this.ClearLB.Size = new System.Drawing.Size(180, 34);
            this.ClearLB.TabIndex = 12;
            this.ClearLB.Text = "Очистити";
            this.ClearLB.UseVisualStyleBackColor = true;
            this.ClearLB.Click += new System.EventHandler(this.ClearLB_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 573);
            this.Controls.Add(this.ClearLB);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.rb_trik);
            this.Controls.Add(this.rb_kv);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.pb_inf);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "v";
            this.Text = "Vitalii_Palochkin_611p";
            ((System.ComponentModel.ISupportInitialize)(this.pb_inf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_inf;
        private ListBox lb_res;
        private Label lbl_res;
        private Button result;
        private RadioButton rb_kv;
        private RadioButton rb_trik;
        private TextBox tb_a;
        private TextBox tb_b;
        private TextBox tb_c;
        private Label lbl_a;
        private Label lbl_b;
        private Label lbl_c;
        private Button ClearLB;
    }
}