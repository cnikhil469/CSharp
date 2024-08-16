using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projectCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine(); 
            int x = 10,
                y = 20,
                z = 30;
            int f;
            double val = 25.000D;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(decimal.MinValue);
            string str = "this is string variable!!";
            char ch = 'a';
            Console.Write(str);
            Console.WriteLine(ch);
            string v1 = "1234567788987";
            string v2 = "1234567890";
            string v3 = "-224424";
            string v4 = "-3.654";
            string v5 = "-1.452";

            decimal v6 = Convert.ToDecimal(v1);
            long v7 = Convert.ToInt64(v2);
            int v8 = Convert.ToInt32(v3);
            float v9 = Convert.ToSingle(v4);
            double v10 = Convert.ToDouble(v5);
            Console.WriteLine(v6);
            Console.WriteLine(v7);
            Console.WriteLine(v8);
            Console.WriteLine(v9);
            Console.WriteLine(v10);
            int h = 50;
            h *= 10;
            Console.WriteLine(h);
            decimal d = 98522M;
            d++;
            Console.WriteLine(d);
            //usage of var. 

            //var b = 12345;
            //usage of const variable
            const int k = 50;
            //k = 90;
            Console.WriteLine(k);
            //calulating the 2 sets of remainders task
            int a = 100;
            int b = 20;
            double c = b % a;
            Console.WriteLine(c);
            b = 25;
            //c = a % b;
            Console.WriteLine(c);

            //readline practice
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("you entered this: ");
            Console.WriteLine(name);


            //string concatination
            string age = Console.ReadLine();
            Console.WriteLine("My name is " + name + " and my age is " + age);
            //conversion of age
            int ageInt = Convert.ToInt32(age);
            Console.WriteLine(ageInt);
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age2);

            //justchecking one impl of if statement.
            var a1 = Convert.ToInt32(Console.ReadLine());
            var b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the value of " + a1 + "*" + b1 + ": ");
            var c2 = Convert.ToInt32(Console.ReadLine());
            var c1 = a1 * b1;
            if (c1 == c2)
            {
                Console.WriteLine("Yahoo!!");
            }
            else
            {
                Console.WriteLine("Try again");
            }
            //Console.WriteLine(c1);

            //switch case statement
            Console.Write("enter a number such that 1 <= number <= 8");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            switch(dayNum)
            {
                case 1:
                    Console.WriteLine("mon");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Wed");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                case 8:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("give a 1 <= number <= 8");
                    break;
            }
            Console.Write("repetition word? ");
            string word = Console.ReadLine();
            Console.Write("how many times? ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("number > 0");
            }
            else {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();
        }
    }
}
