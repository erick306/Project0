using System;

namespace BankingAPPConsole_Erick_Villegas
{
    class Accounts
    {
            #region Variables
        int v_accNo;
        string v_accName;
        string v_accType;
        double v_accBalance;
        bool v_isAccountActive;
        string v_accEmail;
        #endregion
            #region Account Properties
        public int AccountNumber
        { 
            get{ return v_accNo;}
            set{v_accNo = value;}
        }

        public string AccountName 
        { 
            get{return v_accName;} 
            set{v_accName = value;} 
        }

        public string AccountType 
        { 
            get{return v_accType;} 
            set{v_accType = value;}
        }

        public double AccountBalance 
        { 
            get{return v_accBalance;} 
            set{v_accBalance = value;}
        }

        public bool isAccountActive 
        { 
            get{return v_isAccountActive;} 
            set{v_isAccountActive = value;}
        }

        public string AccountEmail 
        { 
            get{return v_accEmail;} 
            set{v_accEmail = value;}
        }
        #endregion
            #region Methods
        public double Withdraw(int withdraw_qty)
        {
            AccountBalance = AccountBalance - withdraw_qty;
            return AccountBalance;
        }   
        public double Deposit(int deposit_qty)
        {
            AccountBalance = AccountBalance + deposit_qty;
            return AccountBalance;
        }
        public void AccountDetails()
        {
            Console.WriteLine("Account No: " + AccountNumber);
            Console.WriteLine("Name: " + AccountName);
            Console.WriteLine("Type: " + AccountType);
            Console.WriteLine("Balance: " + AccountBalance);
            Console.WriteLine("Active: " + isAccountActive);
            Console.WriteLine("Email: " + AccountEmail);
        }
        public void CheckBalance()
        {
            Console.WriteLine("Balance: "+ AccountBalance);
        }
        #endregion
    }
}