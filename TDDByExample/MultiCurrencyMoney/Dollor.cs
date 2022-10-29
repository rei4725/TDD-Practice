namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times (int timesValue)
        {
            return new Dollar(Amount * timesValue);
        }

        public override bool Equals(object obj)
        {
            var thatDollar = obj as Dollar;
            return Amount.Equals(thatDollar?.Amount);
        }
    }
}
