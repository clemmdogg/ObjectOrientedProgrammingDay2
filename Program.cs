using ObjectOrientedProgrammingDay2.Exercises;

namespace ObjectOrientedProgrammingDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EncapsulationExercisePart4.RunApplication();
            AccountAdmin Casper = new AccountAdmin("Casper", "Clemmensen");
            Console.WriteLine($"Hej {Casper.FullName}. Din konto er oprettet med {Casper.FullName} som admin.");
            Console.ReadKey();
        }
    }
}
