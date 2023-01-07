
using System;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for hot dog flavored water. How many people are in your group? Please, parties of 6 or lower.");
        string partySize = Console.ReadLine();
        int partySizeNum = Int32.Parse(partySize);


        if (partySizeNum <= 6)
        {
            Console.WriteLine("A table for " + partySize + "! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or hot dog flavored water.\n");
        }
        else
        {
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
        }

        int hotDogWater = 0;
        int water = 0;


        for (int i = 1; i <= partySizeNum; i++)
        {
            Console.WriteLine("Alright, person number " + i + ", water or hot dog flavored water?\n");
            string drinkChoice = Console.ReadLine();
            Console.WriteLine(drinkChoice + ", good choice!\n");


            if (drinkChoice.Equals("water"))
            {
                water++;
            }

            if (drinkChoice.Equals("hot dog flavored water"))
            {
                hotDogWater++;
            }

            if (!drinkChoice.Equals("water") && !drinkChoice.Equals("hot dog flavored water"))
            {
                Console.WriteLine("We don't have that. No drink for you!");
            }
        }

        Console.WriteLine("Okay, so that's " + water + " water/s and " + hotDogWater + " hot dog water/s. I'll be right back. Feel free to grab your food!");

        double buffetTotal = Convert.ToDouble(partySizeNum) * 9.99;
        double hotDogTotal = (hotDogWater * 199.99);
        double totalBill = (buffetTotal + hotDogTotal);

        Console.WriteLine("Here's your bill! Total price: $" + totalBill);




    }
}