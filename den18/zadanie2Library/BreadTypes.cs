using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2Library
{
    public class Baguette : Bread
    {
        public Baguette() : base("Багет", "Пшеничная", 250, 20) { }
    }

    public class RyeBread : Bread
    {
        public RyeBread() : base("Ржаной хлеб", "Ржаная", 500, 30) { }
    }

    public class WhiteBread : Bread
    {
        public WhiteBread() : base("Белый хлеб", "Пшеничная", 400, 25) { }
    }

    public class Loaf : Bread
    {
        public Loaf() : base("Батон", "Пшеничная", 350, 22) { }
    }
}
