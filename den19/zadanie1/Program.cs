namespace zadanie1
{
    internal class Program
    {
        static string ProcessString(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }


            char[] result = stack.ToArray();
            Array.Reverse(result);
            return new string(result);
        }

        static void Main()
        {
            string input = "abc#d##c";
            string output = ProcessString(input);
            Console.WriteLine(output); 
        }
    }
}