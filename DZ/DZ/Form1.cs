namespace DZ
{
    public partial class DZ : Form
    {
        public DZ()
        {
            InitializeComponent();
        }

        string s;
        double x, E, C, S;
        int k;


        private void rb_e_CheckedChanged(object sender, EventArgs e)
        {
            tb_e.Visible = true;
            lbl_e.Visible = true;
            tb_k.Visible = false;
            lbl_k.Visible = false;

        }
        private void rb_k_CheckedChanged(object sender, EventArgs e)
        {
            tb_e.Visible = false;
            lbl_e.Visible = false;
            tb_k.Visible = true;
            lbl_k.Visible = true;
        }


        static double func2(double y, double toch, double chis, double znam, double sum, int j)
        {
            double sl = chis / znam;

            if (Math.Abs(sl) >= toch)
            {
                sum += sl;
                return func2(y, toch, chis = -chis * y * y, znam = znam * (2 * j) * (2 * j + 1), sum, j += 1);
            }

            sum += sl;
            return sum;

        }
        static double func1(double y, double num, int counter, double chis, double znam, double sum, int j)
        {
            double sl = chis / znam;

            if (num >= counter)
            {
                sum += sl;
                return func1(y, num, ++counter, chis = -chis * y * y, znam = znam * (2 * j) * (2 * j + 1), sum, ++j);
            }

            sum += sl;
            return sum;

        }


        private void bttn_Click(object sender, EventArgs e)
        {
            try
            {
                s = tb_x.Text;
                x = Convert.ToDouble(s);
                if (x <= 0 || x >= 1)
                    throw new DivideByZeroException("х є (0;1)");

                double ch = x,
                zn = 1 * 2 * 3;
                int i = 2;

                if (rb_k.Checked)
                {
                    s = tb_k.Text;
                    k = Convert.ToInt32(s);
                    if (k <= 0)
                        throw new DivideByZeroException("k має бути > 0");

                    int count = 0;
                    S = func1(x, k, count, ch, zn, S, i);
                    tb_S.Text = Convert.ToString(S);
                }
                if (rb_e.Checked)
                {
                    s = tb_e.Text;
                    E = Convert.ToDouble(s);
                    if (E <= 0 || E >= 1)
                        throw new DivideByZeroException("e є (0;1)");

                    S = func2(x, E, ch, zn, S, i);
                    tb_S.Text = Convert.ToString(S);
                }

                C = (x - Math.Sin(x)) / (Math.Pow(x, 2));
                tb_C.Text = Convert.ToString(C);

                tb_S.Visible = true;
                tb_C.Visible = true;
                lbl_C.Visible = true;
                lbl_S.Visible = true;

                S = 0;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Помилка обчислень:" + ex.Message, "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Букви не допустимі:", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
}