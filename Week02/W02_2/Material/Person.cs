﻿/*
    A person has a first name and a last name. 
    We wish to get the name in the format 
    "[initial]. [last name]" -> for example "J. Doe" 
*/
public class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FormatName() => $"{this.FirstName[0]}. {this.LastName}";
}