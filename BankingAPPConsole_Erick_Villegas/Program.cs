using System;
using System.Collections.Generic;
namespace BankingAPPConsole_Erick_Villegas
{
    class Program
    {
        static void Main(string[] args)
        {   Accounts accChangesMade = new Accounts();
            Console.WriteLine("Welcome to your Banking App.");
            Console.WriteLine("Please select from one of the options below to begin.");
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
            int balance = 0;
            while (continueBanking) {
                int selection = Convert.ToInt32(Console.ReadLine());
                switch(selection) {
                    case 1:
                        Console.WriteLine("Please enter you full name.");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please select from the following types of accounts:");
                        Console.WriteLine("1.|Checkings| 2.|Savings| ");
                        int typeselection = 0;
                        string type = null;
                        while (type == null){
                            typeselection = Convert.ToInt32(Console.ReadLine());
                            if (typeselection == 1){
                            type = "Checkings";
                            } else if (typeselection == 2){
                            type = "Savings";
                            } else{
                            Console.WriteLine("Please select from one of the available options to continue.");
                            }
                        }
                        Console.WriteLine("Your current balance will be 0 until your first deposit.");
                        Console.WriteLine("Your account will be set to 'Active' unless you choose to set it to 'Inactive'.");
                        bool isActive = true;
                        Console.WriteLine("Please enter your email below to finish creating your "+ type +" account.");
                        string email = Console.ReadLine();

                        Accounts accChanges = new Accounts();
                        accChanges.p_accName = name;
                        accChanges.p_accType = type;
                        accChanges.p_accBalance = balance;
                        accChanges.p_isAccountActive = isActive;
                        accChanges.p_accEmail = email;
                        Console.WriteLine(accChangesMade.AccountChanges(accChanges));
                        break;
                    case 2:
                        Console.WriteLine("Please specify the account type for which you would like to see the balance.");
                        bool checkBalance = true;
                        string balanceSelection = null;
                        Console.WriteLine("|Checkings| |Savings|");
                        while (checkBalance)
                        balanceSelection = Console.ReadLine();
                        if (balanceSelection == "Checkings") {
                            Accounts Check = accChangesMade.CheckingsBalance(balanceSelection);
                            Console.WriteLine("Checkings Account Balance: " + Check.p_accBalance);
                        }else if (balanceSelection == "Savings") {
                            Accounts Check = accChangesMade.CheckingsBalance(balanceSelection);
                            Console.WriteLine("Savings Account Balance " + Check.p_accBalance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please select the account you would like to withdraw from.");
                        Console.WriteLine("|Checkings| |Savings|");
                        string accountSelection = null;
                        accountSelection = Console.ReadLine();
                        if (accountSelection == "Checkings") {
                            Console.WriteLine("Please enter the amount you want to withdraw.");
                            int withdrawal_amount = Convert.ToInt32(Console.ReadLine());
                            int temp_balance = accChangesMade.p_accBalance;
                            temp_balance = temp_balance - withdrawal_amount;
                            Console.WriteLine(withdrawal_amount + " has been withdrawn from your Checkings account");
                            Console.WriteLine("Your current balance is " + temp_balance);
                        }
                        else if (accountSelection == "Savings") {
                            Console.WriteLine("Please enter the amount you want to withdraw.");
                            int withdrawal_amount = Convert.ToInt32(Console.ReadLine());
                            int temp_balance = accChangesMade.p_accBalance;
                            temp_balance = temp_balance - withdrawal_amount;
                            Console.WriteLine(withdrawal_amount + " has been withdrawn from your Savings account");
                            Console.WriteLine("Your current balance is " + temp_balance);

                            //Accounts updateCheck = accChangesMade.Withdraw();
                            //Console.WriteLine("Checkings Account Balance: "+ CheckWithdraw.p_accBalance);
                        }
                        break;

                }
            }
            





        }
    }
}
