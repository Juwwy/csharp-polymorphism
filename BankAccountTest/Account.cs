namespace BankAccountTest
{
    public abstract class Account
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected decimal balance;

        public Account(string firstName, string lastName, decimal bal)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = bal; 
        }

        public decimal Balance
        {
            get{ return balance;}
            set{
                if(value > 0.0M)
                {
                    balance = value;
                }else {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
        }

        public abstract decimal Credit(decimal amount);

        public abstract decimal Debit(decimal amount);
        public abstract decimal CalculateInterest();
        

        public override string ToString()
        {
            return $"{FirstName} {LastName}\nInitial Account Balance: {Balance:C}";
        }
    }
}