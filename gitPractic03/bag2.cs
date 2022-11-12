﻿using System;

namespace GitPractise

{
    class Task2
    {
        public static void GetInput()
        {
            string[] inputText = File.ReadAllLines("countrys.txt");

            List<string> Europa = new List<string>();
            List<string> Asia = new List<string>();
            List<string> Africa = new List<string>();
            List<string> Australia = new List<string>();
            List<string> SA = new List<string>();
            List<string> NA = new List<string>();

            foreach(string a in inputText)
            {
                if (a.Contains("Европа")) Europa.Add(a);
                if (a.Contains("Азия")) Asia.Add(a);
                if (a.Contains("Африка")) Africa.Add(a);
                if (a.Contains("Австралия")) Australia.Add(a);
                if (a.Contains("Южная Америка")) SA.Add(a);
                if (a.Contains("Северная Америка")) NA.Add(a);
            }

            Console.WriteLine("Введите номер выбранного вами континента");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int continent) || !(continent >= 1 && continent <= 6))
            {
                Console.WriteLine("Пожалуйста, выберите континент из списка предложенных");
                GetInput();
            }

            switch (continent)
            {
                case 1:
                    Europa.Sort(new MyComparer());
                    foreach (string a in Europa)
                        Console.WriteLine(a);
                    break;
                case 2:
                    Asia.Sort(new MyComparer());
                    foreach (string a in Asia)
                        Console.WriteLine(a);
                    break;
                case 3:
                    Africa.Sort(new MyComparer());
                    foreach (string a in Africa)
                        Console.WriteLine(a);
                    break;
                case 4:
                    Australia.Sort(new MyComparer());
                    foreach (string a in Australia)
                        Console.WriteLine(a);
                    break;
                case 5:
                    SA.Sort(new MyComparer());
                    foreach (string a in SA)
                        Console.WriteLine(a);
                    break;
                case 6:
                    NA.Sort(new MyComparer());
                    foreach (string a in NA)
                        Console.WriteLine(a);
                    break;
                default:
                    break;
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1.Европа");
            Console.WriteLine("2.Азия");
            Console.WriteLine("3.Африка");
            Console.WriteLine("4.Австралия");
            Console.WriteLine("5.Южная Америка");
            Console.WriteLine("6.Северная Америка");
        }
    }

    class MyComparer:IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            x = x.Split(';')[3];
            y = y.Split(';')[3];
            int a = int.Parse(x);
            int b = int.Parse(y);
            return a.CompareTo(b);
        }
    }
}