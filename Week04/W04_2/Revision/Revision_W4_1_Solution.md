# Revision

## Overloading
- What is a method signature?
    > The unique identification of a method. It includes the method's name and the parameter list (the number, types, and order of parameters). The return type is not considered part of the method signature.
- What is method overloading?
    > Method overloading allows multiple methods to share the same name but have different signatures. This enables methods to perform similar tasks with different inputs.
- Why would you use method overloading?
    > To provide flexibility in how a method is called, depending on the input. For example, you might want to handle different types of data or different numbers of parameters while keeping the method name consistent. 
- What is constructor overloading?
    > It allows a class to have more than one constructor with different parameters. This enables different ways of initializing an object.
- Why would you use constructor overloading?
    > So that we can have different ways of initializing an object.
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
    > The second constructor is a parameterless constructor that uses the `this` keyword to call the first constructor with default values ("Unknown" for Name and 0 for Age). 

## Inheritance
- What does the word inheritance mean in English?
    > The process of receiving something (such as property, money, or traits) from a predecessor, typically from a parent or ancestor.
- What does the word Polymorphism mean in English?
    > From Greek, "poly" meaning many and "morph" meaning form or shape. So, polymorphism means "many forms."
- What does inheritance mean in C#?
    > inheritance allows one class to inherit the data and methods of another class. 
- Why would you use inheritance?
    > To allow a new class to extend the functionality of an existing class. Inheritance promotes code reuse, makes it easier to maintain and extend code.
- What is a base class?
    > A base class (sometimes called a parent class) is a class whose data and methods are inherited by another class. 
- What is a derived class?
    > A derived class (sometimes called a child class) is a class that inherits from a base class.
- How do you denote that a class inherits from another class?
    > You use a colon (:) after the derived class name, followed by the base class name: `Student : Person`
- How many classes can a class inherit from?
    > A class can inherit from one base class only.
- How can you call the base class's constructor from the derived class?
    > You can call the base class's constructor using the `base` keyword.
- Given that the `Student` class inherits from the `Person` class, are there any issues with the following code? 
`Person test = new Student();`
    > It is valid code but you should be aware that you can access all `Person` members, but not `Student`-specific members.