using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    public class Account
    {
        public AccountOwner AccountOwner { get; set; }
        internal double Balance { get; set; }
        public Account(AccountOwner accountOwner)
        {
            Balance = 100;
            AccountOwner = accountOwner;
        }
    }
    internal class EncapsulationExercisePart1
    {
    }
}
