using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    internal class EncapsulationExercisePart4
    {
        public static void RunApplication()
        {
            AccountOwner myAccountOwner = new AccountOwner(
                100000,
                "Casper",
                "Clemmensen"
                );
            Account myAccount = new Account(
                myAccountOwner
                );
            EncapsulationExercisePart3.Deposit(myAccount, 50);
            EncapsulationExercisePart3.Withdraw(myAccount, 50);
        }
    }
}
