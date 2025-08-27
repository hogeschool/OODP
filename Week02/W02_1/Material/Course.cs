/*
Model the following:
A course has a name and an amount of credits associated with it. 
We want to be able to see this information in the following format:
The Course OODP is worth 13 credits

class Course:
    def __init__(self, name, credits):
        self.Name = name
        self.Credits = credits

    def Info(self):
        return f"The Course {self.Name} is worth {self.Credits} credits"

*/
public class Course
{
    // Fields
    public string Name;
    public int Credits;

    // Constructor (this)
    public Course(string name, int credits)
    {
        this.Name = name;
        this.Credits = credits;
    }
    
    // Methods - notice no static
    public string GetInfo()
    {
        return $"The Course {this.Name} is worth {this.Credits} credits";
    }
}