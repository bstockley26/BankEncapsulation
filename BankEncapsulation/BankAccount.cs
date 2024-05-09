using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double _balance;

		public void Deposit()
		{
            Console.WriteLine("What is the amount you are depositing?");

            string inputAmount=Console.ReadLine();
			int number;

            bool success = int.TryParse(inputAmount, out number);

			if (success)
			{
				Console.WriteLine($"{inputAmount} was added to your account!!");
                _balance += number;
            }
			else
			{
				Console.WriteLine("Provide a accepted amount!");
			}

            
		}
		public void WithDraw()
		{
            Console.WriteLine("What is the amount you are withdrawing?");

            string inputAmount = Console.ReadLine();
			int number;

            bool success = int.TryParse(inputAmount, out number);


            if (success)
			{
				if (number < _balance)
				{
					_balance -= number;
				}
				else
				{
					Console.WriteLine("Insufficient funds! Choose available amount");
					
				}
			}
                
            else
            {
                Console.WriteLine("Provide accepted amount!!");
            }


            
		}
		public double GetBalance()
		{
			return _balance;
			
		}




	}



}

