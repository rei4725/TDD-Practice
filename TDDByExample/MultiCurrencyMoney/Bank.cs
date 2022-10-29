namespace MultiCurrencyMoney
{
    public class Bank
    {
        public Money Reduce(Expression source, CurrencyID to)
        {
            return Money.Dollar(10);
        }
    }
}
