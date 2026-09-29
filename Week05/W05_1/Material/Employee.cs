/*
Take the Employee class from last week and make the following modifications:

+---------------+------------------------------+--------------------------------+
| Property      | Read / Write                 | Notes                          |
+---------------+------------------------------+--------------------------------+
| EmployeeID    | Read: only in this class     | What is this similar to?       |
|               | Write: Not possible once set |                                |
+---------------+------------------------------+--------------------------------+
| ID            | Read: Any other code         | override from Person to        |
|               | Write:   Not possible        | show BSN + Employee ID         |
+---------------+------------------------------+--------------------------------+

*/

public class Employee : Person
{
    private string EmployeeID { get; }

    public override string ID => $"{base.ID}\nEmployee ID: {EmployeeID}";

    public Employee(string bsn, string name, int age, string employeeID)
        : base(bsn, name, age)
    {
        EmployeeID = employeeID;
    }

    // Override the ToString method to include EmployeeID
    public override string ToString()
    {
        return base.ToString() + $", Employee ID: {EmployeeID}";
    }

    public double GetHourlyWage() => Age switch
    {
        15 => 4.10,
        16 => 4.72,
        17 => 5.40,
        18 => 6.84,
        19 => 8.21,
        20 => 10.94,
        _ => 13.68
    };
}
