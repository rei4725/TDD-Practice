namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times (int timesValue)
        {
            return new Dollar(Amount * timesValue);
        }
    }
}
