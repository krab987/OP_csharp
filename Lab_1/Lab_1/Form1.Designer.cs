namespace Lab_1
{
    partial class Form1
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
            this.calculate = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(66, 322);
            this.calculate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(132, 34);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Обрахувати";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(86, 122);
            this.tbA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(94, 27);
            this.tbA.TabIndex = 1;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(305, 122);
            this.tbD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(94, 27);
            this.tbD.TabIndex = 2;
            this.tbD.TextChanged += new System.EventHandler(this.tbD_TextChanged);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(199, 218);
            this.tbC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(94, 27);
            this.tbC.TabIndex = 3;
            this.tbC.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лабораторна робота №1\r\nВаріант №15\r\nc = 4d -a";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(44, 125);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(34, 19);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "a = ";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(262, 125);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(35, 19);
            this.lblD.TabIndex = 6;
            this.lblD.Text = "d = ";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(158, 221);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(33, 19);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "c = ";
            this.lblC.Visible = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(321, 322);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(132, 34);
            this.exit.TabIndex = 8;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(498, 396);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.calculate);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Vitalii_Palochkin_611p";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button exit;
    }
}

