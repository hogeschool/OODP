namespace WK13_1_4;

class Program
{

  public static int AddThree(int a, int b, int c){
    return a+b+c;
  }

  public static void Lambdas(){
    Func<int,int,int> sumTwo = (x,y) => x+y;
    // I can also give it a long body
    // As opposed to Python we can have anonymous functions with many lines of code
    Func<int,int,int,int> sumThree = (x,y,z) => 
    {
      int sum = x+y+z;
      return sum;
    };

    Func<int,int,bool> areEqual = (x,y) => x==y;
    Func<int,bool> isEven = x => x%2==0;
    // We can have lambdas that do not take parameters as input
    Func<string> returnSomething = () => "Something!";

    // We can also have lambdas that do not return anything
    // They are called
    // Action instead of Func    
    
    Action<string> PrintHelloName = n => Console.WriteLine("Hello, "+n+"!");
    Action printHelloWorld = () => Console.WriteLine("Hello world!");
    
    //Lets call the previous lambdas here

  }
  
  public static void Currying(){
    //Curried lambda
    Func<int,Func<int,Func<int,int>>> SumThreeCurryLambda = a=>b=>c=>a+b+c;
    Func<int,Func<int,int>> myIntermediateFunction = SumThreeCurry(3);
    Func<int,int> mySecondIntermediateFunction = myIntermediateFunction(4);
  }
  
  //Curried method
  public static Func<int,Func<int,int>> SumThreeCurry(int a){
    Func<int,int> AddB(int b){
      int AddC(int c){
        return a+b+c;
      }
      return AddC;
    }
    return AddB;
  }

  static void Main(string[] args)
  {
    Lambdas();
    //Currying();
  }
}
