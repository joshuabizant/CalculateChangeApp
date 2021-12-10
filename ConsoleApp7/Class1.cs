using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Change
    {
        int quarters;
        int dimes;
        int nickles;
        int pennies;

       public Change(int changeConvert)
        {

            string changetypes = CalculateLeastChange(changeConvert);
            Console.WriteLine(changetypes);
        }

        public string CalculateLeastChange(int changeToConvert)
        {
            bool validInput;
            quarters = changeToConvert / 25;
            validInput = GreaterThanZero(quarters);
            if (validInput == true)
            {
                changeToConvert = changeToConvert - (quarters * 25);
            }
            dimes = changeToConvert / 10;
            validInput = GreaterThanZero(dimes);
            if (validInput == true)
            {
                changeToConvert = changeToConvert - (dimes * 10);
            }
            nickles = changeToConvert / 5;
            validInput = GreaterThanZero(nickles);
            if (validInput == true)
            {
                changeToConvert = changeToConvert - (nickles * 5);
            }

            string amountOfCoins = quarters + " quarters " + dimes + " dimes " + nickles + " nickles " + changeToConvert + " pennies";
            return amountOfCoins;

        }

        public void CalculateAllChange(int changeAmount)
        {





        }

        public bool GreaterThanZero(int checkZero)
        {
            bool greaterThanZero;
            if (checkZero > 0)
            {
                greaterThanZero = true;
            }
            else
            {
                greaterThanZero = false;
            }

            return greaterThanZero;
        }


    }
}
