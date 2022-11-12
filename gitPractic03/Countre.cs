using System;
using System.Text;

namespace GitPractise;

internal class Country
{
    public static void Main()
    {
        Console.WriteLine("Введите номер задания:");
        var task = Convert.ToChar(Console.ReadLine()); 
        switch (task)
        {
            case '1':
                Task1.ShowMenu();
                Task1.GetInput();
                break;
            case '2':
                break;
            case '3':
                break;
            case '4':
                break;
            case '5':
                break;
            case '6':
                break;
        }
    }
}    