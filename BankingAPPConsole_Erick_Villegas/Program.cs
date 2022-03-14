using System;

namespace BankingAPPConsole_Erick_Villegas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Menu 
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Get Details");
            Console.WriteLine("6. Exit");
            Accounts account1 = new Accounts();
            #endregion
            bool continueBanking = true;

            while (continueBanking) {
                int selection = Convert.ToInt32(Console.ReadLine());
                switch(selection) {
                    case 1:
                        //Console.WriteLine("Current Balance " + AccountBalance);
                        break;
                }
            }
            





        }
    }
}
