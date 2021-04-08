namespace BankAccountTest
{
    public class SavingAccount : Account
    {
        // private decimal withdrawal;
        // private decimal deposit;
        public SavingAccount(string firstName, string lastName, decimal bal) : base(firstName, lastName, bal)
        {
            
        }

        public override decimal Debit(decimal amount)
        {
            decimal newBalance = Balance - amount;
            return newBalance;
        }

        public override decimal Credit(decimal amount)
        {
            decimal newBalance = Balance + amount;
            return newBalance;
        }

        // public decimal Withdrawal
        // {
        //     get {return withdrawal;}
        //     set {
        //         if(value > 0)
        //         {
        //             withdrawal = value;
        //         }else{
        //             throw new System.ArgumentOutOfRangeException();
        //         }
        //     }
        // }

        // public decimal Deposit
        // {
        //     get {return deposit;}
        //     set {
        //         if(value > 0)
        //         {
        //             deposit = value;
        //         }else{
        //             throw new System.ArgumentOutOfRangeException();
        //         }
        //     }
        // }

        

       
    }
}