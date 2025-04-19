namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = 1;
            byte i;

            try
            {
                for (i = 1; i < 10; i++) n *= i;
                Console.WriteLine("1: {0}", n);

                checked 
                {
                    n = 1;
                    for (i = 1; i < 10; i++) n *= i;
                    Console.WriteLine("2: {0}", n);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }
        }
    }
}
//без unchecked первая часть тоже стала проверяемой по умолчанию (в зависимости от компилятора или флагов проекта).
//В результате переполнение произойдёт уже в первой части, и программа сразу перейдёт в catch, не дойдя до второй части.