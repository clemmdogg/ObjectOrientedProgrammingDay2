using ObjectOrientedProgrammingDay2.Exercises;
using System.Security.Principal;

namespace ObjectOrientedProgrammingDay2;

internal class Program
{
    static void Main(string[] args)
    {
        EncapsulationExercisePart4.RunApplication();
        AccountAdmin Casper = new AccountAdmin("Casper", "Clemmensen");
        Console.WriteLine($"Hej {Casper.FullName}. Din konto er oprettet med {Casper.FullName} som admin.");
        Console.ReadKey();
        AccountOwner Simon = new AccountOwner(10001, "Simon", "Heilbuth");
        Account SimonAccount = new Account(Simon);
        Console.WriteLine(SimonAccount.Balance);
        while (true)
        {
            Console.Clear();
            Console.Write("Hvor meget vil du sætte ind på Simons konto: ");
            try
            {
                int simonDeposit = int.Parse(Console.ReadLine());
                if (simonDeposit > 10000)
                    throw new ArgumentException("Du må ikke sætte over 10000 kr ind");
                if (simonDeposit < 0)
                    throw new InvalidOperationException("Du må ikke sætte et negativt beløb ind");
                EncapsulationExercisePart3.Deposit(SimonAccount, simonDeposit);
                break;
            }
            catch (FormatException Ex1)
            {
                Console.WriteLine($"Fejl: {Ex1}");
            }
            catch (InvalidOperationException Ex2)
            {
                Console.WriteLine($"Fejl: {Ex2}");
            }
            catch (ArgumentException Ex3)
            {
                Console.WriteLine($"Fejl: {Ex3}");
            }
            catch (Exception Ex4)
            {
                Console.WriteLine($"Fejl: {Ex4}");
            }
            finally
            {
                Console.WriteLine($"Dit indestående er: {SimonAccount.Balance} DKK");
            }
        }

        Console.Write("Hvor meget vil du hæve på Simons konto: ");
        int simonWithdrawal = int.Parse(Console.ReadLine());
        EncapsulationExercisePart3.Withdraw(SimonAccount, simonWithdrawal);
    }

}
