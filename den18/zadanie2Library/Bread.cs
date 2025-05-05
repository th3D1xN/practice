using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2Library
{
    public abstract class Bread
    {
        public string Name { get; protected set; }
        public string FlourType { get; protected set; }
        public double Weight { get; protected set; }
        public int BakingTime { get; protected set; }

        public Bread(string name, string flourType, double weight, int bakingTime)
        {
            Name = name;
            FlourType = flourType;
            Weight = weight;
            BakingTime = bakingTime;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} ({FlourType} мука, {Weight} г) - Время выпечки: {BakingTime} минут.");
        }

        public bool IsFresh(DateTime bakedDate)
        {
            return (DateTime.Now - bakedDate).TotalHours < 24;
        }
    }
}
