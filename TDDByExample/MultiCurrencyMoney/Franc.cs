namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount, CurrencyID CurrencyID) :base(amount, CurrencyID)
        {       
            this.CurrencyID = CurrencyID;
        }

    }
}
