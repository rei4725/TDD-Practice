namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount): base(amount)
        {
            
        }
        public Dollar Times(int timesValue)
        {
            return new Dollar(Amount * timesValue);
        }
    }
}
