using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    internal class EncapsulationExercisePart3
    {
        public static void Deposit(Account account, double depositAmount)
        {
            account.Balance += depositAmount;
            Console.WriteLine($"Din konto er blivet opdateret. Der står nu kr. {account.Balance}");
            Console.ReadKey();
        }
        public static void Withdraw(Account account, double WithdrawAmount)
        {
            account.Balance -= WithdrawAmount;
            Console.WriteLine($"Din konto er blivet opdateret. Der står nu kr. {account.Balance}");
            Console.ReadKey();
        }
    }
}
