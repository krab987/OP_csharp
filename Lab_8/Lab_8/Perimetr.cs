namespace Lab_8
{

    //����, �� ������� �������� ��������
    public class kvadrat
    {
        double _a;
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        public kvadrat(double a)
        {
            _a = a;
        }
        public override string ToString()
        {
            return "������� � ��������: " + "a = " + _a.ToString();
        }
        public virtual double P()
        {
            return (4 * A);
        }

    }
    //����, �� ������� �������� ����������
    public class trikutnik : kvadrat
    {
        double _b;
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }

        }
        double _c;
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }

        }

        public trikutnik(double a, double b, double c)
            : base(a)
        {
            _b = b;
            _c = c;
        }
        public override string ToString()
        {
            return "��������� � ���������: \n" + "a = " + A.ToString() + " " + "b = " + _b.ToString() + " " + "c = " + _c.ToString();
        }
        public override double P()
        {
            return A + B + C;
        }

    }

}

