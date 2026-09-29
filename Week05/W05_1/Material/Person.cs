/*
Take the Person class from last week and make the following modifications:

PART 1: Access modifiers
* BSN: Only accessible in this class
* Name: Any other code
* Age: Only this class and derived classes

PART 2: Properties
+---------------+------------------------------+--------------------------------+
| Property      | Read / Write                 | Notes                          |
+---------------+------------------------------+--------------------------------+
| BSN           | Read: only in this class     | What is this similar to?       |
|               | Write: Not possible once set |                                |
+---------------+------------------------------+--------------------------------+
| Name          | Read: Any other code         | Default should be "John Doe"   |
|               | Write: Only in this class    | (auto implemented property)    |
+---------------+------------------------------+--------------------------------+
| Age           | Read: inheriting classes     | Must be between 0 and 150      |
|               | Write: only in this class    | Backing field/multi line       |
+---------------+------------------------------+--------------------------------+
| ID            | Read: Any other code         | Replace the GetID method. Can  |
|               | Write: Not possible          | be changed in derived classes. |
+---------------+------------------------------+--------------------------------+

*/
public class Person
{
    private string BSN { get; } // the same as readonly (sort of)

    // string BSN { get; } // default access modifier is private

    // auto-implemented property with default value
    // public string Name { get; set; } // Public property acts just like a public field
    public string Name { get; private set; } = "John Doe";

    private int _age; // backing field

    // Multi-Line
    // protected int Age {
    //     get => _age;
    //     private set {
    //         if(value > 150){
    //             _age = 150;
    //         }
    //         else if(_age < 0){
    //             _age = 0;
    //         }
    //         else{
    //             _age = value;
    //         }
    //     }
    // }    

    // One line
    protected int Age
    {
        get => _age;
        private set => _age = Math.Clamp(value, 0, 150);
    }

    // Infinite loop; why?
    // protected int Age {
    //     get => Age;
    //     private set => Age = Math.Clamp(value, 0, 150);
    // }

    // public virtual string ID {get => $"BSN: {_bsn}";}
    public virtual string ID => $"BSN: {BSN}"; // same as above

    public Person(string bsn, string name, int age)
    {
        BSN = bsn;
        Name = name;
        Age = age;
    }

    public Person(string bsn)
    {
        BSN = bsn;
    }

    public void IncreaseAge()
    {
        Age += 1;
    }

    // public int GetAge()
    // {
    //     return Age;
    // }

    // Virtual method can be overridden 
    // public virtual string GetID()
    // {
    //     return $"BSN: {_bsn}";
    // }

    public override string ToString()
    {
        return $"BSN: {BSN}, Name: {Name}, Age: {Age}";
    }
}
