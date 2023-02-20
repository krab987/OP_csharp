using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        string s;
        int a;
        double d;
        double c;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tbA.Text;
                a = Convert.ToInt32(s);
            }
            catch(FormatException exc)
            {
                MessageBox.Show("Введіть число, а не букву");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Помилка");
            }

        }

        private void tbD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s = tbD.Text;
                d = Convert.ToDouble(s);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Введіть число, а не букву");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Помилка");
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            c = 4 * d - a;
            tbC.Text = Convert.ToString(c);
            tbC.Visible = true;
            lblC.Visible = true;
            exit.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
