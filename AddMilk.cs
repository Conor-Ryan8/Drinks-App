namespace DrinksApp
{
    class AddMilk : Drink
    {
        private readonly Drink _newDrink;
        
        public AddMilk(Drink drink)
        {
            this._newDrink = drink;
        }

        public override string GetDescription()
        {
            return _newDrink.GetDescription() + " + Milk";
        }

        public override float GetPrice()
        {
            return _newDrink.GetPrice() + 0.5f;
        }
    }
}