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
                BinaryWriter w = new BinaryWriter(fs);//cтворення файлу з назвою Name
                Random m = new Random();

                int n = m.Next(1, 20);
                for (int i = 0; i < n; i++)
                {
                    long el = (long)m.Next(-n, n);
                    w.Write(el);//запис в файл числа
                }
                w.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка" , "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return false;
            }
        }//Створення файлу ранд
        private bool CreateFileOwn(string Name, int n, string[] mas)
        {
            try
            {
                FileStream fs = new FileStream(Name, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);//cтворення файлу з назвою Name

                for (int i = 0; i < n; i++)
                {
                    long el = Convert.ToInt64(mas[i]);
                    w.Write(el);//запис в файл числа
                }
                w.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return false;
            }
        }//Створення файлу самотушки

        private void FileOutput(string Name)
        {

            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            long length = f.Length / 8;//кол-во компонент файла
                                       
            lb_res.Items.Add("Файл содержит " + length.ToString() + " 8-байтных елементов. Это:");

            try
            {
                while (true)
                {
                    long el = r.ReadInt64();//читаем один элемент
                    lb_res.Items.Add(el.ToString());
                }
            }
            catch (EndOfStreamException)
            {
            }

            //Console.WriteLine();
            r.Close();
            f.Close();
        }//виведення інформації з файлу  на экран
        private void FileOutput_infile(string Name, string NameSave)
        {

            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            StreamWriter w = new StreamWriter (NameSave); 

            long length = f.Length / 8;//кол-во компонент файла

            w.WriteLine("Файл содержит " + length.ToString() + " 8-байтных елементов. Это:");

            try
            {
                while (true)
                {
                    long el = r.ReadInt64();//читаем один элемент
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
        }//виведення інформації з файлу  в файл

        private long SumPositive(string Name)
        {
            long s = 0, el;
            FileStream f = new FileStream(Name, FileMode.Open);
            BinaryReader r = new BinaryReader(f);

            try
            {
                while (true)
                {
                    el = r.ReadInt64();//читаемо один елемент
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
        }  // рахує суму додатніх ел
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
                    el = r.ReadInt64();//читаемо один элемент
                    if (el < 0)
                    {
                        w.Seek(-8, SeekOrigin.Current); //повертаємо вказівник перед елементом, що прочитали - на 8 байт раньше
                        w.Write(s); //записуємо s замість від'ємного елементу
                    }
                }

            }
            catch (EndOfStreamException)
            {
            }

            f.Close();
            r.Close();
            w.Close();

        } // міняє від'ємні ел
         

        private void створитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Створено файл з іменем:\r\n" + saveFileDialog1.FileName);
                FileName = saveFileDialog1.FileName;

                if (rb_own.Checked == true)
                {
                    try
                    {
                        string s = tb_kol.Text;
                        int kol_el = Convert.ToInt32(s);
                        if (kol_el <= 0)
                        {
                            throw new Exception("Кількість має бути > 0");
                        }

                        string str = tb_chisla.Text;
                        string[] textMas = str.Split(new char[] { ',' });

                        if (textMas.Length < kol_el)
                        {
                            throw new Exception("Введено мало чисел");
                        }

                        create = CreateFileOwn(FileName, kol_el, textMas);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Помилка формату", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show("Помилка " + ex, "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка " + ex, "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    }
                }

                if (rb_rand.Checked == true)
                {
                    create = CreateFileRand(FileName);
                }
            }

        }
        private void відкритиФайлToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Відкрито файл з іменем:\r\n" + openFileDialog1.FileName);

                FileName = openFileDialog1.FileName;
                create = true;
            }
        }

        private void наЕкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName2 = FileName;

            if (create)
            {
                lb_res.Items.Clear();

                lb_res.Items.Add("Файл " + FileName2 + ":");
                FileOutput(FileName2);

                long sum = SumPositive(FileName2);
                ChangeNegative(FileName2, sum);
                lb_res.Items.Add("Файл " + FileName2 + " змiнено:");
                FileOutput(FileName2);

            }
        }
        private void вФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName3 = FileName;

            if (create)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Збережено в:\r\n" + saveFileDialog1.FileName);

                    string filesave = saveFileDialog1.FileName;

                    FileOutput_infile(FileName3, filesave);

                    long sum = SumPositive(FileName3);
                    ChangeNegative(FileName3, sum);

                    FileOutput_infile(FileName3, filesave);

                }
            }

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
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