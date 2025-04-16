using System.Xml.Linq;

namespace zadanie2
{
    class Trial
    {
        public string Name { get; set; }
        public Trial(string name)
        {
            Name = name;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Испытание: {Name}");
        }
        class Test : Trial
    {
        public int MaxScore { get; set; }
        public Test(string name, int maxScore)
                : base (name)
            {
                MaxScore = maxScore;
            }
        public override void ShowInfo()
        {
            Console.WriteLine($"Тест: {Name}, максимальный балл {MaxScore}");
        }
    }


    class Exam : Test
    {
        public string Subject { get; set; }

        public Exam(string name, int maxScore, string subject)
            : base(name,  maxScore)
        {
            Subject = subject;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Экзамен: {Name}, Предмет: {Subject}, Максимальный балл: {MaxScore}");
        }
    }

    class FinalExam : Exam
    {
        public string Institution { get; set; }

        public FinalExam(string name, int maxScore, string subject, string institution)
            : base(name, maxScore, subject)
        {
            Institution = institution;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Выпускной экзамен: {Name}, Учебное заведение: {Institution}, Предмет: {Subject}, Максимальный балл: {MaxScore}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Trial trial = new Trial("Проверка знаний");
                Test test = new Test("Тест по истории", 50);
                Exam exam = new Exam("Экзамен по математике", 100, "Математика");
                FinalExam finalExam = new FinalExam("Государственный выпускной экзамен", 150, "Физика", "Университет");

                trial.ShowInfo();
                test.ShowInfo();
                exam.ShowInfo();
                finalExam.ShowInfo();
            }
    }
}
    }
