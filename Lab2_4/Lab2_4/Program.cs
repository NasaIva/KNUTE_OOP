using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("NasaIva", "Anastasiia", "Ivanchenko", 18);
            user.Print();
        }
    }

    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string bdata = "28.11.2014";

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.bdata = bdata;
        }
        public void Print()
        {
            Console.WriteLine($"Login: {login} \nName: {name} \nSurname: {surname} " +
                $"\nAge: {age} \nDate of completing the questionnaire: {bdata}");
        }
    }
}