namespace zadanie1
{
    class Bus
    {
        private int passengerCount;
        private double ticketPrice;

        public Bus(int passengerCount, double ticketPrice)
        {
            this.passengerCount = passengerCount;
            this.ticketPrice = ticketPrice;
        }

        public int GetPassengerCount() => passengerCount;
        public double GetTicketPrice() => ticketPrice;

        public virtual void Display()
        {
            Console.WriteLine($"Автобус: пассажиров = {passengerCount}, цена билета = {ticketPrice:F2}");
        }

        public virtual double TotalCost()
        {
            return passengerCount * ticketPrice;
        }
    }

    class ExpressBus : Bus
    {
        private double speed;
        private string brand;

        public ExpressBus(int passengerCount, double ticketPrice, double speed, string brand)
            : base(passengerCount, ticketPrice)
        {
            this.speed = speed;
            this.brand = brand;
        }

        public double GetSpeed() => speed;
        public string GetBrand() => brand;

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Скорость: {speed} км/ч, марка: {brand}");
        }

        public override double TotalCost()
        {
            double adjustedPrice = GetTicketPrice() + 0.05 * speed;
            return GetPassengerCount() * adjustedPrice;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Тест базового класса (Bus)");
            Bus bus = new Bus(30, 50.0);
            bus.Display();
            Console.WriteLine($"Общая стоимость: {bus.TotalCost():F2}\n");

            Console.WriteLine(" Тест производного класса (ExpressBus)");
            ExpressBus express = new ExpressBus(30, 50.0, 80.0, "Mercedes");
            express.Display();
            Console.WriteLine($"Общая стоимость (с учетом скорости): {express.TotalCost():F2}");
        }
    }
}
