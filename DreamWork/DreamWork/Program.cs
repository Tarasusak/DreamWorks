using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWork
{
    class Human
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public int Age { set; get; }

        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    class Worker : Human
    {
        public int Experience { set; get; }
        public string Date { set; get; }
        public int Category { set; get; }

        public Worker(string name, string surname, int age, int experience, string date, int category) : base(name, surname, age)
        {
            Experience = experience;
            Date = date;
            Category = category;
        }
    }
    class Program
    {

        static Worker[] ReadWorker()
        {
            string name, surname, date;
            int age, experience, category;


            Console.WriteLine("Введiть кiлькiсть працiвникiв: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Worker[] workers = new Worker[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Працiвник №{i + 1}");
                Console.WriteLine("Введiть iмя працiвникa: ");
                name = Console.ReadLine();

                Console.WriteLine("Введiть прiзвище працiвника");
                surname = Console.ReadLine();

                Console.WriteLine("Введiть вiк працiвника: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введiть стаж працiвника: (в роках) ");
                experience = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введiть дату прийняття працiвника: (у форматi DD.MM.YY)");
                date = Console.ReadLine();

                Console.WriteLine("Введiть Категорію працiвника: ");
                category = Convert.ToInt32(Console.ReadLine());



                workers[i] = new Worker(name, surname, age, experience, date, category);
            }
            return workers;
        }

        static void PrintWorker(Worker[] w)
        {
            for (int i = 0; i < w.Count(); i++)
            {
                Console.WriteLine($"Працiвник №{i + 1}");
                Console.WriteLine($"Iмя: {w[i].Name}");
                Console.WriteLine($"Прiзвище: {w[i].Surname}");
                Console.WriteLine($"Вiк: {w[i].Age}");
                Console.WriteLine($"Стаж: {w[i].Experience}");
                Console.WriteLine($"Дата прийняття:  {w[i].Date}");
                Console.WriteLine($"Розряд: {w[i].Category}");

            }
        }

        static void Main(string[] args)
        {
            Worker[] w = ReadWorker();
            PrintWorker(w);
            Console.ReadKey();
        }
    }
}
