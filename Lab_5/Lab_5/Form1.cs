using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Lab_5 : Form
    {
        public Lab_5()
        {
            InitializeComponent();
        }

        string s;


        static int find_glas(string str)
        {
            int count=0;
            char[] glas = {'a' , 'e', 'i', 'o', 'u', 'y'};

            foreach (char s in str)
            {
                for(int i = 0; i < glas.Length; i++)
                {
                    if (glas[i] == s)
                    {
                        count++;
                    }   
                }    
               
            }
            return count;
        }
        static int find_prig(string str)
        {
            int count = 0, count_prig=0;
            char[] glas = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (char s in str)
            {
                for (int i = 0; i < glas.Length; i++)
                {
                    if (glas[i] != s)
                    {
                        count++;
                    }
                }
                if (count == 6)
                {
                    count_prig++;
                    count = 0;
                }
                else
                {
                    count = 0;
                }

            }
            return count_prig;
        }

        private void new_string(ref string str) //����-�����
        {
            char[] let = str.ToCharArray();

            for (int i = 0; i < let.Length - 1; i++)
            {
                if (let[i] == let[i + 1])
                {
                    str.CopyTo(i+1, let, i, (let.Length - i - 1)); //
                    Array.Resize(ref let, let.Length - 1);

                    str = new string(let);
                    let = str.ToCharArray();
                    
                    i--;
                }
            }

        }

        private void tb_vvod_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            string sr = (sender as TextBox).Text;

            int last = sr.IndexOf(';');  

            
            if (e.KeyChar == '.') //&& s.IndexOf('.') != -1)
            {
                if(sr.Length - last <= 1)
                {
                    e.KeyChar = '\0';
                    return;
                }

                (sender as TextBox).Text += e.KeyChar;
                (sender as TextBox).ReadOnly = true;
                return;
            }

            if ( e.KeyChar == ';')
            {
                if (sr.Length - last <= 1)
                {
                    e.KeyChar = '\0';
                    return;
                }

                return;
            }
            
            if(e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                if (sr.Length - last > 8)
                {
                    e.KeyChar = '\0';
                    return;
                }
                return;
            }
            else
            {
                e.KeyChar = '\0';
            }

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = tb_vvod.Text;

            if (tb_vvod.ReadOnly == true)
            {
                tb_vvod.ReadOnly = true;
                lbl_res.Visible = true;
                lb_res.Visible = true;
            }
            else
            {
                MessageBox.Show("�������� ������ � ����");
            }
            

            new_string(ref s);

            lb_res.Items.Clear();

            lb_res.Items.Add("�����, �� ������������: \n" + s);
            
            lb_res.Items.Add("�����, �� ������: " );

            s = s.Remove(s.Length - 1);
            string[] textMas = s.Split(new char[] { ';'});
            

            foreach (var s in textMas)
            {
                lb_res.Items.Add(s);
            }

            lb_res.Items.Add("ʳ������ ���: " + (textMas.Length).ToString());
            lb_res.Items.Add("���������� ���: ");

            foreach (var s in textMas)
            {
                lb_res.Items.Add("� ���� " + s +" �������� - "+ find_glas(s) + ", � ����������� - " + find_prig(s));
                if (find_glas(s) > find_prig(s))
                {
                    lb_res.Items.Add("�������� �����");
                }
                else if (find_glas(s) < find_prig(s))
                {
                    lb_res.Items.Add("����������� �����");
                }
                else
                {
                    lb_res.Items.Add("����������� �� �������� �������� �������");
                }
            }

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_vvod.Clear();

            lbl_vvod.Visible= true;
            tb_vvod.Visible = true;
            tb_vvod.ReadOnly = false;
            lbl_res.Visible = false;
            lb_res.Visible = false ;

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}