using System;

namespace Laba6._1
{
    public class Program
    {
        public static void Main()
        {
            MyDictionary<string, string> a = new MyDictionary<string, string>();
            a.Add("Tea", "Чай");
            a.Add("Green","Зелений");
            a.Add("Flowers", "Квіти");
            a.Add("Glasses", "Окуляри");
            a.PrintList();

            Console.WriteLine("Загалом: " + a.GetLengthK());
        }



    }
}