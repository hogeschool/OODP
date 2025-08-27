Revision
--------------------------------------
* What kind of loops did we look at in the last lesson?
    > `while`, `do-while`, `for`, `foreach`
* When should you use a `while` loop?
    > When you want to repeat something an unknown number of times, but perhaps not at all
* When should you use a `do-while` loop?
    > When you want to repeat something an unknown number of times, but at least once
* When should you use a `for` loop?
    > When you want to repeat something a known number of times
* When should you use a `foreach` loop?
    > When you want to iterate through a collection to see its contents or do something (except modifying) with it
* How do we put something into a `List`?
    > `Add`
* How do we remove something from a `List`?
    > `Remove`, `RemoveAt`
* How do we put something into a `Dictionary`?
    > `Add`
* How do we remove something from a `Dictionary`?
    > `Remove`
* How can we safely check the value at a key?
    > `TryGetValue(key, out string value)`
* How can we remove everything from a `Dictionary`
    > `Clear`
* How can we generate a random number?
    > Using the `Random` class
* Given that we have already created a Random object, how can we get a random number between [0, 10)?
    > `int rNum1 = randomGenerator.Next(10);`