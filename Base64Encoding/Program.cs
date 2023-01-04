// See https://aka.ms/new-console-template for more information

// Allocate array of 128 bytes
byte[] binaryObject = new byte[128];

// Fill array with random bytes
Random.Shared.NextBytes(binaryObject);
Console.WriteLine("The binary object as bytes: ");
for (int index = 0; index < binaryObject.Length; index++)
{
    Console.Write($"{binaryObject[index]:X} ");
}
Console.WriteLine();

// Convert to base64 string 
string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binary object as base64 encoded: {encoded}");