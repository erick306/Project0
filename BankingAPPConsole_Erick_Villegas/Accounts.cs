using System;
using System.Data.SqlClient;
using System.Collections.Generic;

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
        public int p_accNo
        { 
            get{ return v_accNo;}
            set{v_accNo = value;}
        }
        
        public string p_accName 
        { 
            get{return v_accName;} 
            set{v_accName = value;} 
        }

        public string p_accType 
        { 
            get{return v_accType;} 
            set{v_accType = value;}
        }

        public double p_accBalance 
        { 
            get{return v_accBalance;} 
            set{v_accBalance = value;}
        }

        public bool p_isAccountActive 
        { 
            get{return v_isAccountActive;} 
            set{v_isAccountActive = value;}
        }

        public string p_accEmail 
        { 
            get{return v_accEmail;} 
            set{v_accEmail = value;}
        }
        #endregion
            #region Methods
        SqlConnection con = new SqlConnection(@"server=DESKTOP-9UJOUBT;database=BankingAPPConsole;integrated security=true");
        public string AccountChanges(Accounts accChanges)
        {
            SqlCommand cmd_changeAccount = new SqlCommand("insert into APP_Variables values(@p_accName,@p_accType,@p_accBalalnce,@p_isAccountActive,@p_accEmail",con);
            //cmd_changeAccount.Parameters.AddWithValue("@p_accNo",accChanges.p_accNo);
            cmd_changeAccount.Parameters.AddWithValue("@p_accName",accChanges.p_accName);
            cmd_changeAccount.Parameters.AddWithValue("@p_accType",accChanges.p_accType);
            cmd_changeAccount.Parameters.AddWithValue("@p_accBalance",accChanges.p_accBalance);
            cmd_changeAccount.Parameters.AddWithValue("@p_isAccountActive",accChanges.p_isAccountActive);
            cmd_changeAccount.Parameters.AddWithValue("@p_accEmail",accChanges.p_accEmail);

            try
            {
                con.Open();
                cmd_changeAccount.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return "Changes made successfully";
        }
        public Accounts CheckingsBalance(string Type)
        {
            Accounts Check = new Accounts();
            SqlCommand cmd_BalanceCheck = new SqlCommand("select p_accBalance from APP_Variables where p_accType = @p_accType",con);
            cmd_BalanceCheck.Parameters.AddWithValue("@p_accType",Type);
            SqlDataReader _read = null;
            try
            {
                con.Open();
                _read = cmd_BalanceCheck.ExecuteReader();
                if (_read.Read())
                {
                    Check.p_accType = Convert.ToString(_read[3]);

                    return Check;
                }
            }
            catch(System.Exception es)
            {
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                _read.Close();
                con.Close();
            }
        return Check;
        }
        public Accounts Withdraw(double withdraw_qty)
        {
            Accounts CkeckWithdraw = new Accounts();
            p_accBalance = p_accBalance - withdraw_qty;
            SqlCommand cmd_updateBalance = new SqlCommand("update App_Variables set p_accBalance = @newp_accBalance where p_accType = @p_accType",con);
            cmd_updateBalance.Parameters.AddWithValue("@newp_accBalance",p_accBalance);
             try
            {
                con.Open();
                cmd_updateBalance.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return CkeckWithdraw;
        }   
        public Accounts Deposit(double deposit_qty)
        {
            Accounts CkeckDeposit = new Accounts();
            p_accBalance = p_accBalance - deposit_qty;
            SqlCommand cmd_updateBalance = new SqlCommand("update App_Variables set p_accBalance = @newp_accBalance where p_accType = @p_accType",con);
            cmd_updateBalance.Parameters.AddWithValue("@newp_accBalance",p_accBalance);
             try
            {
                con.Open();
                cmd_updateBalance.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return CkeckDeposit;
        }
        public string cancelAcc(string id)
        {
            SqlCommand cmd_cancelAccount = new SqlCommand("delete from APP_Variable where p_accNo=@p_accType",con);
            cmd_cancelAccount.Parameters.AddWithValue("@p_accType",id);
            try
            {
                con.Open();
                cmd_cancelAccount.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {
                Console.WriteLine(es.Message);
            }
            finally
            {
                con.Close();
            }
            return "Account Cancelled";
        }   
        #endregion
    }
}