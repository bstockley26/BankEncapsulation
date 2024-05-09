namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var brooks = new BankAccount();
            var money = brooks.GetBalance();

            Console.WriteLine($"Account balance = {money}");

            brooks.Deposit();

            money = brooks.GetBalance();
            Console.WriteLine($"Account balance = {money}");


            brooks.WithDraw();

            money = brooks.GetBalance();
            Console.WriteLine($"Account balance = {money}");


            //Console.WriteLine($"Hello. Pick the appropriate number of the following for how best we can help you." +
            //    $" 1.Balance, 2.Withdraw, 3. Deposit");
            //var actionNumber = Console.ReadLine();
            //int number;
            //if (int.TryParse(actionNumber, out number))
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            money = brooks.GetBalance();
            //            Console.WriteLine($"Account balance = {money}");
            //            break;

            //        case 2:
            //            brooks.WithDraw();
            //            break;

            //        case 3:
            //            brooks.Deposit();
            //            break;

            //        default:
            //            Console.WriteLine("Sorry can not help with that");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please choose appropriate number"); 
            //}



        }
    }
}
