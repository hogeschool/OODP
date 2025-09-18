# Week 05

## Day 1 (W05_2)

### Contents: interfaces
* Implementing (W05.2.1T01)
* Implementing multiple interfaces (W05.2.1T02) <- You can't do this with inheritance
* Interfaces with properties (W05.2.1T03)
* Interface objects (W05.2.1T04) <- Here it gets interesting
* Interface inheritance (W05.2.1T05)
* Classes with interface as members (W05.2.1T06)
* Derived class that implements an interface

### Introduction files
If you use Visual Studio Code, you can igore the .sln and .csproj files; just download the CS files and run them as separate projects. You can remove the namespaces as well.
If you use Visual Studio, you can download the files and put them in the same structure as they have been committed to GitHub. Then the IDE lets you choose which namespace to run through a dropdown menu at the top of the screen.

### But WHY use interfaces?
HIGHLY recommended watch: https://www.youtube.com/watch?v=4sxyDXt1igs

Inheritance forces you in a tree-like structure. For example:
```
           Machine
          /       \
 CopyingMachine  NetworkRouter
```

Interfaces let you say: "_Any class that promises to implement this interface will provide this functionality._"

For example:

```csharp
public interface IAuthenticate
{
    void Login(string password);
}
```

Now both `CopyingMachine` and `NetworkRouter` can implement it:

```csharp
public class CopyingMachine : Machine, IAuthenticate { ... }
public class NetworkRouter : Machine, IAuthenticate { ... }
```

And now you pass objects of both these classes to this method:
```csharp
public static void LoginService(IAuthenticate authenticator)
{
    Console.WriteLine("Please provide your password:");
    string providedPassword = Console.ReadLine();
    authenticator.Login(providedPassword);
}

CopyingMachine cm = new();
NetworkRouter nr = new();
LoginService(cm);
LoginService(nr);
```

Instead of being forced into one tree, interfaces let you connect classes across different branches. It’s more like a web than a tree.
-> **Inheritance is about what something _is_**
-> **interfaces are about what something _has_ or _can_**