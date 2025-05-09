/// <summary>
/// Пространство имен, содержащее программу Task3.
/// </summary>
namespace task3
{
    /// <summary>
    /// Основной класс программы Task3.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Делегат для выполнения операций над строками.
        /// </summary>
        delegate void StringOperation(string str);

        /// <summary>
        /// Преобразует строку в верхний регистр и выводит результат.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        static void ToUpperCase(string str)
        {
            Console.WriteLine("Верхний регистр: " + str.ToUpper());
        }

        /// <summary>
        /// Преобразует строку в нижний регистр и выводит результат.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        static void ToLowerCase(string str)
        {
            Console.WriteLine("Нижний регистр: " + str.ToLower());
        }

        /// <summary>
        /// Определяет длину строки и выводит результат.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        static void GetLength(string str)
        {
            Console.WriteLine("Длина строки: " + str.Length);
        }

        /// <summary>
        /// Главный метод программы. Запрашивает у пользователя строку и выполняет операции.
        /// </summary>
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
