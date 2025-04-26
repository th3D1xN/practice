using System.Numerics;

namespace zadanie2
{

    abstract class Vector
    {
        protected string Name;

        public Vector(string name)
        {
            Name = name;
        }

        public abstract double Length();
        public abstract void Display();
    }

    class Vector2D : Vector
    {
        private double X, Y;

        public Vector2D(string name, double x, double y) : base(name)
        {
            X = x;
            Y = y;
        }

        public override double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public override void Display()
        {
            Console.WriteLine($"[Vector2D] {Name}: X = {X}, Y = {Y}, Length = {Length():F2}");
        }
    }

    class Vector3D : Vector
    {
        private double X, Y, Z;

        public Vector3D(string name, double x, double y, double z) : base(name)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override void Display()
        {
            Console.WriteLine($"[Vector3D] {Name}: X = {X}, Y = {Y}, Z = {Z}, Length = {Length():F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[5];

            vectors[0] = new Vector2D("Vec2D_1", 3, 4);
            vectors[1] = new Vector3D("Vec3D_1", 1, 2, 2);
            vectors[2] = new Vector2D("Vec2D_2", 5, 12);
            vectors[3] = new Vector3D("Vec3D_2", 7, 24, 18);
            vectors[4] = new Vector2D("Vec2D_3", 8, 15);

            double totalLength = 0;

            Console.WriteLine("=== Список всех векторов ===\n");

            foreach (var vector in vectors)
            {
                vector.Display();
                totalLength += vector.Length();
            }

            Console.WriteLine("\n=== Итог ===");
            Console.WriteLine($"Суммарная длина всех векторов: {totalLength:F2}");
        }
    }
}
