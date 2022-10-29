namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        public readonly int Amount;
        protected CurrencyID CurrencyID;
        public abstract Money Times(int timesValue);
        public Money(int amount)
        {
            Amount = amount;
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

        public override bool Equals(object obj)
        {
            var thatMoney = obj as Money;
            return Amount.Equals(thatMoney?.Amount) &&
                MemberwiseClone().GetType().Equals(thatMoney.GetType());
        }
    }
}
