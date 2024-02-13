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

roll1 = 2;
roll2 = 1;
roll3 = 1;
// use the WriteLine() method to display the three values using string interpolation
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // Modify the code to remove the stacking bonus for doubles and triples using nesting
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
    
    Console.WriteLine($"Your total including the bonus: {total}");
}
// Use if, else, and else if statements to give a prize instead of a win-lose message
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

