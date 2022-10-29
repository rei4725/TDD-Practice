namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount) :base(amount)
        {

        }
        public override Money Times(int timesValue)
        {
            return new Franc(Amount * timesValue);
        }

    }
}
