namespace LabFive
{
    public class BankB : Bank
    {
        public double Balance { get; set; }

        public BankB()
        {
            this.Balance = 150;
        }
        
        public override double GetBalance()
        {
            return Balance;
        }
    }
}