using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    internal class EncapsulationExercisePart3
    {
        public static void Deposit(Account account, double depositAmount)
        {
            account.Balance += depositAmount;
            WriteOut(account.Balance);
        }
        public static void Withdraw(Account account, double WithdrawAmount)
        {
            account.Balance -= WithdrawAmount;
            WriteOut(account.Balance);
        }
        public static void WriteOut(double balance)
        {
            Console.WriteLine($"Din konto er blivet opdateret. Der står nu kr. {Math.Round(balance, 2)}");
            Console.ReadKey();
        }
    }
}
