using System;

namespace Lab2_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Converter conv = new Converter(38.20, 39.30, 0.83);
            Converter1 conv1 = new Converter1(0.032, 0.032, 5.71);


            Console.WriteLine("Chose te operation");
            Console.WriteLine("1. Uah to other currency");
            Console.WriteLine("2. From other currency to uah");

            int vol2 = Convert.ToInt32(Console.ReadLine());
            switch (vol2)
            {
                case 1:
                    conv.Print();
                    break;
                case 2:
                    conv1.Print();
                    break;
            }
            Console.ReadKey();
        }
    }

    class Converter1
    {
        private double uah { get; set; }
        private double uah1 { get; set; }
        private double uah2 { get; set; }
        public Converter1(double uah, double uah1, double uah2)
        {
            this.uah = uah;
            this.uah1 = uah1;
            this.uah2 = uah2;
        }
        public void Print()
        {
            Console.WriteLine("Choose currency: ");
            Console.WriteLine("$ to uah");
            Console.WriteLine("Euro to uah");
            Console.WriteLine("Krones to uah");
            int vol1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount: ");
            double money = Convert.ToInt32(Console.ReadLine());

            switch (vol1)
            {
                case 1:
                    double result = money / uah;
                    Console.WriteLine("Your amount in uah: " + result);
                    break;

                case 2:
                    double result1 = money / uah1;
                    Console.WriteLine("Your amount in uah: " + result1);
                    break;
                case 3:
                    double result2 = money / uah2;
                    Console.WriteLine("Your amount in uah: " + result2);
                    break;
            }
        }
    }

    class Converter
    {
        private double usd { get; set; }
        private double eur { get; set; }
        private double kr { get; set; }


        public Converter(double usd, double eur, double kr)
        {
            this.usd = usd;
            this.eur = eur;
            this.kr = kr;

        }
        public void Print()
        {
            Console.WriteLine("Choose currency: ");
            Console.WriteLine("1. $");
            Console.WriteLine("2. Euro");
            Console.WriteLine("3. Krones");
            int vol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount: ");
            double uah = Convert.ToInt32(Console.ReadLine());

            switch (vol)
            {
                case 1:
                    double result = uah / usd;
                    Console.WriteLine("Your amount in $: " + result);
                    break;

                case 2:
                    double result1 = uah / eur;
                    Console.WriteLine("Your amount in euros: " + result1);
                    break;
                case 3:
                    double result2 = uah / kr;
                    Console.WriteLine("Your amount in krones: " + result2);
                    break;
            }
        }
    }
}