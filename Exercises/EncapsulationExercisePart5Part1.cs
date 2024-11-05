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
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FullName 
        { 
            get 
            { 
                return $"{FirstName} {LastName}"; 
            } 
        }
    }
    internal class EncapsulationExercisePart5Part1
    {
    }
}
