/*
 Contents:
  - Value types vs Reference types
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types

  - Tuples/ValueTuples (W11.1.C01-C03)
    https://learn.microsoft.com/en-us/dotnet/api/system.tuple?view=net-7.0
    https://learn.microsoft.com/en-us/dotnet/api/system.valuetuple?view=net-7.0

  - Arrays: creation (W11.1.C04)
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays

  - Arrays: Length & accessing elements (W11.1.C05-C06)

    Not covered; should speak for itself:
  - Arrays: Sort & Reverse (W11.1.C07)

*/

public class Program
{
  static void Main()
  {
    Tuples();
    Arrays();
    ArraysAndReferences();
  }

  static void Tuples(){
    /*
    Reference type tuples can be instantiated in two ways:
        - keyword new 
        - Tuple.Create
    Value Tuples are created using the () brackets
    */

    //  Reference Tuple Option 1
    Tuple<int,string> myRefTup1 = new Tuple<int,string>(1,"one");
    //  Reference Tuple Option 2
    Tuple<int,string,bool> myRefTup2 = Tuple.Create(2,"two",false);
    //  ValueType tuple
    (int,string) myValueTup3 = (3,"three");
    
    //Accessing Elements using .Item#
    Console.WriteLine(myRefTup1.Item1);
    Console.WriteLine(myValueTup3.Item2);
    
    /*
    Only possible to change elements in ValueTuples.

    Reference Tuples are read-only. We can not chance elements
    in Reference Tuples, but we can create a new tuple with one
    element changed and the others the same.
    */
    
    myValueTup3.Item1 = 8;
    myValueTup3.Item2 = "eight";

    //myRefTup1.Item1 = 7;        //ERROR
    //myRefTup1.Item2 = "seven";  //ERROR
    myRefTup1 = Tuple.Create(7,"seven");

  }


//Arrays
  static void Arrays(){
    /*
      An array is reference type
    */

    int[] arr1 = new int[]{ 1, 2, 3, 4 };
    
    int[] arr2 = { 5, 6, 7, 8 , 9 };
    
    double[] arr10 = new double[5];
    
    Tuple<bool,float>[] arr11 = new Tuple<bool,float>[3];
    arr11[0] = new Tuple<bool, float>(true,2.45f);
    arr11[1] = new Tuple<bool, float>(false,-56.2f);
    
    string[] arr3 = new string[]{"one","two","three","twenty"};
    
    Tuple<string,int>[] arr4 = new Tuple<string,int>[]{
      Tuple.Create("hi",1),
      Tuple.Create("hello",2),
      Tuple.Create("ola",3)
    };

    //Access elements with []
    Console.WriteLine(arr3[1]);
    
    //Get length of array using arrayName.Length
    Console.WriteLine(arr3.Length);

    //Loop through array using index and for loops
    for(int i=0; i<arr3.Length ;i++){
      Console.WriteLine($"Index {i}: {arr3[i]}");
    }

    for(int i=0;i<arr4.Length;i++){
      Console.WriteLine($"Index {i}: {arr4[i].Item2}");
    }
  }

  static void ArraysAndReferences(){
    /* 
    We can not change the size of an array. In order to add one element
    to an array, we need to create a completely new array that has 
    space for an extra element:
     (NewArrayLength = OriginalArrayLenght+1).

    BUT we can change the elements of the array! 
    Very important: don't forget the array is stored by reference.
    So if we have multiple variables pointing to the same instance 
    of the array, changing one element will affect all variables 
    pointing to the array. (Show power point slides)
    */
    string[] myGarden = new string[]{"potato","tomato","courgette"};
    //this does not create a new array, it just creates a new reference
    string[] newGarden = myGarden; 
    string[] grandpaGarden = myGarden;
    //DEBUG: This will change myGarden,newGarden and GrandpaGarden
    grandpaGarden[1] = "paprika";

    string[] arr20 = ChangeFirstElementArray(grandpaGarden);
    string[] arr21 = ChangeFirstElementArrayWithoutChangingOthers(grandpaGarden);
  }

  // This function takes as a parameter a REFERENCE:
  //  arrin stores a reference to an array. So if we change 
  //  that array, it will influence all variables pointing
  //  to that array.
  static string[] ChangeFirstElementArray(string[] arrin){
    if (arrin==null||arrin.Length<1) return null;
    arrin[0]="pastinaak";
    return arrin;
  }

  static string[] ChangeFirstElementArrayWithoutChangingOthers(string[] arrin){
    if (arrin==null||arrin.Length<1) return null;
    string[] arrout = new string[arrin.Length];
    for (int i=0;i<arrout.Length;i++){
      arrout[i]=arrin[i];
    }
    arrout[0]="pompoen";
    return arrout;
  }
}