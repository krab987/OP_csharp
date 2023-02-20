namespace Lab_4
{
    partial class Lab_4
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
            this.dgv_formuv = new System.Windows.Forms.DataGridView();
            this.lbl_kol = new System.Windows.Forms.Label();
            this.tb_kol = new System.Windows.Forms.TextBox();
            this.formuv = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.dgv_res = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formuv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_res)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(385, 28);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(595, 69);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Лабораторна робота №4\r\nВаріант 15\r\nВидалити всі елементи, що дорівнюють 0 в парни" +
    "х рядках, і 1 - в непарних:";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_formuv
            // 
            this.dgv_formuv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_formuv.Location = new System.Drawing.Point(217, 177);
            this.dgv_formuv.Name = "dgv_formuv";
            this.dgv_formuv.RowTemplate.Height = 25;
            this.dgv_formuv.Size = new System.Drawing.Size(435, 379);
            this.dgv_formuv.TabIndex = 1;
            this.dgv_formuv.Visible = false;
            // 
            // lbl_kol
            // 
            this.lbl_kol.AutoSize = true;
            this.lbl_kol.Location = new System.Drawing.Point(404, 114);
            this.lbl_kol.Name = "lbl_kol";
            this.lbl_kol.Size = new System.Drawing.Size(199, 23);
            this.lbl_kol.TabIndex = 2;
            this.lbl_kol.Text = "Кількість рядків матриці";
            // 
            // tb_kol
            // 
            this.tb_kol.Location = new System.Drawing.Point(654, 114);
            this.tb_kol.Name = "tb_kol";
            this.tb_kol.Size = new System.Drawing.Size(100, 30);
            this.tb_kol.TabIndex = 3;
            // 
            // formuv
            // 
            this.formuv.Location = new System.Drawing.Point(217, 587);
            this.formuv.Name = "formuv";
            this.formuv.Size = new System.Drawing.Size(435, 36);
            this.formuv.TabIndex = 4;
            this.formuv.Text = "Формування матриці";
            this.formuv.UseVisualStyleBackColor = true;
            this.formuv.Click += new System.EventHandler(this.formuv_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(766, 587);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(435, 36);
            this.result.TabIndex = 5;
            this.result.Text = "Отримання результату";
            this.result.UseVisualStyleBackColor = true;
            this.result.Visible = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // dgv_res
            // 
            this.dgv_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_res.Location = new System.Drawing.Point(766, 177);
            this.dgv_res.Name = "dgv_res";
            this.dgv_res.RowTemplate.Height = 25;
            this.dgv_res.Size = new System.Drawing.Size(435, 379);
            this.dgv_res.TabIndex = 6;
            this.dgv_res.Visible = false;
            // 
            // Lab_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 668);
            this.Controls.Add(this.dgv_res);
            this.Controls.Add(this.result);
            this.Controls.Add(this.formuv);
            this.Controls.Add(this.tb_kol);
            this.Controls.Add(this.lbl_kol);
            this.Controls.Add(this.dgv_formuv);
            this.Controls.Add(this.lbl_info);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Vitalii_Palochkin_611p";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formuv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_info;
        private DataGridView dgv_formuv;
        private Label lbl_kol;
        private TextBox tb_kol;
        private Button formuv;
        private Button result;
        private DataGridView dgv_res;
    }
}