Console.WriteLine("Welcome!");

List<Person> group = new List<Person>();

while (true)
{
  // Lese av bruker input
  Console.WriteLine("Please enter your name. 'quit' to end.");
  string? userInput = Console.ReadLine();
  // Sjekk om systemet vi kjører i støtter terminal (ikke alle som gjør det)
  if (userInput == null)
  {
    throw new Exception("No input found!");
  }

  if (userInput == "quit")
  {
    break;
  }

  Person person = new Person(userInput);
  group.Add(person);
}

foreach (var person in group)
{
  person.SayHello();
}