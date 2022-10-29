namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount,CurrencyID CurrencyID): base(amount)
        {
            this.CurrencyID = CurrencyID;
        }
        public override Money Times(int timesValue) 
        {
            return Dollar(Amount * timesValue);
        }

    }
}
