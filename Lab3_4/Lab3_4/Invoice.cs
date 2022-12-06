using System;

namespace Lab3_4
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private double PDW = 0.2;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double CalculateValueOrder()
        {
            int choose = 0;
            Console.Write("0 without taxes, 1 with taxes:");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    return account;
                case 1:
                    return (account * PDW) + account;
            }
            return 0;
        }
    }
}