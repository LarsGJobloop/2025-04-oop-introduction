Console.WriteLine("Welcome!");
Console.WriteLine("Please enter your name");

// Lese av bruker input
string? userInput = Console.ReadLine();
// Sjekk om systemet vi kjører i støtter terminal (ikke alle som gjør det)
if (userInput == null)
{
  throw new Exception("No input found!");
}

Person person = new Person(userInput);
Console.WriteLine(person.Name);
