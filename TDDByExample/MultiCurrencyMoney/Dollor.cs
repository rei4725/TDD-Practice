namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount): base(amount)
        {
            
        }
        public override Money Times(int timesValue) 
        {
            return new Dollar(Amount * timesValue);
        }
    }
}
