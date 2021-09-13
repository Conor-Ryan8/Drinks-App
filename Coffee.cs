namespace DrinksApp
{
    class Coffee : Drink
    {
        public Coffee(char size)
        {
            _type = "Coffee";
            _size = size;
        }
        public override string GetSummary()
        {
            return "Coffee - " + _size;
        }
    }
}