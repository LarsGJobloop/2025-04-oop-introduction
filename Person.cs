class Person
{
  // Egenskaper/Properties
  public string Name;
  // List<string> Interests;

  // Ting objektet/personen kan gjøre
  // void SayHello() { }
  // void ListInterests() { }

  // Hvordan ett nytt person objekt skal konstrueres
  public Person(string name)
  {
    if (name.Length < 1)
    {
      throw new Exception("Name must contain at least 1 character!");
    }
    Name = name;
  }
}