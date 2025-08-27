Revision solutions
--------
- What color will `c1.Color` be after the following code has executed?
  ```
      Car c1 = new Car(“Red”);
      Car c2 = c1;
      c2.Color = “Green”;
  ```
  > Green since `c2` is just another reference to the object referred to by `c1`.
- What does `null` mean?
  > It is a value that indicates that there is no object reference, so it does not refer to any object.
- Given a `Person` class with a field `Name`, will this code compile? Will it run? What will happen?
  ```
  Person p = null;
  Console.WriteLine($"Name: {p.Name}");
  ```
  > It will compile and run, but it will not finish running as there will be a runtime exception. This is because a null reference exception is thrown since `p` is `null` and therefor it does not have a `Name`.
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
          Animals = new List<Animal>();
      }
  }
  ```

  > ``` 
  > Zoo rotterdamZoo = new Zoo("Rotterdam");
  > rotterdamZoo.Animals.Add(new Animal("Elephant"));
  > ```
- What is a constructor?
  > A constructor is a special method used to initialize objects of a class.
- Do you explicitly need to write a constructor for a class that you wish to use to create objects?
  > No, as withouth an explicit constructur there will be a default constructor instead.
- What value will a field have if you do not set it in the constructor?
  > The default value for that type
    - int: 0
    - double: 0.0
    - bool: false
    - string: null
    - reference types (lists, objects, etc): null