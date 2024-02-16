using System;

public class ApplyBusinessRules
{
    public static void PrintToConsole()
    {


// https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-challenge

// Exercise - Complete a challenge activity to apply business rules

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//daysUntilExpiration = 1;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
    }
}

// My attempt at the challenge
// //Console.WriteLine(daysUntilExpiration);
// Console.WriteLine(discountPercentage);

// // If the user's subscription will expire in 10 days or less, display the message:
// if (daysUntilExpiration <= 10 && daysUntilExpiration > 6) {
//     Console.WriteLine("Your subscription expires soon. Renew now!");
// }
// // If the user's subscription will expire in 5 days or less, display the message:
// else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1) {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
// }
// // Rule 4: If the user's subscription will expire in one day, display the messages
// else if (daysUntilExpiration == 1) {
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
// }

// // Rule 5: If the user's subscription has expired, display the message:
// else if (daysUntilExpiration == 0) {
//     Console.WriteLine("Your subscription has expired.");
// }
// // Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.
// else {}
//     }
// }
