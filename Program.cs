// create a new instance of the System.Random class and store a reference to the object in a variable named dice
using System;

class Program
{

    static void Main(string[] args)
    {
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

ArraysAndForeach arraysAndForeach = new ArraysAndForeach();
arraysAndForeach.PrintToConsole();
    }
}

public class ArraysAndForeach
{
    public void PrintToConsole()

{
// new operator creates a new instance of the array
// string[] fraudulentOrderIDs = new string[3];
//         // First set of square brankets [] declares the variable as an array
//         // Second set of square brackets [] specifies the number of elements in the array
//     fraudulentOrderIDs[0] = "A123";
//     fraudulentOrderIDs[1] = "B456";
//     fraudulentOrderIDs[2] = "C789";
    // fraudulentOrderIDs[3] = "D000"; // Intentional error
    // Assign Order ID values to your array

// Initialize an array { } with values
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

    // Access the elements in the array
    Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
    Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
    Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

    // Reassign the value of an array
    fraudulentOrderIDs[0] = "F000";
    Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Use the Length property of an array
}
}



// ApplyBusinessRules.PrintToConsole();

