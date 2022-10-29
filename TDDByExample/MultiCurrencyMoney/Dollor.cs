namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public void Times (int timesValue)
        {
            Amount *= timesValue;
        }
    }
}
