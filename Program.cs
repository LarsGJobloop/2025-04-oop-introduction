Console.WriteLine("Hello, World!");
Console.WriteLine("Testing testing!");

// Lese av bruker input
string? userInput = Console.ReadLine();
// Sjekk om systemet vi kjører i støtter terminal (ikke alle som gjør det)
if (userInput == null)
{
  throw new Exception("No input found!");
}

Console.WriteLine(userInput);

