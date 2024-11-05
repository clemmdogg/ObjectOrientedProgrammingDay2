using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    public class AccountOwner : Person
    {
        public int CostumerID { get; set; }
        public AccountOwner(int costumerID, string firstName, string lastName) : base(firstName, lastName)
        {
            CostumerID = costumerID;
        }
    }
    internal class EncapsulationExercisePart2
    {
    }
}
