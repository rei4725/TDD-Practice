namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        public readonly int Amount;
        public abstract Money Times(int timesValue);
        public abstract string Currency();
        public Money(int amount)
        {
            Amount = amount;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }

        public override bool Equals(object obj)
        {
            var thatMoney = obj as Money;
            return Amount.Equals(thatMoney?.Amount) &&
                MemberwiseClone().GetType().Equals(thatMoney.GetType());
        }
    }
}
