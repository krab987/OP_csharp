namespace Lab_6
{
    public partial class Lab_6 : Form
    {
        public Lab_6()
        {
            InitializeComponent();
        }

        string s;
        StreamReader r;
        StreamWriter w;
        string[] res = new string [0];

        private bool check (string str)
        {
            char[] let = str.ToCharArray();
            int end_index = str.IndexOf(';');

            lb_res.Items.Add("Працюємо з рядком:\t" + str);

            if (str == "")
            {
                lb_res.Items.Add("Ряок пустий");
                return false;
            }

            if (str.IndexOf(';') > 7)
            {
                lb_res.Items.Add("Помилка кількості букв в слові");
                return false;
            }

            if (s.IndexOf(';') == 0)
            {
                lb_res.Items.Add("; не може бути в початку рядку");
                return false;
            }

            if (s.IndexOf('.') != let.Length - 1)
            {
                lb_res.Items.Add("Нема крапки в кінці, або крапка є в середині рядку");
                return false;
            }

            for (int i = 0; i < let.Length - 1; i++)
            {
                if (let[i] >= 'a' && let[i] <= 'z' || let[i] == ';' || let[i] == '.')
                {
                    if (let[i] == ';' || let[i] == '.')
                    {
                        if (i != end_index)
                        {
                            if (i - end_index - 1 <= 8 && i - end_index - 1 > 0)
                            {
                                end_index = i;
                            }
                            else
                            {
                                lb_res.Items.Add("Помилка кількості букв в слові");
                                return false;
                            }
                        }
                    }
                }

                else
                {
                    lb_res.Items.Add("Можна вводити лише маленькі букви англійського алфавіту");
                    return false;
                }

            }
            return true;


        } //перевірка чи намальний рядок
        private void new_string(ref string str)
        {
            char[] let = str.ToCharArray();

            for (int i = 0; i < let.Length - 1; i++)
            {
                if (let[i] == let[i + 1])
                {
                    str.CopyTo(i + 1, let, i, (let.Length - i - 1)); //
                    Array.Resize(ref let, let.Length - 1);

                    str = new string(let);
                    let = str.ToCharArray();

                    i--;
                }
            }

        } // прибира букви, що повторюються підряд


        private void відкритиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Відкритий файл з іменем:\r\n" + openFileDialog1.FileName);

                r = new StreamReader(openFileDialog1.FileName); //Створюємо потік і зв'язуємо з конкретним файлом

                результатToolStripMenuItem.Enabled = true;

            }
        }
        private void результатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] textMas;

            while ((s = r.ReadLine()) != null )
            {
                if (check(s) == true)
                {
                    new_string(ref s);

                    s = s.Remove(s.Length - 1);
                    textMas = s.Split(new char[] { ';' });

                    foreach (var word in textMas)
                    {
                        lb_res.Items.Add(word);

                    }

                    Array.Resize(ref res, res.Length + textMas.Length);
                    Array.Copy(textMas, 0, res, res.Length - textMas.Length, textMas.Length);
                };
                
            }

            lb_res.Items.Add("  ------------------- \t");
            lb_res.Items.Add("Всі виділені слова:");
            foreach (var word in res)
            {
                lb_res.Items.Add(word);

            }

        }
        private void зверегтиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Збереження у файл з іменем:\r\n" +saveFileDialog1.FileName);

                w = new StreamWriter(saveFileDialog1.FileName);

                foreach (var word in res)
                {
                    w.WriteLine(word);
                }

                r.Close(); //закриття потоку
                w.Close();
            }



        }
        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }


}//h