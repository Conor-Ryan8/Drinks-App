namespace DrinksApp
{
    class Tea : Drink
    {
        public Tea(){}

        public override string GetDescription()
        {
            return "Tea";
        }

        public override float GetPrice()
        {
            return 1.50f;
        }
    }
}