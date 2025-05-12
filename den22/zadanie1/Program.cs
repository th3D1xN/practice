namespace zadanie1
{
    public interface IDeliveryStrategy
    {
        double CalculateCost(double distance);
    }

    public class CourierDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double distance)
        {
            return 5.0 + distance * 1.2;
        }
    }

    public class PostDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double distance)
        {
            return 3.0 + distance * 0.8;
        }
    }

    public class DroneDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double distance)
        {
            return 10.0 + distance * 2.0;
        }
    }

    public class DeliveryContext
    {
        private IDeliveryStrategy _strategy;

        public DeliveryContext(IDeliveryStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IDeliveryStrategy strategy)
        {
            _strategy = strategy;
        }

        public double GetDeliveryCost(double distance)
        {
            return _strategy.CalculateCost(distance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10.0;

            DeliveryContext context = new DeliveryContext(new CourierDelivery());
            Console.WriteLine($"Стоимость доставки курьером на {distance} км: {context.GetDeliveryCost(distance)} руб.");

            context.SetStrategy(new PostDelivery());
            Console.WriteLine($"Стоимость доставки почтой на {distance} км: {context.GetDeliveryCost(distance)} руб.");

            context.SetStrategy(new DroneDelivery());
            Console.WriteLine($"Стоимость доставки дроном на {distance} км: {context.GetDeliveryCost(distance)} руб.");
        }
    }
}
