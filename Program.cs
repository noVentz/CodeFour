using System;

namespace CodeFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t Введите вашу кликуху");
            string name = Console.ReadLine();
            Console.WriteLine("А теперь сколько тебе годиков?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Короче, твоё погоняло {name} и сейчас тебе уже {age}");
        }
    }
}
