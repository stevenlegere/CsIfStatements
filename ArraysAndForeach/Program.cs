// See https://aka.ms/new-console-template for more information

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

