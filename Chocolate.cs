namespace DrinksApp
{
    class Chocolate : Drink
    {
        public Chocolate(char size)
        {
            _type = "Hot Chocolate";
            _size = size;
        }
        public override string GetSummary()
        {
            return "Hot Chocolate - " + _size;
        }
    }
}