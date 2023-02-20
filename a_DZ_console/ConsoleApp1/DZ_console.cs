
	double x, n, e, s2 = 0, s1 = 0, ch, zn, slug=0;
	double C;
	int i, k;

	do
	{
		Console.WriteLine("x = ");
		x = double.Parse(Console.ReadLine());
	} while (!(x > 0 && x < 1));


	do
	{

	Console.WriteLine("n = ");
	n = double.Parse(Console.ReadLine());
} while (n < 0);

	do
	{

		Console.WriteLine("e = ");
		e = double.Parse(Console.ReadLine());
	} while (!(e > 0 && e < 1));


 	 ch = x;
     zn = 1 * 2 * 3;
	 i = 2;

	s2 = func2(x, e, ch, zn, s2, i);

	ch = x;
	zn = 1 * 2 * 3;

	int count = 0;
	s1 = func1(x, n, count, ch, zn, s1, i);


	Console.WriteLine("s1 = " + s1.ToString());
	Console.WriteLine("s2 = " + s2.ToString());



	C = (x - Math.Sin(x)) / (x * x);
	Console.WriteLine("C =  " + C.ToString());



static double func2(double y, double toch, double chis, double znam, double sum, int j)
{
	double sl = chis / znam;

	if (Math.Abs(sl) >= toch)
    {
		sum += sl;
		return func2(y,  toch,  chis = -chis * y * y, znam = znam * (2 * j) * (2 * j + 1),  sum, j += 1) ;
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

