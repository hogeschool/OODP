using System.Linq;
namespace WK13_1_5;

class Program
{
  // Start first with non generic functions: string instead of T

  public static int MyCount<T>(T[] arrin, Func<T,bool> predicate)
  {
    int count=0;
    for (int i=0;i<arrin.Length;i++){
      if (predicate(arrin[i])){
        count++;
      }
    }
    return count;    
  }
  
  public static U[] MyMap<T,U>(T[] arrin,Func<T,U> func)
  {
    U[] arrout = new U[arrin.Length];
    for (int i=0;i<arrout.Length;i++){
      arrout[i]=func(arrin[i]);
    }
    return arrout;
  }
  
  public static T[] MyFilter<T>(T[] arrin, Func<T,bool> predicate)
  {
    
    int sizeFilteredArray=MyCount(arrin,predicate);
    
    T[] arrout = new T[sizeFilteredArray];
    for (int i=0, j=0;i<arrin.Length;i++){
      if (predicate(arrin[i])){
        arrout[j++]=arrin[i];
      }      
    }
    return arrout;
  }
  
  /* We could make this one even more generic (two types) but it would be too complex
     since we would need to give two functions as input. The extra function as 
     input would need to manage the case when the array only has one element.
     This is too complex for now, so I chose to show you the function with only one 
     generic type.
  */
  public static T MyAggregate<T>(T[] arrin, Func<T,T,T> func)
  {
    if (arrin==null||arrin.Length==0) return default(T);
    //if there is only one element, there is nothing to aggregate
    if (arrin.Length==1) return arrin[0];
    
    //aggregate first two elements
    T res = func(arrin[0],arrin[1]);

    //aggregate the remaining elements to res, one by one
    for(int i=2;i<arrin.Length;i++){
      res = func(res,arrin[i]);
    }
    return res;
  }

  static void Main(string[] args)
  {
    string[] myCars = new string[]{"Tesla","Ford","Renaul","BMW","Audi","Citroen"};
    int[] myNums = new int[]{1,5,3,-2,5,4,0,8};
    
    var res1 = MyMap(myCars,s => "My Car: " + s);
    var res2 = MyMap(myNums,x => x*2);

    var res3 = MyFilter(myCars, s => s.Contains("e"));
    var res4 = MyFilter(myNums, x => x%2==0);

    var res5 = MyAggregate(myCars,(s1,s2)=>s1+"-"+s2);
    var res6 = MyAggregate(myNums,(n1,n2)=>n1+n2);

    // BUILDUP for LINQ (week 14)
    // Using Linq, we can do the same but the returned type is an enumerable, 
    // not an array. 
    // To convert output to array, use .ToArray()
    // To convert output to list, use .ToList()
    // Debug program to see
    var mapWithLinq = myCars.Select(s => "Car=>" + s).ToArray();;
    var filterWithLinq = myCars.Where(s=>s.Length<=4).ToList();
    var aggregatedResultLinq = myCars.Aggregate((s1,s2)=>s1+"+"+s2);
  }
}
