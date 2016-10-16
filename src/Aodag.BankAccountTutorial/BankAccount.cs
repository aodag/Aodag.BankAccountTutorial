namespace Aodag.BankAccountTutorial
{
    public class BankAccount
    {
        private int _balance = 0;
        public BankAccount()
            : this(0)
        {
        }

        public BankAccount(int initialBalance)
        {
            _balance = initialBalance;
        }

        public int Balance
        {
            get { return _balance; }
        }

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (_balance < amount)
            {
                throw new NotEnoughFundsException();
            }
            _balance -= amount;
        }
    }
}
