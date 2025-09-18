## Day 1 (W06_1)

### Contents:
* abstract methods & overriding them (W06.1.1T01-02)
* List of abstract class objects (W06.1.1T03)

### But WHY abstract classes?
An `abstract` class cannot be instantiated. In other words, you cannot make objects of an abstract class. But why make such a class?

You can still inherit from an abstract class. For example, you could do this:
```csharp
abstract class Animal
{
    public string Name { get; }
    public int Age { get; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }
}
```

Now we can do this:
```csharp
static class Vet // Dierenarts
{
    public static readonly List<Animal> animalsToTreat = [];

    public static void AddAnimalToTreat(Animal animal)
    {
        animalsToTreat.Add(animal);
    }
}
```

Usage examples:
```csharp
Vet.AddAnimalToTreat(new Dog("Rex", 5));
Vet.AddAnimalToTreat(new Cat("Whiskers", 3));

// This would be meaningless if Animal were not abstract:
Animal mystery = new Animal("Mystery", 7); // Compiler error
```

-> **Abstract classes are for when you want to group things together under one type, but you never want the base type itself to be used directly.**

### But WHY abstract methods?  
Sometimes you want every subclass to share the same data (like `Name` and `Age`), **but also guarantee that they all implement certain behavior**.  

That’s what `abstract` methods are for.  
- They **have no body** in the abstract class.  
- Every subclass is **forced** to override them.  

For example:  

```csharp
abstract class Animal
{
    public string Name { get; }
    public int Age { get; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Every animal must implement this:
    public abstract void MakeSound();
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound() => Console.WriteLine("Woof!");
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound() => Console.WriteLine("Meow!");
}
```

---

#### Why this is useful  

Because `MakeSound()` is abstract, we can now call it on any `Animal` without knowing its exact type:  

```csharp
static class Vet
{
    public static readonly List<Animal> animalsToTreat = [];

    public static void AddAnimalToTreat(Animal animal)
    {
        animalsToTreat.Add(animal);
    }

    public static void HearAllAnimals()
    {
        foreach (var animal in animalsToTreat)
        {
            animal.MakeSound(); // Works for both Dog and Cat
        }
    }
}
```

Usage:  

```csharp
Vet.AddAnimalToTreat(new Dog("Rex", 5));
Vet.AddAnimalToTreat(new Cat("Whiskers", 3));

Vet.HearAllAnimals();
// Output:
// Woof!
// Meow!
```

---

### Takeaway  

- **Abstract classes** are for grouping shared data and behavior.  
- **Abstract methods** are for forcing subclasses to provide their own specific implementation.  

-> Use them together to model "things that are the same in some ways, but different in others."