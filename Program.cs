using System;
namespace task2
{
    abstract class Worker
    {
        public string name, position, work_day = "";
        public Worker(string n)
        {
            name = n;
        }
        public string call()
        {
            string x = "calling, ";
            return x;
        }
        public string write_code()
        {
            string x = "writing code, ";
            return x;
        }
        public string relax()
        {
            string x = "relaxing, ";
            return x;
        }
        public abstract void fill_work_day();
    }
    class Developer : Worker
    {
        public Developer(string n) : base(n)
        {
            position = "developer";
        }
        public override void fill_work_day()
        {
            work_day += write_code();
            work_day += call();
            work_day += relax();
            work_day += write_code();
            work_day = work_day.Substring(0, work_day.Length - 2);
        }
    }
    class Manager : Worker
    {
        private Random rnd;
        public Manager(string n) : base(n)
        {
            rnd = new Random();
            position = "manager";
        }
        public override void fill_work_day()
        {
            int x = rnd.Next(1, 11);
            for (int i = 0; i < x; i++)
            {
                work_day += call();
            }
            work_day += relax();
            x = rnd.Next(1, 6);
            for (int i = 0; i < x; i++)
            {
                work_day += call();
            }
            work_day = work_day.Substring(0, work_day.Length - 2);
        }
    }
    class Team
    {
        private string team_name;
        private Worker[] list;
        private int index;
        public Team(string name)
        {
            team_name = name;
            list = new Worker[100];
            index = 0;
        }
        public void add_worker(Worker person)
        {
            list[index] = person;
            index++;
        }
        public void get_info()
        {
            Console.WriteLine("Team " + team_name);
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(list[i].name);
            }
            Console.WriteLine();
        }
        public void get_more_info()
        {
            Console.WriteLine("Team " + team_name);
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(list[i].name + " - " + list[i].position + " - " + list[i].work_day);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer("ivanov ivan ivanovich");
            Developer dev2 = new Developer("olegov oleg olegovich");
            Developer dev3 = new Developer("sergeev sergey sergeevich");
            Manager mng1 = new Manager("petrov petr petrovich");
            Manager mng2 = new Manager("igorev igor igorevich");
            Team team = new Team("Alpha");

            dev1.fill_work_day();
            dev2.fill_work_day();
            dev3.fill_work_day();
            mng1.fill_work_day();
            mng2.fill_work_day();

            team.add_worker(dev1);
            team.add_worker(dev3);
            team.add_worker(mng2);

            team.get_info();
            team.get_more_info();

            team.add_worker(dev2);
            team.add_worker(mng1);

            team.get_info();
            team.get_more_info();
        }
    }
}