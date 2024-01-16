public class Program
{
    public static void Main(string[] args)
    {
        //Part 1
        Basic();

        SetOperations(); //as part1 or 2
        Limit();        // as part1 or 2

        //Part2
        withClases();

        // More info: https://csharpexercises.com/linq
    }

    private static int GetCount(int[] arr, Func<int, bool> predicate)
    {
        int count = 0;
        foreach (var item in arr)
            if (predicate(item)) count++;

        return count;
    }
    private static int[] Filter(int[] arr, Func<int, bool> predicate)
    {
        //Get count first
        int count = GetCount(arr, predicate);
        int[] newArr = new int[count];
        int destIndex = 0;
        foreach (int item in arr)
        {
            if (predicate(item))
            {
                newArr[destIndex++] = item;
            }
        }
        return newArr;
    }

    static void Basic()
    {
        //1. For any given data array, list, file, database, etc
        int[] arr = new int[] { 1, 2, -3, 0, 4, -8, 9, 5, -5, 5 };

        //Q1 Count positive numbers
        //Solution 1.a Traditional way looping through with for or foreach
        int positiveCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                positiveCount++;
        }

        //How about count zeros, count non-zeros, count negative, count grater than x, smaller than y
        //Solution 1.b Reusing forloop as method with lambda expression
        positiveCount = GetCount(arr, x => x > 0);
        int negativeCount = GetCount(arr, x => x < 0);
        //You may come up with any sort of lambda predicate of the form Fun<int, bool> to pass and get the result.

        //Solution 1.c LINQ 
        positiveCount = arr.Count(x => x > 0);
        negativeCount = arr.Count(x => x < 0);

        //Q2. Get all positive/negative/non-zero etc number list
        //Solution 2.a Traditional way.
        var newArr = Filter(arr, _ => _ != 0); //All non-zero

        //// ask to write Map, and then call Filter().Map() or Map(Filter()), beware of null

        //How about all non-zero no-duplicate values?
        //How about absolute non-duplcaite values...etc?
        //Solution 2.b LINQ
        newArr = arr.Where(x => x != 0).ToArray();
        newArr = newArr.Distinct().ToArray();
        newArr = arr.Where(x => x != 0).Distinct().ToArray();
        newArr = arr.Select(_ => Math.Abs(_)).Distinct().ToArray();
        newArr = arr.Select(_ => Math.Abs(_)).Distinct().OrderBy(_ => _).ToArray();

        //Talk about return type and lazy evaluation here
        //Above example why ToArray()? What if we don't do ToArray()
        IEnumerable<int> X = arr.Where(x => x != 0); //Must ask for lazy evail in debug view.


        var Y = arr.Where(x => x != 0).Distinct().TakeLast(3);
        var Z = Y.ToList(); // to array or to list or anything

        foreach (var item in Y)
            Console.WriteLine(item);
        foreach (var item in Z)
            Console.WriteLine(item);

        //Modify source
        arr[arr.Length - 2] = 10;

        foreach (var item in Y)
            Console.WriteLine(item);
        foreach (var item in Z)
            Console.WriteLine(item);

        //Working with Generics (smiplest)
        var Names = new List<string> { "Alpha", "BeTa", "gamma", "Delta", "CharliE" };
        bool flag = Names.Contains("delta");
        flag = Names.Select(_ => _.ToLower()).Contains("deLta".ToLower());
        var SomeNames = Names.SkipWhile(_ => _ != "gamma").Skip(1); //Why skip(1)
        SomeNames = Names.Take(new Range(2, 4));
        string OneName = Names.First();     //First(_ => _ == "bob");
        OneName = Names.FirstOrDefault(_ => _ == "BOB", "No BOB"); //.FirstOrDefualt("Bob");
    }
    static void withClases()
    {

        // Working with classes

        Simple[] siList = new Simple[] { new(1, "One"), new(0, "Zero"), new(3, "Three"), new(-2, "Minus Two"), new(3, "Three") };

        siList.Count(_ => _.I <= 0);

        int number = siList.Sum(_ => _.I);
        number = (int)siList.Average(_ => _.I);
        number = siList.Aggregate(1, (a, obj) => a * obj.I);
        number = siList.Where(_ => _.I != 0).Aggregate(1, (a, obj) => a * obj.I);

        string ag = siList.Select(_ => _.S).Aggregate("", (acc, obj) => acc + " " + obj);


        //Part 2: LINQ with classes

        //Student class
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Enrollment> enrollments = new List<Enrollment>();

        //Generate data
        DataFactory(students, courses, enrollments);

        //for debugging
        foreach (Enrollment en in enrollments)
        {
            Console.WriteLine($"{en.Student.Name} , {en.Course.Title}, {en.Grade}");
        }


        //Q1. Course Enrollment and Grades for given sutdent
        string str = string.Join(',', enrollments.Where(_ => _.Student.Name == "Whatever").Select(_ => _.Course.Title + " " + _.Grade));
        //Query expression
        var abc = from indenr in enrollments
                  where indenr.Student.Name == "Whatever"
                  select indenr.Student.Name + "" + indenr.Grade;

        //Query expression translates into method expression
        //Method expression
        var xyz = enrollments.Where(_ => _.Student.Name == "Whatever").Select(_ => _.Course.Title + " " + _.Grade);


        var distinctTitle = enrollments.DistinctBy(_ => _.Course.Title).Select(_ => _.Course.Title);
        foreach (var item in distinctTitle)
        {
            enrollments.Where(_ => _.Course.Title == item).ToList().ForEach(_ => Console.WriteLine(_.Student.Name));
        }

        var whatever = from x in enrollments
                       group x by x.Course.Title;

        var whateveragain = enrollments.GroupBy(_ => _.Course.Title).Select(_ => _.Key + _.Count() + string.Join(',', _.ToList()));
        string whateveragainString = string.Join(',', whateveragain);

        foreach (var item in whatever)
        {
            Console.WriteLine($"{item.Key}{item.Count()}");
            foreach (var j in item)
                Console.WriteLine($"{j.Student.Name}, {j.Grade} ");
        }



        var StudentCourses = enrollments.Where(en => en.Student.Name == "Steve").ToList();
        StudentCourses.ForEach(en =>
                Console.WriteLine($"{en.Course.Title}, {en.Grade}")
            );

        //Q2. Find Passing rate of each course or given course a passing grade is 5
        //Q2.1 Find Indivdual in each course 
        var CoursePassingRate = from IndEnrollment in enrollments
                                group IndEnrollment by IndEnrollment.Course; //into toomuch

        foreach (var item in CoursePassingRate)
        {
            Console.WriteLine($"+{item.Key.Title}");
            foreach (var subItem in item)
                Console.WriteLine($"---{subItem.Student.Name}");
        }

        //Q3. Calcualte Average (Comulative) Grade of a student
        var avgStudentGrade = from en in enrollments
                              group en by en.Student into further
                              select new { further.Key, Values = enrollments.Where(_ => _.Student == further.Key) };

        foreach (var item in avgStudentGrade)
        {
            Console.WriteLine($"+{item.Key.Name},===>{Math.Round(item.Values.Average(_ => _.Grade), 2)}");
            foreach (var subItem in item.Values)
                Console.WriteLine($"---{subItem.Course.Title}, --- {subItem.Grade}");
        }



        //Talk about LINQ query and method (optional)

        //Group by and Distinct

    }
    private static void DataFactory(List<Student> students, List<Course> courses, List<Enrollment> enrollments)
    {
        students.Add(new Student(1, "John", 18));
        students.Add(new Student(2, "Steve", 21));
        students.Add(new Student(3, "Bill", 18));
        students.Add(new Student(4, "Ram", 20));
        students.Add(new Student(5, "Abram", 21));


        courses.AddRange(new List<Course>() { new Course(1, "Python"), new Course(2, "OOP"), new Course(3, "Database") });

        //Generate Random Enrollments
        Random rand = new Random();
        while (enrollments.Count() <= 10)
        {
            enrollments.Add(new Enrollment(
                students[rand.Next(5)],
                courses[rand.Next(3)],
                Math.Round(10 * rand.NextDouble(), 1)
                ));
        }
    }

    static void SetOperations()
    {
        //1. Union
        var List1 = new List<int> { 1, 2, 3, 5, 7, 9 };
        var List2 = new List<int> { 1, 2, 3, 4, 6, 8 };

        Console.Write("List1:  ");
        List1.ForEach(x => Console.Write(x));

        Console.Write("\nList2:  ");
        List2.ForEach(x => Console.Write(x));

        var RList = List1.Union(List2).ToList();
        Console.WriteLine("\nUnion:");
        RList.ForEach(_ => Console.Write("{0} ", _));

        Console.WriteLine("\nUnion: (Sorted):");
        RList.OrderBy(_ => _).ToList().ForEach(_ => Console.Write("{0} ", _));

        //2. Intersect
        RList = List1.Intersect(List2).ToList();
        Console.WriteLine("\nIntersection");
        RList.ForEach(_ => Console.Write("{0} ", _));

        //3. Except
        RList = List1.Except(List2).ToList();
        Console.WriteLine("\nExcept L1 except L2");
        RList.ForEach(_ => Console.Write("{0} ", _));

        RList = List2.Except(List1).ToList();
        Console.WriteLine("\nExcept L2 except L1");
        RList.ForEach(_ => Console.Write("{0} ", _));
    }
    static void Limit()
    {
        ICollection<int> Data = new List<int> { -1, 3, -2, 0, 2, 5, -7, 8 };
        int firstPositive = Data.FirstOrDefault(_ => _ > 0);
        int GreaterThan10 = Data.First(_ => _ > 1)!; //exception if no matching element
        int lastNegative = Data.Last(_ => _ < 0);
        Console.WriteLine("First Positive: {0}, Greter Than Ten: {1}, Last Negative: {2}", firstPositive, GreaterThan10, lastNegative);

        IEnumerable<int> last3 = Data.TakeLast(3);
        last3.ToList().ForEach(_ => Console.Write($"{_} "));

        var last2Positive = Data.Where(_ => _ > 0).TakeLast(2);
        last2Positive.ToList().ForEach(Console.Write);

        IEnumerable<int> first3 = Data.Take(3);
        IEnumerable<int> first2_4 = Data.Take(new Range(2, 4));
        IEnumerable<int> last4_2 = Data.Take(new Range(Data.Count - 5, Data.Count - 3));
        IEnumerable<int> tillZero = Data.TakeWhile(_ => _ != 0);
        IEnumerable<int> positiveAfterZero = Data.SkipWhile(_ => _ != 0).TakeWhile(_ => _ >= 0);
        IEnumerable<int> skip2take3 = Data.Skip(2).Take(3);
    }
}