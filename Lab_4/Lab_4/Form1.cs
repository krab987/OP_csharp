namespace Lab_4
{
    public partial class Lab_4 : Form
    {
        public Lab_4()
        {
            InitializeComponent();
        }

        string s;
        int[][] a;
        

        //functions
        static void Formuv(ref int[][] Mas)
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j <= Mas.Length-1; j++)
                {

                    if (j <= i && j <= Mas.Length-1-i)
                    {
                        Mas[i][j] = 1;
                    }
                    else if (j >= i && j >= Mas.Length - 1 - i)
                    {
                        Mas[i][j] = 1;
                    }
                    else
                    {
                        Mas[i][j] = 0;  
                    }
                }    
            }     
        }
        static void Output_matrix(int[][] Mas, DataGridView dgv)
        {
            //��������� ����������� ������� ��������� � ������
            int max_col = Mas[0].Length;
            for (int i = 0; i < Mas.Length; i++)
                if (Mas[i].Length > max_col)
                    max_col = Mas[i].Length;
            dgv.ColumnCount = 0;

            dgv.ColumnCount = max_col;
            //������� �����
            dgv.Rows.Add(Mas.Length);
            //�������� ��� ���������
            for (int i = 0; i < max_col; i++)
            {
                //����������� �������� �������� ������
                dgv.Columns[i].ReadOnly = true;
                //�������� ����� ���������� �������� ���������
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //��������� ���������
                dgv.Columns[i].Name = i.ToString();
                dgv.Columns[i].Width = 25;//������ ���������
            }

            //����������� ������� �������� �������
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas[i].Length; j++)
                {
                    dgv.Rows[i].Cells[j].Value = Mas[i][j].ToString();
                }    
            }

            dgv.Visible = true;
        }
        static void Delete_elements(ref int[][] Mas) 
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas[i].Length; j++)
                {
                    if (i % 2 == 0 && Mas[i][j] == 0)
                    {
                        Delete(ref Mas, i, j);//��������� ������ ��������
                        j--;
                    }
                    else if (i % 2 != 0 && Mas[i][j] == 1)
                    {
                        Delete(ref Mas, i, j);//��������� ������ ��������
                        j--;
                    }
                }
            }
                  
        }
        static void Delete(ref int[][] Mas, int g, int t)
        {
            for (int j = t; j < Mas[g].Length - 1; j++)
            {
                Mas[g][j] = Mas[g][j + 1];
            }
            Array.Resize(ref Mas[g], Mas[g].Length - 1);
        }
  
        //end of functions


        private void formuv_Click(object sender, EventArgs e)
        {
            try
            {
                int kol;
                s = tb_kol.Text;
                kol = Convert.ToInt32(s);
                    
                a = new int[kol][];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new int[kol];//�������� ���'�� �� col �������� � ����� row
                }

                Formuv(ref a);
                Output_matrix(a, dgv_formuv);

                result.Visible = true;
                dgv_res.Visible = false;
            
            }
            catch (OverflowException)
            {
                MessageBox.Show("x - ����� ������", "������� ���������:", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("����� �� ��������:", "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������", "�������", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

        }
        private void result_Click(object sender, EventArgs e)
        {

            Delete_elements(ref a);
            Output_matrix(a, dgv_res);

        }
    }
}