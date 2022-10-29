namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount,CurrencyID CurrencyID): base(amount, CurrencyID)
        {
            this.CurrencyID = CurrencyID;
        }

    }
}
