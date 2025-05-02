namespace zadanie1
{
    internal class Program
    {
        static AutoResetEvent event1 = new AutoResetEvent(true);  
        static AutoResetEvent event2 = new AutoResetEvent(false);
        static AutoResetEvent event3 = new AutoResetEvent(false);  
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintNumbers0to9)
            {
                Priority = ThreadPriority.AboveNormal
            };

            Thread t2 = new Thread(PrintNumbers10to19)
            {
                Priority = ThreadPriority.Normal
            };

            Thread t3 = new Thread(PrintNumbers20to29)
            {
                Priority = ThreadPriority.BelowNormal
            };

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Все потоки завершены");
        }

        static void PrintNumbers0to9()
        {
            for (int i = 0; i <= 9; i++)
            {
                event1.WaitOne();              
                Console.WriteLine($"[T1] {i}");
                Thread.Sleep(100);            
                event2.Set();        
            }
        }

        static void PrintNumbers10to19()
        {
            for (int i = 10; i <= 19; i++)
            {
                event2.WaitOne();             
                Console.WriteLine($"[T2] {i}");
                Thread.Sleep(100);
                event3.Set();   
            }
        }

        static void PrintNumbers20to29()
        {
            for (int i = 20; i <= 29; i++)
            {
                event3.WaitOne();       
                Console.WriteLine($"[T3] {i}");
                Thread.Sleep(100);
                event1.Set();       
            }
        }
    }
}
