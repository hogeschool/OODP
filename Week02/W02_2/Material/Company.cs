﻿/*
    Company
    -------
    A Company has a name and a manager. 
    We wish to be able to get information about the 
    company in the following format:
    "Company Name: [Name]
    Manager: [initial]. [last name]"
    For Example:
    "Company Name: IT Solutions
    Manager: J. Doe"

    We should be able to get the manager and change the manager.
    
    Consider the implications of a null Manager
    Step 1: Decide if something should be nullable or not
    Step 2: Deal with null values - Adding necessary null checks.
        Option 1: Selection
        Option 2: Throw exception (Later...)
    
    A company should also have employees, 
    model this using a List
    You should be able to hire, bulk hire and 
    see the employee information in 
    the information about the company
*/
public class Company
{
    public string Name;
    public Person Manager; // Object as field

    // Classes with lists as fields
    List<Person> Employees = []; // Can be initialized here...

    public Company(string name, Person manager)
    {
        this.Name = name;
        this.Manager = manager; // Can be null

        // Employees = []; // ... or can be initialized here.
    }

    // Returning objects 
    public Person GetManager()
    {
        return Manager;
    }

    // Taking in objects
    public void SetManager(Person newManager)
    {
        Manager = newManager;
    }

    public string Information()
    {
        string info = $"Company Name: {this.Name}\n";
        // check if Manager is null
        info += $"Manager: {(Manager != null ? Manager.FormatName() : "No Manager")}\n";
        // info += $"Manager: {this.Manager.FormatName()}\n";

        info += EmployeeInformation();
        return info;
    }

    public string EmployeeInformation()
    {
        string info = "Employees:\n";
        // foreach
        foreach (Employee e in Employees)
        {
            info += e.FormatName() + "\n";
        }

        return info;
    }

    // List of objects
    public void Hire(Person newEmployee)
    {
        if (newEmployee == null)
            return;
        Employees.Add(newEmployee);
    }

    // List of objects
    public void BulkHire(List<Person> employees)
    {
        // foreach
        foreach (Employee e in employees)
        {
            Hire(e);
        }
    }
}