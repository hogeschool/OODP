using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace TeacherFiles_Draw;

class Program
{
  public static string DrawHollowSquare(int size){
    string draw ="";
    for (int row = 1; row <= size;row++){
      for (int col = 1; col <= size; col++){
        if (row==1||col==1|row==size||col==size)
        {
          draw += "*";
        }
        else
        {
          draw +=" ";
        }
      }
      draw+="\n";
    }
    return draw;
  }
  
  public static string DrawDiagonal(int size){
    string draw ="";
    for (int row = 1; row <= size;row++){
      for (int col = 1; col <= size; col++){
        if (row==col)
        {
          draw += "*";
        }
        else
        {
          draw +=" ";
        }
      }
      draw+="\n";
    }
    return draw;
  }
  
  public static string DrawSquare(int size){
    string draw ="";
    for (int row = 1; row <= size;row++){
      for (int col = 1; col <= size; col++){
        if (true)
        {
          draw += "*";
        }
        else
        {
          draw +=" ";
        }
      }
      draw+="\n";
    }
    return draw;
  }
  
  public static string DrawTriangle(int size){
    string draw ="";
    for (int row = 1; row <= size;row++){
      for (int col = 1; col <= size; col++){
        if (row>col)
        {
          draw += "*";
        }
        else
        {
          draw +=" ";
        }
      }
      draw+="\n";
    }
    return draw;
  }

  public static string DrawTriangleUpsideDown(int size){
    string draw ="";
    for (int row = 1; row <= size;row++){
      for (int col = 1; col <= size; col++){
        if (col>row)
        {
          draw += "*";
        }
        else
        {
          draw +=" ";
        }
      }
      draw+="\n";
    }
    return draw;
  }

  public static bool HollowSquare(int row, int col, int size){
    return row==1||col==1|row==size||col==size;
  }
  
  public static bool Diagonal(int row, int col, int size){
    return row==col;
  }
  
  public static bool Triangle(int row, int col, int size){
    return row>=col;
  }
  
  static void Main(string[] args)
  { 
    // Drawing without HOFs
    string s1 = DrawHollowSquare(5);
    string s2 = DrawHollowSquare(10);
    string s3 = DrawDiagonal(5);
    string s4 = DrawSquare(5);
    string s5 = DrawTriangle(5);
    string s6 = DrawTriangleUpsideDown(5);
    Console.WriteLine("s1\n"+s1);
    Console.WriteLine("s2\n"+s2);
    Console.WriteLine("s3\n"+s3);
    Console.WriteLine("s4\n"+s4);
    Console.WriteLine("s5\n"+s5);
    Console.WriteLine("s6\n"+s6);

    Func<int,string> DrawHollowSquareSizeN = Create_Draw_Function(HollowSquare);
    string s11 = DrawHollowSquareSizeN(5);
    Console.WriteLine(s11);
    
    Func<int,string> DrawDiagonalSizeN = Create_Draw_Function(Diagonal);
    string s12 = DrawDiagonalSizeN(4);
    Console.WriteLine(s12);

    // Now we see how lambdas came in useful. We can pass a function imediately as a parameter without having to store it anywhere else
    // This function does not have a name. It is an anonymous function.
    
    Func<int,string> DrawShapeSizeN = Create_Draw_Function((row,col,size)=> row<=col);
    Console.WriteLine(DrawShapeSizeN(4));

    DrawShapeSizeN = Create_Draw_Function((row,col,size)=> row!=col);
    Console.WriteLine(DrawShapeSizeN(5));
    
  }

  public static Func<int,string> Create_Draw_Function(Func<int,int,int,bool> requirements)
  {
    string Draw(int size){
      string drawing = "";
      for (int row=1;row<=size;row++){
        for (int col=1;col<=size;col++){
          
          if (requirements(row,col,size))
          {
            drawing+="*";
          }
          else
          {
            drawing+=" ";
          }
        }
        drawing+="\n";
      }
      return drawing;
    }
    // Here we are returning what? What is Draw? ====================> Draw is a Function.
    return Draw;
  }

}
