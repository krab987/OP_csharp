namespace Lab_7
{
    public partial class Lab_7 : Form
    {
        public Lab_7()
        {
            InitializeComponent();
        }

        string FileName;
        bool create;


        static bool CreateFileRand(string Name)
        {
            try
            {
                FileStream fs = new FileStream(Name, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);//c�������� ����� � ������ Name
                Random m = new Random();

                int n = m.Next(1, 20);
                for (int i = 0; i < n; i++)
                {
                    long el = (long)m.Next(-n, n);
                    w.Write(el);//����� � ���� �����
                }
                w.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("�������" , "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return false;
            }
        }//��������� ����� ����
        private bool CreateFileOwn(string Name, int n, string[] mas)
        {
            try
            {
                FileStream fs = new FileStream(Name, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);//c�������� ����� � ������ Name

                for (int i = 0; i < n; i++)
                {
                    long el = Convert.ToInt64(mas[i]);
                    w.Write(el);//����� � ���� �����
                }
                w.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("�������", "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return false;
            }
        }//��������� ����� ���������

        private void FileOutput(string Name)
        {

            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            long length = f.Length / 8;//���-�� ��������� �����
                                       
            lb_res.Items.Add("���� �������� " + length.ToString() + " 8-������� ���������. ���:");

            try
            {
                while (true)
                {
                    long el = r.ReadInt64();//������ ���� �������
                    lb_res.Items.Add(el.ToString());
                }
            }
            catch (EndOfStreamException)
            {
            }

            //Console.WriteLine();
            r.Close();
            f.Close();
        }//��������� ���������� � �����  �� �����
        private void FileOutput_infile(string Name, string NameSave)
        {

            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            StreamWriter w = new StreamWriter (NameSave); 

            long length = f.Length / 8;//���-�� ��������� �����

            w.WriteLine("���� �������� " + length.ToString() + " 8-������� ���������. ���:");

            try
            {
                while (true)
                {
                    long el = r.ReadInt64();//������ ���� �������
                    w.Write(el.ToString() + "\t");

                }
            }
            catch (EndOfStreamException)
            {
            }

            //Console.WriteLine();
            r.Close();
            f.Close();
            w.Close();
        }//��������� ���������� � �����  � ����

        private long SumPositive(string Name)
        {
            long s = 0, el;
            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            try
            {
                while (true)
                {
                    el = r.ReadInt64();//������� ���� �������
                    if (el > 0)
                    {
                        s += el;
                    }
                }


            }
            catch (EndOfStreamException)
            {
            }

            r.Close();
            f.Close();

            return s;
        }  // ���� ���� ������� ��
        private void ChangeNegative(string Name, long s)
        {
            long el;

            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);
            BinaryWriter w = new BinaryWriter(f);

            try
            {

                while (true)
                {
                    el = r.ReadInt64();//������� ���� �������
                    if (el < 0)
                    {
                        w.Seek(-8, SeekOrigin.Current); //��������� �������� ����� ���������, �� ��������� - �� 8 ���� ������
                        w.Write(s); //�������� s ������ ��'������ ��������
                    }
                }

            }
            catch (EndOfStreamException)
            {
            }

            f.Close();
            r.Close();
            w.Close();

        } // ���� ��'��� ��
         

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("�������� ���� � ������:\r\n" + saveFileDialog1.FileName);
                FileName = saveFileDialog1.FileName;

                if (rb_own.Checked == true)
                {
                    try
                    {
                        string s = tb_kol.Text;
                        int kol_el = Convert.ToInt32(s);
                        if (kol_el <= 0)
                        {
                            throw new Exception("ʳ������ �� ���� > 0");
                        }

                        string str = tb_chisla.Text;
                        string[] textMas = str.Split(new char[] { ',' });

                        if (textMas.Length < kol_el)
                        {
                            throw new Exception("������� ���� �����");
                        }

                        create = CreateFileOwn(FileName, kol_el, textMas);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("������� �������", "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show("������� " + ex, "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("������� " + ex, "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                }

                if (rb_rand.Checked == true)
                {
                    create = CreateFileRand(FileName);
                }
            }

        }
        private void �����������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("³������ ���� � ������:\r\n" + openFileDialog1.FileName);

                FileName = openFileDialog1.FileName;
                create = true;
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName2 = FileName;

            if (create)
            {
                lb_res.Items.Clear();

                lb_res.Items.Add("���� " + FileName2 + ":");
                FileOutput(FileName2);

                long sum = SumPositive(FileName2);
                ChangeNegative(FileName2, sum);
                lb_res.Items.Add("���� " + FileName2 + " ��i����:");
                FileOutput(FileName2);

            }
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName3 = FileName;

            if (create)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("��������� �:\r\n" + saveFileDialog1.FileName);

                    string filesave = saveFileDialog1.FileName;

                    FileOutput_infile(FileName3, filesave);

                    long sum = SumPositive(FileName3);
                    ChangeNegative(FileName3, sum);

                    FileOutput_infile(FileName3, filesave);

                }
            }

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void rb_own_CheckedChanged(object sender, EventArgs e)
        {
            lbl_kol.Visible = true;
            tb_kol.Visible = true;
            lbl_chisla.Visible = true;
            tb_chisla.Visible = true;
        }
        private void rb_rand_CheckedChanged(object sender, EventArgs e)
        {
            lbl_kol.Visible = false;
            tb_kol.Visible = false;
            lbl_chisla.Visible = false;
            tb_chisla.Visible = false;
        }

        private void tb_kol_TextChanged(object sender, EventArgs e)
        {

        }
    }

}