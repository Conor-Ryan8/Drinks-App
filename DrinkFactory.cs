using System;

namespace DrinksApp
{
    class DrinkFactory
    {
        public static Drink GetDrink(string type, char size)
        {
            if (type == "Coffee")
            {
                return new Coffee(size);
            }
            else if (type == "Tea")
            {
                return new Tea(size);
            }
            else if (type == "Chocolate")
            {
                return new Chocolate(size);
            }
            else
            {
                return null;
            }
        }
    }
}