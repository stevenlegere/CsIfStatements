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

// use the WriteLine() method to display the three values using string interpolation
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Add an if statement to display different messages based on the value of the total variable
    // () is the condition which is a boolean expression
if (total > 14)
        // {} a code block
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }