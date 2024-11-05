using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay2.Exercises
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
        }
    }
    internal class EncapsulationExercisePart5Part1
    {
    }
}
