namespace Lab_8
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            try
            {

                lb_res.Visible = true;
                lbl_res.Visible = true;

                kvadrat[] M = new kvadrat[0];

                string s = tb_a.Text;
                int a = Convert.ToInt32(s);
                if (a <= 0)
                {
                    throw new Exception("Числа мають бути > 0");
                }

                //периметр квадрата
                //lb_res.Items.Add("Периметр квадрата зі стороною");
                if (rb_kv.Checked == true)
                {

                    kvadrat TL = new kvadrat(a);
                    Array.Resize(ref M, M.Length + 1);
                    M[M.Length - 1] = TL;

                }
                if (rb_trik.Checked == true)
                {
                    string s2 = tb_b.Text;
                    int b = Convert.ToInt32(s2);
                    string s3 = tb_c.Text;
                    int c = Convert.ToInt32(s3);
                    if (b <= 0 || c <= 0)
                    {
                        throw new Exception("Числа мають бути > 0");
                    }


                    //периметр трикутника
                    //lb_res.Items.Add("Периметр трикутника зі сторонами");
                    Array.Resize(ref M, M.Length + 1);
                    trikutnik TLL = new trikutnik(a, b, c);
                    M[M.Length - 1] = TLL;

                }
                

                foreach (kvadrat el in M)
                {
                    lb_res.Items.Add(el.ToString());
                    lb_res.Items.Add("P = " + el.P().ToString());
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Помилка формату", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (SystemException)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }


        }

        private void rb_kv_CheckedChanged(object sender, EventArgs e)
        {
            lbl_a.Visible = true;
            tb_a.Visible = true;
            lbl_b.Visible = false;
            tb_b.Visible = false;
            lbl_c.Visible = false;
            tb_c.Visible = false;

        }

        private void rb_trik_CheckedChanged(object sender, EventArgs e)
        {
            lbl_a.Visible = true;
            tb_a.Visible = true;
            lbl_b.Visible = true;
            tb_b.Visible = true;
            lbl_c.Visible = true;
            tb_c.Visible = true;
        }

        private void ClearLB_Click(object sender, EventArgs e)
        {
            lb_res.Items.Clear();
        }
    }
}