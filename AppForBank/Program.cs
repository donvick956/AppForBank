using System;

namespace AppForBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank newBank = new Bank( );
            newBank.Login();
            newBank.Deposit();
           
            
            
            



        }

        class Bank

        {

            public string CustomerUserName { get; set; }
            public double Balance { get; set; }
            public string Password { get; set; }

        

            void NextMenu()
            {
                // Customer should be able to navigate through the app

                Console.WriteLine("Enter A for withdrawal, B for deposit, C for logout");
                Console.ReadLine();
            }
            public double Withdraw()
            {
                Console.WriteLine("Available Balance: {0}", Balance);
                Console.WriteLine("How much would you like to withdraw?: ");
                double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
               




                NextMenu();
                return WithdrawAmt;
            }
            
                public double Deposit()
            {
                Console.WriteLine("Available Balance: {0}", Balance);
                Console.WriteLine("How much would you like to Deposit?: ");
                double Deposit = Convert.ToDouble(Console.ReadLine());
                Balance = Balance += Deposit;
                Console.WriteLine(Balance);
                NextMenu();
                return Deposit;
            }

            public void Login() 
            {
                
                Console.WriteLine("Enter username: ");
                CustomerUserName = Console.ReadLine();
                String PassWord = " ";
                Console.WriteLine("Enter Password: ");
                PassWord = Console.ReadLine();
                if (CustomerUserName == "Victor" && PassWord == "Victor")
                {
                    Console.WriteLine(" Login Successful");
                }
            }
        }
    }
}




