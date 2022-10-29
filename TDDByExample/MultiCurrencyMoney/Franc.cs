namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount, CurrencyID CurrencyID) :base(amount)
        {
            this.CurrencyID = CurrencyID;
        }
        public override Money Times(int timesValue)
        {
            return Franc(Amount * timesValue);
        }

    }
}
