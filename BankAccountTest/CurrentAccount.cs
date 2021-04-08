namespace BankAccountTest
{
    public class CurrentAccount : Account
    {
        
        public CurrentAccount(string firstName, string lastName, decimal bal) : base(firstName, lastName, bal)
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

        public override decimal CalculateInterest()
        {
            
            decimal interest = Balance / (100/12);
            decimal total = interest + Balance;
            return total;
        
        }

        

        
    }
}