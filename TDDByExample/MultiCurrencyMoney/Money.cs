namespace MultiCurrencyMoney
{
    public class Money
    {
        protected readonly int Amount;
        public Money(int amount)
        {
            Amount = amount;
        }

        public Money Times(int timesValue)
        {
            return new Money(Amount * timesValue);
        }

        public override bool Equals(object obj)
        {
            var thatFranc = obj as Money;
            return Amount.Equals(thatFranc?.Amount);
        }
    }
}
