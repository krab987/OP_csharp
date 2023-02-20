namespace DZ
{
    partial class DZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DZ));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inf = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_k = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_k = new System.Windows.Forms.TextBox();
            this.tb_S = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.lbl_S = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.bttn = new System.Windows.Forms.Button();
            this.rb_k = new System.Windows.Forms.RadioButton();
            this.rb_e = new System.Windows.Forms.RadioButton();
            this.lbl_e = new System.Windows.Forms.Label();
            this.tb_e = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Location = new System.Drawing.Point(322, 21);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(200, 52);
            this.inf.TabIndex = 1;
            this.inf.Text = "Розрахункова робота\r\nВаріант 15";
            this.inf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(98, 252);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(45, 26);
            this.lbl_x.TabIndex = 2;
            this.lbl_x.Text = "x = ";
            // 
            // lbl_k
            // 
            this.lbl_k.AutoSize = true;
            this.lbl_k.Location = new System.Drawing.Point(322, 255);
            this.lbl_k.Name = "lbl_k";
            this.lbl_k.Size = new System.Drawing.Size(44, 26);
            this.lbl_k.TabIndex = 3;
            this.lbl_k.Text = "k = ";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(168, 249);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(100, 34);
            this.tb_x.TabIndex = 4;

            // 
            // tb_k
            // 
            this.tb_k.Location = new System.Drawing.Point(372, 252);
            this.tb_k.Name = "tb_k";
            this.tb_k.Size = new System.Drawing.Size(133, 34);
            this.tb_k.TabIndex = 5;

            // 
            // tb_S
            // 
            this.tb_S.Location = new System.Drawing.Point(344, 319);
            this.tb_S.Name = "tb_S";
            this.tb_S.Size = new System.Drawing.Size(201, 34);
            this.tb_S.TabIndex = 6;
            this.tb_S.Visible = false;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(344, 377);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(201, 34);
            this.tb_C.TabIndex = 7;
            this.tb_C.Visible = false;
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Location = new System.Drawing.Point(268, 327);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(47, 26);
            this.lbl_S.TabIndex = 8;
            this.lbl_S.Text = "S = ";
            this.lbl_S.Visible = false;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Location = new System.Drawing.Point(270, 385);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(45, 26);
            this.lbl_C.TabIndex = 9;
            this.lbl_C.Text = "C = ";
            this.lbl_C.Visible = false;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(242, 440);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(319, 38);
            this.bttn.TabIndex = 10;
            this.bttn.Text = "Порахувати";
            this.bttn.UseVisualStyleBackColor = true;
            this.bttn.Click += new System.EventHandler(this.bttn_Click);
            // 
            // rb_k
            // 
            this.rb_k.AutoSize = true;
            this.rb_k.Checked = true;
            this.rb_k.Location = new System.Drawing.Point(579, 105);
            this.rb_k.Name = "rb_k";
            this.rb_k.Size = new System.Drawing.Size(198, 30);
            this.rb_k.TabIndex = 11;
            this.rb_k.TabStop = true;
            this.rb_k.Text = "Спосіб 1 (кількість)";
            this.rb_k.UseVisualStyleBackColor = true;
            this.rb_k.CheckedChanged += new System.EventHandler(this.rb_k_CheckedChanged);
            // 
            // rb_e
            // 
            this.rb_e.AutoSize = true;
            this.rb_e.Location = new System.Drawing.Point(579, 161);
            this.rb_e.Name = "rb_e";
            this.rb_e.Size = new System.Drawing.Size(199, 30);
            this.rb_e.TabIndex = 12;
            this.rb_e.Text = "Спосіб 2 (точність)";
            this.rb_e.UseVisualStyleBackColor = true;
            this.rb_e.CheckedChanged += new System.EventHandler(this.rb_e_CheckedChanged);
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Location = new System.Drawing.Point(529, 255);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(44, 26);
            this.lbl_e.TabIndex = 13;
            this.lbl_e.Text = "e = ";
            this.lbl_e.Visible = false;
            // 
            // tb_e
            // 
            this.tb_e.Location = new System.Drawing.Point(579, 252);
            this.tb_e.Name = "tb_e";
            this.tb_e.Size = new System.Drawing.Size(165, 34);
            this.tb_e.TabIndex = 14;
            this.tb_e.Visible = false;

            // 
            // DZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 522);
            this.Controls.Add(this.tb_e);
            this.Controls.Add(this.lbl_e);
            this.Controls.Add(this.rb_e);
            this.Controls.Add(this.rb_k);
            this.Controls.Add(this.bttn);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_S);
            this.Controls.Add(this.tb_k);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.lbl_k);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DZ";
            this.Text = "Palochkin_Vitalii_611p";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label inf;
        private Label lbl_x;
        private Label lbl_k;
        private TextBox tb_x;
        private TextBox tb_k;
        private TextBox tb_S;
        private TextBox tb_C;
        private Label lbl_S;
        private Label lbl_C;
        private Button bttn;
        private RadioButton rb_k;
        private RadioButton rb_e;
        private Label lbl_e;
        private TextBox tb_e;
    }
}