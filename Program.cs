using System;

public class Program
{
    public static void Main()
    {
        // IfElseChallenge();
        // DiceChallenge();
        ArrayChallenge();
    }



    public static void IfElseChallenge()
    {
        // if else exercise
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
        }

        // Console.WriteLine($"{daysUntilExpiration} days until expiration");
        // Console.WriteLine($"Your discount is: {discountPercentage}");

        if (daysUntilExpiration < 1)
        {
            Console.WriteLine("Your subscription has expired!");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%");
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in: {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%");
        }
        else if (daysUntilExpiration < 10)
        {
            // Console.WriteLine($"Your subscription expires in: {daysUntilExpiration} days.");
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else
        {
            Console.WriteLine("Nothing to see here");
        }
    }

    public static void DiceChallenge()
    {
        // rolling dice if else logic
        Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);
        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled tripples! +6 bonus to total!");
            total += 6;
        }
        else if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if (total >= 15)
        {
            Console.WriteLine($"total is: {total}");
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine($"total is: {total}");
            Console.WriteLine("Sorry, you lose : (");
        }
    }



    public static void ArrayChallenge()
    {
        string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        Console.WriteLine("These orders might be fraudulent:");
        foreach (string item in orderIds)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }
    }
}