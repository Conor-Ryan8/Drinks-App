namespace DrinksApp
{
    class Coffee : Drink
    {
        public Coffee(){}

        public override string GetDescription()
        {
            return "Coffee";
        }

        public override float GetPrice()
        {
            return 2.00f;
        }
    }
}