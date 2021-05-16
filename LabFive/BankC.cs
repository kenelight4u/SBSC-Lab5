namespace LabFive
{
    public class BankC : Bank
    {
        public double Balance { get; set; }

        public BankC()
        {
            this.Balance = 200;
        }

        public override double GetBalance()
        {
            return Balance;
        }
    }
}