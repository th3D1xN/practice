namespace zadanie3
{
    internal class Program
    {
        static void genException()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());

            int f = 1;

            try 
            {
                for (double i = a; i <= b; ++i)
                {
                    try 
                    {
                        f = checked((int)(f * i));

                        if (Math.Abs(f - 1) < 0.000001)
                        {
                            throw new DivideByZeroException("f - 1 слишком близко к нулю");
                        }

                        Console.WriteLine("y({0}) = {1:f6}", i, 100 / (f - 1));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("y({0}) = Деление на 0 ({1})", i, ex.Message);
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ERROR");
                throw; 
            }
        }
        static void Main(string[] args)
        {
            try
            {
                genException();
            }
            catch
            {
                Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
            }
        }
    }
}
