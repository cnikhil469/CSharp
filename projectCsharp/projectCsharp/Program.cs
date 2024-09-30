using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;
using System.Security.Cryptography;
using System.Security.AccessControl;

namespace projectCsharp
{
    class Test
    {
        static void Hello1()
        {
            Console.WriteLine("hello!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();


            //{
            //    //Console.WriteLine("Hello World!");
            //    //Console.ReadLine(); 
            //    int x = 10,
            //        y = 20,
            //        z = 30;
            //    int f;
            //    double val = 25.000D;
            //    //Console.WriteLine(x);
            //    //Console.WriteLine(y);
            //    //Console.WriteLine(z);
            //    //Console.WriteLine(int.MaxValue);
            //    //Console.WriteLine(int.MinValue);
            //    //Console.WriteLine(double.MaxValue);
            //    //Console.WriteLine(double.MinValue);
            //    //Console.WriteLine(float.MaxValue);
            //    //Console.WriteLine(float.MinValue);
            //    //Console.WriteLine(long.MaxValue);
            //    //Console.WriteLine(long.MinValue);
            //    //Console.WriteLine(decimal.MaxValue);
            //    //Console.WriteLine(decimal.MinValue);
            //    string str = "this is string variable!!";
            //    char ch = 'a';
            //    Console.Write(str);
            //    Console.WriteLine(ch);
            //    string v1 = "1234567788987";
            //    string v2 = "1234567890";
            //    string v3 = "-224424";
            //    string v4 = "-3.654";
            //    string v5 = "-1.452";

            //    decimal v6 = Convert.ToDecimal(v1);
            //    long v7 = Convert.ToInt64(v2);
            //    int v8 = Convert.ToInt32(v3);
            //    float v9 = Convert.ToSingle(v4);
            //    double v10 = Convert.ToDouble(v5);
            //    Console.WriteLine(v6);
            //    Console.WriteLine(v7);
            //    Console.WriteLine(v8);
            //    Console.WriteLine(v9);
            //    Console.WriteLine(v10);
            //    int h = 50;
            //    h *= 10;
            //    Console.WriteLine(h);
            //    decimal d = 98522M;
            //    d++;
            //    Console.WriteLine(d);
            //    //usage of var. 

            //    //var b = 12345;
            //    //usage of const variable
            //    const int k = 50;
            //    //k = 90;
            //    Console.WriteLine(k);
            //    //calulating the 2 sets of remainders task
            //    int a = 100;
            //    int b = 20;
            //    double c = b % a;
            //    Console.WriteLine(c);
            //    b = 25;
            //    //c = a % b;
            //    Console.WriteLine(c);

            //    //readline practice
            //    Console.WriteLine("enter your name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("you entered this: ");
            //    Console.WriteLine(name);


            //    //string concatination
            //    string age = Console.ReadLine();
            //    Console.WriteLine("My name is " + name + " and my age is " + age);
            //    //conversion of age
            //    int ageInt = Convert.ToInt32(age);
            //    Console.WriteLine(ageInt);
            //    int age2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(age2);

            //    //justchecking one impl of if statement.
            //    var a1 = Convert.ToInt32(Console.ReadLine());
            //    var b1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("What is the value of " + a1 + "*" + b1 + ": ");
            //    var c2 = Convert.ToInt32(Console.ReadLine());
            //    var c1 = a1 * b1;
            //    if (c1 == c2)
            //    {
            //        Console.WriteLine("Yahoo!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again");
            //    }
            //    //Console.WriteLine(c1);

            //    //switch case statement
            //    Console.Write("enter a number such that 1 <= number <= 8");
            //    int dayNum = Convert.ToInt32(Console.ReadLine());

            //    switch (dayNum)
            //    {
            //        case 1:
            //            Console.WriteLine("mon");
            //            break;
            //        case 2:
            //            Console.WriteLine("tue");
            //            break;
            //        case 3:
            //        case 4:
            //            Console.WriteLine("Wed");
            //            break;
            //        case 5:
            //            Console.WriteLine("Thursday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 7:
            //            Console.WriteLine("Saturday");
            //            break;
            //        case 8:
            //            Console.WriteLine("Sunday");
            //            break;
            //        default:
            //            Console.WriteLine("give a 1 <= number <= 8");
            //            break;
            //    }
            //    Console.Write("repetition word? ");
            //    string word = Console.ReadLine();
            //    Console.Write("how many times? ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num <= 0)
            //    {
            //        Console.WriteLine("number > 0");
            //    }
            //    else
            //    {
            //        for (int i = 0; i < num; i++)
            //        {
            //            Console.WriteLine(word);
            //        }
            //    }

            //    //while loop implementation

            //    int abc = 0;
            //    while (abc <= 0)
            //    {
            //        abc = Convert.ToInt32(Console.ReadLine());
            //    }

            //    //do while implementation
            //    int ans, ans2;
            //    do
            //    {
            //        ans = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("what's " + ans + " * " + ans);
            //        ans2 = Convert.ToInt32(Console.ReadLine());
            //        if (ans == ans2)
            //        {
            //            Console.WriteLine("Yahoo!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("try again!!");
            //        }
            //    } while (ans != ans2);
            //    //numeric formating
            //    double zxc = -853.235645897D;
            //    Console.WriteLine("{0:0.00} * {1}", zxc, 456);

            //    //tryparse impl
            //    Console.WriteLine("tryparse impl now");
            //    bool success = true;
            //    do
            //    {
            //        Console.Write("input a float with a char: ");
            //        string numInp = Console.ReadLine();
            //        if (float.TryParse(numInp, out float flInp))
            //        {
            //            success = false;
            //            Console.WriteLine(flInp);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Try again");
            //        }
            //    }
            //    while (success);
            //    int q = 1;
            //    int e = 2;
            //    Console.WriteLine($"hello this is Nikhil {q} + {h} = {q + h}");
            //    Console.WriteLine(string.Concat("hello ", "this is ", "aloha", q));
            //    string p = "hello this is Nikhil";
            //    char g = 'i';
            //    bool aloha = false;
            //    for (int i = 0; i < p.Length; i++)
            //    {
            //        if (p[i].Equals(g))
            //        {
            //            Console.WriteLine("yes, it has 'x' in it.");
            //            aloha = true;
            //            break;
            //        }
            //    }
            //    if (!aloha) Console.WriteLine("No, it doesn't 'x' have in it");
            //    string r = string.Empty;
            //    if (string.IsNullOrEmpty(r)) Console.WriteLine("yes, itw working!!");

            //    //print string in reverse
            //    Console.Write("enter a string to print that in reverse ");
            //    string str1 = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(str1))
            //    {
            //        for (int i = str1.Length - 1; i >= 0; i--)
            //        {
            //            Console.Write(str1[i]);
            //            Thread.Sleep(250);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a proper string nexttime!!");
            //    }
            //    //password matching
            //    string str2 = "Enter a proper pwd";
            //    Console.Write(str2);
            //    string str3 = Console.ReadLine();
            //    while (string.IsNullOrEmpty(str3))
            //    {
            //        Console.WriteLine(str2);
            //        str3 = Console.ReadLine();
            //    }
            //    string str4 = Console.ReadLine();
            //    while (string.IsNullOrEmpty(str4))
            //    {
            //        Console.WriteLine(str2);
            //        str4 = Console.ReadLine();
            //    }
            //    if (str4.Equals(str3))
            //    {
            //        Console.WriteLine("Yahoo!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No....");
            //    }
            //    //arrays.
            //    //input around 10 numbers from user and print the array having all even nums from that. 
            //    Console.WriteLine("input the count of nums");
            //    int cnt = Convert.ToInt32(Console.ReadLine());
            //    int[] nums = new int[cnt];
            //    int value = 0;
            //    for (int i = 0; i < cnt; i++)
            //    {
            //        value = Convert.ToInt32(Console.ReadLine());
            //        if (value % 2 == 0)
            //        {
            //            nums[i] = value;
            //        }
            //    }
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        Console.Write(nums[i]);
            //        Thread.Sleep(250);
            //    }
            //    ////Foreach impl
            //    //int[] nums1 = new int[5] { 1, 2, 3, 4, 5 };
            //    //foreach (int i in nums1)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //    ////Sorting of an Array
            //    //Console.WriteLine("provide the count for the array");
            //    //int cnt3 = Convert.ToInt32(Console.ReadLine());
            //    //int[] nums2 = new int[cnt3];
            //    //for (int i = 0; i < cnt3; i++)
            //    //{
            //    //    nums2[i] = Convert.ToInt32(Console.ReadLine());

            //    //}
            //    //Array.Sort(nums2);
            //    //foreach (int i in nums2)
            //    //{
            //    //    Console.Write(i);
            //    //    Thread.Sleep(250);
            //    //}
            //    //Array.Reverse(nums2);
            //    //foreach (int i in nums2)
            //    //{
            //    //    Console.Write(i);
            //    //    Thread.Sleep(250);
            //    //}
            //    //Console.WriteLine("Array printing now");
            //    //int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            //    //Array.Clear(nums, 3, 3);
            //    //foreach (int i in nums)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //    //Console.WriteLine(Array.IndexOf(nums, 4));
            ////}
            ////Array Concept
            //Console.ReadLine();
            //}
            //int[] nums = new int[] { 'h', 5, 6, 2, 3, 5, 8, 9, 7, 4 };
            //int pos = Array.IndexOf(nums, 7, 2, 5);
            //Console.WriteLine(pos);
            ////List Concepts
            //List<int> nums = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    nums.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //Console.WriteLine($"The max number in the list is {nums.Max()}"); 
            ////Dictionary Concepts
            //Dictionary<int, string> numStrings = new Dictionary<int, string>
            //{
            //    {1, "Hello" },
            //    {2, "Aloha" },
            //    {3, "Finland" }
            //};
            //foreach (var item in numStrings)
            //{
            //    Console.Write($"The key is '{item.Key}' and value is '{item.Value}'");
            //    Console.WriteLine();
            //}
            //KeyValuePair<int, string> pair = numStrings.ElementAt(1);
            //Console.WriteLine($"The key is '{pair.Key}' and value '{pair.Value}'");
            //////TryGetValue with dict
            //if (numStrings.TryGetValue(1, out string hello))
            //{
            //    Console.WriteLine($"the out value is {hello}");
            //}
            //else
            //{
            //    Console.WriteLine("The item with that key is not found!!");
            //}
            //////ContainsKey() & Remove() impl
            //if(numStrings.ContainsKey(1)) {
            //    numStrings.Remove(1);
            //}
            //Console.WriteLine("printing all the items");
            //foreach (var item in numStrings)
            //{
            //    Console.Write($"The key is {item.Key} and value is {item.Value}");
            //}

            ///*

            //* Create two lists with integer data type, one for even numbers, one for odd

            //* Loop from 0-20

            //* if number is even, add to even list

            //* if number is odd, add to odd list

            //* Print even list

            //* Print odd list

            //*/
            //List<int> evenNums = new List<int>();
            //List<int> oddNums = new List<int>();
            //for (int i = 0; i < 21; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        evenNums.Add(i);
            //    }
            //    else
            //    {
            //        oddNums.Add(i);
            //    }
            //}
            //Console.WriteLine("Printing Even nums");
            //Console.WriteLine( );
            //foreach (var item in evenNums)
            //{
            //    Console.Write($"{item} ");
            //    Thread.Sleep(250);
            //}
            //Console.WriteLine("Printing Odd nums");
            //Console.WriteLine();
            //foreach (var item in oddNums)
            //{
            //    Console.Write($"{item} ");
            //    Thread.Sleep(250);
            //}

            ///*

            //* Define and initialise two integers (num, length)

            //* (7,5) -> [7, 14, 21, 28, 35]

            //* Create int array with size length

            //* loop through and insert the (loop counter x num) into the array

            //* print the final array

            //*/
            //int multiplier = Convert.ToInt32(Console.ReadLine());
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[] intArr = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    intArr[i] = i * multiplier;
            //}

            //foreach (int value in intArr)
            //{
            //    Console.Write($"{value} ");
            //}

            //Console.ReadLine();

            //* Create int array with size length

            //* loop through and insert the (loop counter x num) into the array

            //* print the final array

            //*/
            //int multiplier = Convert.ToInt32(Console.ReadLine());
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[] intArr = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    intArr[i] = i * multiplier;
            //}

            //foreach (int value in intArr)
            //{
            //    Console.Write($"{value} ");
            //}

            ////Classes concept
            //    public class Person
            //{
            //    public string Name;
            //    public int Age;

            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello, " + Name);
            //    }
            //  }
            ////Exceptions
            //try 
            // {
            //int result = 10 / 0;
            // } 
            //catch (DivideByZeroException ex) 
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            //Console.Write("Enter the numer ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the len of array ");
            //int len = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[len];
            //for (int i = 0; i < len; i++)
            //{
            //    arr[i] = num * i;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //    Thread.Sleep(250);
            //}
            ////functions
            //int addValue = AddNumbers(5, 4);
            //Console.WriteLine($"The result is {addValue}");
            //int g = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"aloha {g}");
            ////public int Add(int a, int b)
            ////{
            ////    return a + b;
            ////}
            ////public double Add(double a, double b)
            ////{
            ////    return a + b;
            ////}
            //Hello();
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int h = AddNumbers(a, b);
            //Console.WriteLine($"The sum of {a} and {b} is {h}");

            //Console.Title = name;
            //printName();
            ////implementing the string and int values in dictionary
            //int h = 5;
            //Dictionary<int, string> intStringDict = new Dictionary<int, string>();
            //for (int i=0; i<h; i++)
            //{
            //    intStringDict[randonNumber()] = randomString();
            //}
            //foreach(var item in intStringDict)
            //{
            //    Console.WriteLine($"key: {item.Key}, value: {item.Value}");
            //}
            //int[] arr = randomArray();
            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            ////function parameters concept; 
            string myName = inpString("Enter your name: ");
            int age = inpAge("Enter your age: ");
            string userDetails = nameAge(myName, age);
            Console.WriteLine(userDetails);
            Console.ReadLine();
        }
        //static void Hello()
        //{
        //    Console.WriteLine("Hello World!!");
        //}
        //static int AddNumbers(int a, int b)
        //{
        //    return a + b;
        //}
        static string inpString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        static int inpAge(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
        static string nameAge(string name, int age)
        {
            return $"my name is {name} and my age is {age}";
        }
        static string name = "aloha";
        static void printName()
        {
            Console.WriteLine(name);
        }
        static int randonNumber()
        {
            Console.WriteLine("enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string randomString()
        {
            Console.WriteLine("enter a string");
            return Console.ReadLine();
        }
        static int[] randomArray()
        {
            int[] arr = new int[5];
            for (int i=0; i<5;  i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }
    
}    
