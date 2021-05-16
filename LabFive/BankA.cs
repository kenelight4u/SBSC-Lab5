namespace LabFive
{
    public class BankA : Bank
    {
        public double Balance { get; set; }

        public BankA()
        {
            this.Balance = 100;
        }
        
        public override double GetBalance()
        {
            return Balance;
        }
    }
}