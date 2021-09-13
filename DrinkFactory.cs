using System;

namespace DrinksApp
{
    class DrinkFactory
    {
        public static Drink GetDrink(string type)
        {
            if (type == "Coffee")
            {
                return new Coffee();
            }
            else if (type == "Tea")
            {
                return new Tea();
            }
            else
            {
                return null;
            }
        }
    }
}