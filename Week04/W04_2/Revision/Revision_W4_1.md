# Revision

## Overloading
- What is a method signature?
- What is method overloading?
- Why would you use method overloading?
- What is constructor overloading?
- Why would you use constructor overloading?
- What is happening in the second constructor in this code?
    ```csharp
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person() : this("Unknown", 0) { }
    }
    ```

## Inheritance
- What does the word inheritance mean in English?
- What does the word polymorphism mean in English?
- What does inheritance mean in C#?
- Why would you use inheritance?
- What is a base class?
- What is a derived class?
- How do you denote that a class inherits from another class?
- How many classes can a class inherit from?
- How can you call the base class's constructor from the derived class?
- Given that the `Student` class inherits from the `Person` class, are there any issues with the following code? 
`Person test = new Student();`