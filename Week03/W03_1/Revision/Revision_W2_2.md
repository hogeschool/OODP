Revision
--------
- What color will `c1`.Color be after the following code has executed?
  ```
      Car c1 = new Car(“Red”);
      Car c2 = c1;
      c2.Color = “Green”;
  ```
- What does `null` mean?
- Given a `Person` class with a field `Name`, will this code compile? Will it run? What will happen?
  ```
  Person p = null;
  Console.WriteLine($"Name: {p.Name}");
  ```
- Given the following classes, how would you add an Elephant to Rotterdam Zoo?
  ```
  public class Animal
  {
      public string Type;

      public Animal(string type)
      {
          Type = type;
      }
  }

  public class Zoo
  {
      public string City;
      public List<Animal> Animals;

      public Zoo(string name)
      {
          City = name;
          Animals = [];
      }
  }
  ```
- What is a constructor?
- Do you explicitly need to write a constructor for a class that you wish to use to create objects?
- What value will a field have if you do not set it in the constructor?