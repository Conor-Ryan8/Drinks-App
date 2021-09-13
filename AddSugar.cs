namespace DrinksApp
{
    class AddSugar : Drink
    {
        private readonly Drink _newDrink;

        public AddSugar(Drink drink)
        {
            this._newDrink = drink;
        }

        public override string GetDescription()
        {
            return _newDrink.GetDescription() + " + Sugar";
        }

        public override float GetPrice()
        {
            return _newDrink.GetPrice() + 0.35f;
        }
    }
}