/*
Contents:
 - jagged arrays (W10.2.C01-02)
 - multidimensional arrays (W10.2.C03-04)
 - string methods 
	-> https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0#methods
    Some string methods to mention:
        - Contains, Trim, Split, Length, Substring, 
        - IsNullOrEmpty, ToUpper, ToLower
*/

public class Program
{
  static void Main()
  {
    JaggedArrays();
    NDimArrays();
    Exercises();
  }

  // each dimension can have different sizes.
  // each row can have different lengths
  static void JaggedArrays(){
    int[][] jarr1;                  // outer array will be bound to null
    jarr1 = new int[3][];
    int[][] jarr2 = new int[4][];   // will make space for 4 inner arrays, but each inner array will be bound to null
    jarr2[0] = new int[]{1,2,3,5,2};
    int[][] jarr3 = new int[][]{   // will make space for 4 inner arrays, and each inner array will make space for 5 and 2 elements respectively, but each element will be the default value for int (which is 0)
        new int[5],
        new int[]{1,5,3,6}
    };
    
    string[][] jarr4 = new string[][]{    // outer and inner arrays are filled with values;
      new string[]{"milk","cheese","yogurt","zuuroom"},
      new string[]{"potato","tomato","pastinaak","spinazie","tomato","carrot"},
      new string[]{"toilet paper","toothbrush"}
    };                             
    //Accessing element    
    Console.WriteLine( jarr4[1][3] );
    //Accessing element
    Console.WriteLine( jarr4[0][2] );

    // Looping through array. We need nested loops
    // One loop to loop through the rows and the other through the columns
    for (int i=0;i<   jarr4.Length    ;i++){
      Console.Write($"i={i}: ");
      for (int j=0; j <    jarr4[i].Length    ;j++){
        Console.Write(jarr4[i][j]+",");
      }
      Console.Write("\n");
    }
  }

  // Multidimentional. Each dimension has the same size.
  static void NDimArrays(){
    int[,] ndimarr;

    int[,] ndimarr2 = new int[2,3];
    
    //3dimensions. For example to store a 3d image.
    int[,,] ndimarr4 = new int[4,2,3]; 

    string[,] ndimarr3 = new string[,]{
      {"hi","good morning","thank you"},
      {"ola","bom dia","obrigada"},
      {"ciao","bongiorno","grazie"},
      {"hoi","goedemorgen","bedankt"},
    };

    // Get element
    Console.WriteLine(ndimarr3[3,2]);

    // To get the lenght of each dimension we should use
    //   .GetLength(N) where N is the dimension.
    //   each dimension has the same length / every row has the same length
    for (int i=0;i<ndimarr3.GetLength(1);i++){
      Console.Write($"i={i}: \n");
      for (int j=0;j<ndimarr3.GetLength(0);j++){
        Console.Write($"j={j}={ndimarr3[j,i]} ");
      }
      Console.Write("\n");
    }
  }

  static void Exercises(){
    string[][] jarr4 = new string[][]{    // outer and inner arrays are filled with values;
      new string[]{"milk","A","cheese","yogurt","A"},
      new string[]{"potato","tomato","pastinaak","spinazie","tomato","carrot"},
      new string[]{"toilet paper","A","toothbrush"}
    };
    // create a copy of the array
    string[][] jarres0 = ExercisesJaggedArrays.CopyJaggedArray(jarr4);
    // Add element at end of jagged array (last row and last column)
    string[][] jarres1 = ExercisesJaggedArrays.AddElement(jarr4,"showergel");
    // Add element at the end of a Row
    string[][] jarres2 = ExercisesJaggedArrays.AddElementRow(jarr4,"showergel",1);
    // remove all elements equal to elem from all inner arrays
    // output inner array will then be shorter when elem(s) are removed
    string[][] jarres3 = ExercisesJaggedArrays.RemoveElement(jarr4,"A");
    string[][] jarres4 = ExercisesJaggedArrays.RemoveElement(jarr4,"pastinaak");
    // replace elements in the position given by the indexes
    string[][] jarres5 = ExercisesJaggedArrays.ReplaceElement(jarr4,"paprika",1,4);  
  

    //Do similar functions but now with NDimensional arrays
  }
}
