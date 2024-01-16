# Week 03

## Day 1 (W03_1)

### Contents:

PART 1: static
*  static fields (W03.1.C01)
*  static methods (W03.1.C02)
*  static classes (W03.1.C03)
*  W03.1.C04: what concepts did you just use?
*  W03.1.C05: ??? (solve the bug)

PART 2: const
*  const fields (W03.1.C06-08)

PART 3
*  readonly fields (W03.1.C09-10)

## Day 2 (W03_2)

### Contents:

Unit testing (MSTest):
* How to run the example Jukebox test project
* Setting up a new test project and running unit tests
* Test attributes
* Asserts
* Data-driven unit tests
* Best practices & references

### How to use the 'jukebox-testing.zip'
* Unzip the contents of the 'jukebox-testing.zip' on your machine.
* Go to the 'JukeboxTest/W03_2.JukeboxTest.cs' on how to introduce the mstest unit testing concepts.
* Student instruction: The 'jukebox-testing.zip' can be handed-out to the students. 
* Instruct them to read and try-out the instructions explained in the 'JukeboxTest/W03_2.JukeboxTest.cs' file for themselves.


### How to run the example Jukebox test project ##
The 'Jukebox' folder contains the project with the source code to be tested. The 'JukeboxTest' folder contains the test project with the unit test class. The 'JukeboxTest.csproj' contains a reference to the location of the Jukebox project so mstest knows where to find the source code, so make sure this points to the right location!
To run the JukeboxTest project, execute the 'dotnet test' command inside the JukeboxTest project folder in the terminal of Visual Studio Code or another command line interface. The test execution will have run correctly if you see in the output that the 7 tests have 'Passed'.

### Setting up a new test project and running unit tests  ##
1. The following instructions will create a new mstest project in a new folder (e.g. SampleTest):
    /> dotnet new mstest -o SampleTest
2. Change the current directory to go into the newly created folder for the mstest project:
    /> cd SampleTest
3. Add a reference to the project which contains the source code you want to test (e.g. a console application named SampleProject):
    /> dotnet add reference ../SampleProject/SampleProject.csproj
4. Execute the test command:
    /> dotnet test

###  Test attributes ##
Some examples of test attributes are:
* [TestClass]
* [TestMethod]
* [DataTestMethod]
* [DataRow]

See the CheatsheetTest.cs file for more examples of test attributes.

### Asserts ## 
Some examples of Assert methods are:
* Assert.AreEqual
* Assert.IsTrue
* Assert.IsNull
* Assert.IsNotNull

See the CheatsheetTest.cs file for more examples of Assert class methods.

### Data-driven unit tests ##
The following methods are examples of data-driven unit tests:
- TestAddSongs
- TestAddSongsDynamicDataMethod
See the CheatsheetTest.cs file for more examples of Data-driven unit tests.

### Best practices & references ##
* https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
* https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0
* https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?view=visualstudiosdk-2022

Now try to create some more tests for yourself! (W03.2.C01)