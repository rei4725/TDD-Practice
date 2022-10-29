namespace MultiCurrencyMoney
{
    public class Franc
    {
        private readonly int Amount;
        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times (int timesValue)
        {
            return new Franc(Amount * timesValue);
        }

        public override bool Equals(object obj)
        {
            var thatFranc = obj as Franc;
            return Amount.Equals(thatFranc?.Amount);
        }
    }
}
