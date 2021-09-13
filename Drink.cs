namespace DrinksApp
{
    abstract class Drink
    {
        protected string _type;
        protected char _size;

        public abstract string GetSummary();
    }
}