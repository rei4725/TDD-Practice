namespace MultiCurrencyMoney
{
    public class Money
    {
        public readonly int Amount;
        protected CurrencyID CurrencyID;
    
        public Money(int amount, CurrencyID currencyID)
        {
            Amount = amount;
            CurrencyID = currencyID;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount,CurrencyID.USD);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount,CurrencyID.CHF);
        }

        public string Currency()
        {
            return CurrencyID.ToString();
        }

        public Money Times(int timesValue)
        {
            return new Money(Amount * timesValue,CurrencyID);
        }

        public override bool Equals(object obj)
        {
            var thatMoney = obj as Money;
            return Amount.Equals(thatMoney?.Amount) &&
                CurrencyID.Equals(thatMoney.CurrencyID);
        }
    }
}
