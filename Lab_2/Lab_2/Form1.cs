using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_2
{
    public partial class Lab2 : Form
    {
        string s;
        double a,b,c,d,res;


        public Lab2()
        {
            InitializeComponent();
        }

        private void tbres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tbd.Text;
                d = Convert.ToDouble(s);
            }
            catch (FormatException exc)
            {
                MessageBox.Show( "Введіть число, а не букву", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            }   
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (rbwith.Checked)
            {
                try
                {
                    if (a == 0 | b == 0 | ((c / a) + d + 1) == 0)
                        throw new DivideByZeroException("Ділення на нуль");

                    res = (2 * c + ((Math.Tan(a - 21)) / b)) / ((c / a) + d + 1);

                    tbres.Text = Convert.ToString(res);
                    tbres.Visible = true;
                    lblres.Visible = true;
                    exit.Focus();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка" , MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    tbres.Visible = false;
                    lblres.Visible = false;
                    exit.Focus();
                }
                finally
                {
                    MessageBox.Show("Готово", "Обчислення завершено", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                
                
               
            }
            if (rbwithout.Checked)
            {
                res = (2 * c + ((Math.Tan(a - 21)) / b)) / ((c / a) + d + 1);
                tbres.Text = Convert.ToString(res);
                tbres.Visible = true;
                lblres.Visible = true;
                exit.Focus();
            }
        }

        private void tba_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tba.Text;
                a = Convert.ToDouble(s);
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

        private void tbb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tbb.Text;
                b = Convert.ToDouble(s);
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

        private void tbc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tbc.Text;
                c = Convert.ToDouble(s);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Введіть число, а не букву", "Помилка",  MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
    }
