using System.Numerics;

namespace zadanie1
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
            Console.WriteLine($"Vector2D: {Name}");
            Console.WriteLine($"Components: X = {X}, Y = {Y}");
            Console.WriteLine($"Length: {Length():F2}");
            Console.WriteLine(new string('-', 30));
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
            Console.WriteLine($"Vector3D: {Name}");
            Console.WriteLine($"Components: X = {X}, Y = {Y}, Z = {Z}");
            Console.WriteLine($"Length: {Length():F2}");
            Console.WriteLine(new string('-', 30));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectors = new List<Vector>();

            vectors.Add(new Vector2D("Vec2D_1", 3, 4));
            vectors.Add(new Vector2D("Vec2D_2", 5, 12));
            vectors.Add(new Vector3D("Vec3D_1", 1, 2, 2));
            vectors.Add(new Vector3D("Vec3D_2", 7, 24, 18));
            vectors.Add(new Vector2D("Vec2D_3", 8, 15));

            foreach (var vector in vectors)
            {
                vector.Display();
            }
        }
    }
}
