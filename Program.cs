using System;

namespace behavioral_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Template_Client.SomeCustomer customer = new Template_Client.SomeCustomer();
            //customer.OrderPizza();

            customer.OrderItalianPizza();
        }
    }
}
