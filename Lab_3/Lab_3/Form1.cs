namespace Lab_3
{
    public partial class Vitalii_Palochkin_611p : Form
    {

        string s;
        int roz, dob;
        int[] a;


        public Vitalii_Palochkin_611p()
        {
            InitializeComponent();
        }

        static void RandArray(int[] Mas)
        {
            Random m = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = m.Next(-Mas.Length, Mas.Length+1);
            }
                
        }
        int Dobutok(int[] Mas, int d)
        {
            d=1;
            for (int i = 0; i < Mas.Length; i++)
            {
                if(Mas[i] > 0)
                d *= Mas[i];
            }
            return d;
        }

        static void Newmas(ref int[] Mas)
        {

            for (int i = 0; i < Mas.Length; i++)
             {
                if (Mas[i] > 0)
                {
                    Array.Resize(ref Mas, Mas.Length + 1);

                    for (int j = Mas.Length - 1; j > i; j--)
                    {
                        Mas[j] = Mas[j - 1];
                    }
                    i++;
                }

            }

        }

        private void tb_roz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tb_roz.Text;
                roz = Convert.ToInt32(s);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Введіть число, а не букву", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            }
        }

        void Outputmas(int[] Mas, ListBox lb)
        {

            lb.Items.Clear();
            for (int i = 0; i < Mas.Length; i++)
            {
                lb.Items.Add(Mas[i].ToString());
            }
        }



        private void result_Click(object sender, EventArgs e)
        {
            tb_dob.Text = Convert.ToString(Dobutok(a, dob));

            Newmas(ref a);

            Outputmas(a, lb_res);

            lb_res.Visible = true;
            lbl_res.Visible = true;
            tb_dob.Visible = true;
            lbl_dob.Visible = true;
            result.Visible = false;

        }

        private void formuv_Click(object sender, EventArgs e)
        {

            if (roz <= 0)
            {
                MessageBox.Show("Розмір повинен бути більше 0", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                a = new int[roz];
                RandArray(a);

                Outputmas(a, lb_poch);

                lb_poch.Visible = true;
                lbl_poch.Visible = true;
                result.Visible = true;
                lb_res.Visible = false;
                lbl_res.Visible = false;
                tb_dob.Visible = false;
                lbl_dob.Visible = false;

            }

        }
    }
}