// create a new instance of the System.Random class and store a reference to the object in a variable named dice
using System.Security.AccessControl;

Random dice = new Random();

// call the Random.Next() method on the dice object three times, providing both the lower and upper bounds to restrict the possible values between 1 and 6 for each roll
// You save the three random numbers in the variables roll1, roll2, and roll3
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// sum the three dice rolls and save the value into an integer variable named total
int total = roll1 + roll2 + roll3;

// roll1 = 6;
// roll2 = 6;
// roll3 = 6;
// use the WriteLine() method to display the three values using string interpolation
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Add an if statement to display different messages based on the value of the total variable
// () is the condition which is a boolean expression
// if (total > 14)
//         // {} a code block
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Add another if statement to implement the doubles bonus
// implement the rule: "If any two dice you roll result in the same value, you get two bonus points for rolling doubles"
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }
//     // To improve the readability of your code, update the second if statement as follows
// if (total >= 15)
//         // {} a code block
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Add another if statement to implement the triples bonus


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! + 6 bonus to total!");
//     total += 6;
// }
//     // To improve the readability of your code, update the second if statement as follows
// if (total >= 15)
//         // {} a code block
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! + 6 bonus to total!");
//     total += 6;
// }
//     // To improve the readability of your code, update the second if statement as follows
// if (total >= 15)
//         // {} a code block
// {
//     Console.WriteLine("You win!");
// }

// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Modify the code to remove the stacking bonus for doubles and triples using nesting

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}