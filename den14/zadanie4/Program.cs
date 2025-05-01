namespace zadanie4
{
    class EventPublisher
    {
        public delegate void Notify();

        public event Notify OnChange;

        public void RaiseEvent()
        {
            Console.WriteLine("=> Событие генерируется в EventPublisher.");
            OnChange?.Invoke();
        }
    }

    class ObserverOne
    {
        public void ReactionOne()
        {
            Console.WriteLine("ObserverOne: Реакция 1 на событие.");
        }

        public void ReactionTwo()
        {
            Console.WriteLine("ObserverOne: Реакция 2 на событие.");
        }
    }

    class ObserverTwo
    {
        public void React()
        {
            Console.WriteLine("ObserverTwo: Своя реакция на событие.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();

            ObserverOne observer1 = new ObserverOne();
            ObserverTwo observer2 = new ObserverTwo();

            publisher.OnChange += observer1.ReactionOne;
            publisher.OnChange += observer1.ReactionTwo;
            publisher.OnChange += observer2.React;

            Console.WriteLine("== Первый вызов события с 3 обработчиками ==");
            publisher.RaiseEvent();

            publisher.OnChange -= observer1.ReactionTwo;

            Console.WriteLine("\n== Второй вызов события после удаления одного обработчика ==");
            publisher.RaiseEvent();
        }
    }
}
