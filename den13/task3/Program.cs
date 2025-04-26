namespace task3
{
    internal class Program
    {
        delegate void StringOperation(string str);

        static void ToUpperCase(string str)
        {
            Console.WriteLine("Верхний регистр: " + str.ToUpper());
        }

        static void ToLowerCase(string str)
        {
            Console.WriteLine("Нижний регистр: " + str.ToLower());
        }

        static void GetLength(string str)
        {
            Console.WriteLine("Длина строки: " + str.Length);
        }

        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine()!;

            StringOperation operation;

            operation = ToUpperCase;
            operation(input);

            operation = ToLowerCase;
            operation(input);

            operation = GetLength;
            operation(input);
        }
    }

}
