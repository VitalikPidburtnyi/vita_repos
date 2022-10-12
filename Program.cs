using System;
namespace Nature
{
    abstract class GeoObject
    {
        protected int x_pos;
        protected int y_pos;
        protected string name;
        protected string description;

        public GeoObject(int x_pos, int y_pos, string name, string description)
        {
            this.x_pos = x_pos;
            this.y_pos = y_pos;
            this.name = name;
            this.description = description;
        }

        public virtual void GetInformation()
        {
            Console.WriteLine($"X: {x_pos}\nY: {y_pos}\nName: {name}\nDescription: {description}");
        }
    }
    class River : GeoObject
    {
        private double flow;
        private int length;

        public River(int x_pos, int y_pos, string name, string description, double flow, int length) : base(x_pos, y_pos, name, description)
        {
            this.flow = flow;
            this.length = length;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Flow: {flow}\nLength: {length}");
        }
    }
    class Mountain : GeoObject
    {
        private int peak;
        public Mountain(int x_pos, int y_pos, string name, string description, int peak) : base(x_pos, y_pos, name, description)
        {
            this.peak = peak;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Peak: {peak}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            River river1 = new River(3, 60, "Amazon", "The longest river in the world", 2, 6992);
            Mountain mountain1 = new Mountain(27, 86, "Everest", "The highest mountain in the world", 8849);

            Console.WriteLine("River:");
            river1.GetInformation();
            Console.WriteLine();

            Console.WriteLine("Mountain:");
            mountain1.GetInformation();

            Console.ReadKey(true);
        }
    }
}