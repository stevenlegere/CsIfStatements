using System;

public class ArraysAndForeach
{
    public static void PrintToConsole()
    {
Console.WriteLine("Arrays and ForEach");

// Declare an Array
string[] fraudulentOrderIDs = new string[3];
    // new operator creates a new instance of the array
        // First set of square brankets [] declares the variable as an array
        // Second set of square brackets [] specifies the number of elements in the array
    
    // Assign Order ID values to your array
    fraudulentOrderIDs[0] = "A123";
    fraudulentOrderIDs[1] = "B456";
    fraudulentOrderIDs[2] = "C789";
    fraudulentOrderIDs[3] = "D000"; // Intentional break to show the error
    
    // Notice i'm using the name of the array to access the elements

    }
}