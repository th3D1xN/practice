namespace task1
{
    internal class Program
    {
        delegate double CalcFigure(double R);

        static double Get_Length(double R)
        {
            return 2 * Math.PI * R;
        }

        static double Get_Area(double R)
        {
            return Math.PI * R * R;
        }

        static double Get_Volume(double R)
        {
            return (4.0 / 3.0) * Math.PI * R * R * R;
        }

        static void Main()
        {
            double radius = 5.0;

            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine($"Длина окружности радиуса {radius}: {CF(radius)}");

            CF = Get_Area;
            Console.WriteLine($"Площадь круга радиуса {radius}: {CF(radius)}");

            CF = Get_Volume;
            Console.WriteLine($"Объем шара радиуса {radius}: {CF(radius)}");
        }
    }

}
