namespace MultiCurrencyMoney
{
    public class Money
    {
        public readonly int Amount;
        public Money(int amount)
        {
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            var thatMoney = obj as Money;
            return Amount.Equals(thatMoney?.Amount) &&
                MemberwiseClone().GetType().Equals(thatMoney.GetType());
        }
    }
}
