using System;

namespace Method_Overriding
{
    class Program
    {

        /*                                              ################ Method Overriding ##############
                ○ if a method in the derived class has the same signature as thaht of in the base class with different implementation then we say that method in the derived class overrides the method od base class
                ○ this process is called as method overriding.
                ○ the method of the base calss should be declared as virtual and method in derived class should be declared as override.
         */


        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }

            public virtual void GetDetails()
            {
                Console.WriteLine("Customer ID : " + CustomerId);
                Console.WriteLine("name :" + Name);
            }
        }

        class BankCustomer : Customer
        {
            public double Balance { get; set; }

            public override void GetDetails()
            {
                Console.WriteLine("");
                base.GetDetails();
                Console.WriteLine("Balance : " + Balance);
            }

            public void Deposite(double value)
            {
                this.Balance = Balance + value;
                this.GetDetails();

            }
        }

        static void Main(string[] args)
        {
            BankCustomer bankCustomer = new BankCustomer()
            {
                CustomerId = 1,
                Name = "Fáusio Luis",
                Balance = 99999.99
            };

            bankCustomer.GetDetails();

            bankCustomer.Deposite(50000.00);
            Console.ReadKey();
        }
    }
}
