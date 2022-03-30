using System;
using System.Collections.Generic;
namespace BankingAPPConsole_Erick_Villegas
{
    class Program
    {
        static void Main(string[] args)
        {   Accounts accChangesMade = new Accounts();
            bool continueBanking = true;
            float balance = 0;
            Console.WriteLine("Welcome to your Banking App.");
            Console.WriteLine("Please select from one of the options below to begin.");
            while (continueBanking) { 
                #region Menu 
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Deposit");
                Console.WriteLine("5. Cancel Account");
                Console.WriteLine("6. Exit");
                Accounts account1 = new Accounts();
                #endregion
                int selection = Convert.ToInt32(Console.ReadLine());
                switch(selection) {
                    case 1:
                        Console.WriteLine("Please enter you full name.");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please select from the following types of accounts:");
                        Console.WriteLine("|Checkings| |Savings| ");
                        string typeselection = null;
                        string type = null;
                        while (type == null){
                            typeselection = Console.ReadLine();
                            if (typeselection == "Checkings"){
                            type = "Checkings";
                            } else if (typeselection == "Savings"){
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
                        Console.WriteLine("Please specify the account number for the account which you would like to see the balance.");
                        int accNoSelection = Convert.ToInt32(Console.ReadLine());
                        Accounts acc = accChangesMade.CheckingsBalance(accNoSelection);
                        if (acc.p_accType == "Checkings") {
                            Console.WriteLine("Checkings Account Balance: " + acc.p_accBalance);
                        }else if (acc.p_accType == "Savings") {
                            Console.WriteLine("Savings Account Balance " + acc.p_accBalance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please select the account you would like to withdraw from.");
                        int searchId = Convert.ToInt32(Console.ReadLine());;
                        Accounts accwithdraw = accChangesMade.CheckingsBalance(searchId); 
                        if (accwithdraw.p_accType == "Checkings") {
                            Console.WriteLine("Please enter the amount you want to withdraw.");
                            double withdrawal_amount = Convert.ToDouble(Console.ReadLine());
                            double temp_balance = accwithdraw.p_accBalance;
                            temp_balance = temp_balance - withdrawal_amount;
                            Console.WriteLine(withdrawal_amount + " has been withdrawn from your Checkings account");
                            Console.WriteLine("Your current balance is " + temp_balance);
                            Console.WriteLine(accwithdraw.Withdraw(withdrawal_amount,searchId));
                        }
                        else if (accwithdraw.p_accType == "Savings") {
                            Console.WriteLine("Please enter the amount you want to withdraw.");
                            double withdrawal_amount = Convert.ToDouble(Console.ReadLine());
                            double temp_balance = accwithdraw.p_accBalance;
                            temp_balance = temp_balance - withdrawal_amount;
                            Console.WriteLine(withdrawal_amount + " has been withdrawn from your Savings account");
                            Console.WriteLine("Your current balance is " + temp_balance);
                            Console.WriteLine(accwithdraw.Withdraw(withdrawal_amount,searchId));
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please select the account you would like to deposit into.");
                        int searchId2 = Convert.ToInt32(Console.ReadLine());
                        Accounts accdeposit = accChangesMade.CheckingsBalance(searchId2);
                        if (accdeposit.p_accType == "Checkings") {
                            Console.WriteLine("Please enter the amount you want to deposit.");
                            double deposit_amount = Convert.ToDouble(Console.ReadLine());
                            double temp_balance = accdeposit.p_accBalance;
                            temp_balance = temp_balance + deposit_amount;
                            Console.WriteLine(deposit_amount + " has been deposited into your Checkings account");
                            Console.WriteLine("Your current balance is " + temp_balance);
                            Console.WriteLine(accdeposit.Deposit(deposit_amount,searchId2));
                        }
                        else if (accdeposit.p_accType == "Savings") {
                            Console.WriteLine("Please enter the amount you want to Deposit.");
                            double deposit_amount = Convert.ToDouble(Console.ReadLine());
                            double temp_balance = accdeposit.p_accBalance;
                            temp_balance = temp_balance + deposit_amount;
                            Console.WriteLine(deposit_amount + " has been deposited into your Savings account");
                            Console.WriteLine("Your current balance is " + temp_balance);
                            Console.WriteLine(accdeposit.Deposit(deposit_amount,searchId2));
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please enter the account number of the account you would like to cancel.");
                        string pid = Console.ReadLine();
                        Console.WriteLine(accChangesMade.cancelAcc(pid));
                        break;    
                    case 6:
                        continueBanking = false;
                        Console.WriteLine("Thank you for using your Banking App.");
                        break;
                    default:
                        Console.WriteLine("Please select an option from options 1 through 6 to begin banking.");
                        break;
                }
            }
            





        }
    }
}
