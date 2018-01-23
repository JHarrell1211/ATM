using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            double accountBal = 4189.07;
            int transaction = 0;
            double withdrawl = 0;
            double deposit = 0;

            do
            {
                Console.WriteLine("Enter The Number of Your Desired Transaction Type:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawl");
                Console.WriteLine("3. Account Balance");
                Console.WriteLine("4. Quit");
                transaction = int.Parse(Console.ReadLine());
                
                if ((transaction < 1) || (transaction > 4))
                {
                    Console.WriteLine("Invald Entry!");
                }

                if (transaction == 1)
                {
                    Console.WriteLine("Enter Deposit Amount");
                    deposit = int.Parse(Console.ReadLine());

                    while (deposit < 0)
                    {
                        Console.WriteLine("Error!! Enter Deposit Amount: ");
                        deposit = int.Parse(Console.ReadLine());
                    } 

                        accountBal = (deposit + accountBal);
                        Console.WriteLine(accountBal);
                        Console.WriteLine("Your New Balance is: " + accountBal + "\n");    
                }

                if (transaction == 2)
                {
                        Console.WriteLine("Enter Withdrawl Amount: ");
                        withdrawl = int.Parse(Console.ReadLine());

                    while (withdrawl > accountBal)
                    {
                        Console.WriteLine("Insufficient Funds: Your Account Balance is: " + accountBal);
                        Console.WriteLine("Enter Withdrawl Amount: ");
                        withdrawl = int.Parse(Console.ReadLine());
                    }

                        accountBal = accountBal - withdrawl;
                        Console.WriteLine("Your Account Balance is " + accountBal + "\n" );
                    
                }
                if (transaction == 3)
                {
                    Console.WriteLine("Your Account Balance is: " + accountBal + "\n");
                }
                if (transaction == 4)
                {
                    Console.WriteLine("Good Bye!");
                }
            }
            while (transaction != 4);
                  
                
            

        }
    }
}
