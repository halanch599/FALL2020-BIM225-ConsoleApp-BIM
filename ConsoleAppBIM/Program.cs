using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            int[] nums = new int[] { 95,100,58,-26,54,75};

            // while
            int counter = nums.Length-1;

            // break; continue;
            while (counter>=0)
            {
                if (nums[counter]<0)
                {
                    //Console.WriteLine("Error: Less than 0 not allowed;");
                    counter--;
                    continue;
                }
                Console.WriteLine(nums[counter]);
                counter--;
            }

            //int[] nums = new int[5];
            //nums[0] = 90;
            //nums[1] = 100;
            //nums[2] = 95;
            //nums[3] = 91;
            //nums[4] = 85;

            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //Console.WriteLine(nums[i]);
            //    //sum = sum + nums[i];
            //    sum += nums[i];
            //}

            //// implicity
            //Console.WriteLine("Sum = {0}, Average = {1}",sum,(float)sum/nums.Length);
            
            // switch

            //int Day = 10;
            //switch (Day)
            //{
            //    case 0:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Wed & Tursd");
            //        break;
            //    default:
            //        Console.WriteLine("Holiday.");
            //        break;
            //}

            // Controls

            // if-else

            //int x = 10;

            //// ternary operator

            //string result = x % 2 == 0  ? "Even" : "Odd";
            //Console.WriteLine(result);

            //if (x%2==0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd.");
            //}

            //string name = "akhtar@izu.edu.tr";
            //int index = name.IndexOf('@')+1;
            //string string2 = name.Substring(index);
            //string str1 = name.Substring(0,index-1);
            //Console.WriteLine(string2);
            //Console.WriteLine(str1);
            //int index = name.IndexOf('@');
            //int indexLast = name.LastIndexOf('@');

            //if (index==-1 || index!=indexLast )
            //{
            //    Console.WriteLine("Yanlis");
            //}
            //else
            //{
            //    Console.WriteLine("Dogru");
            //}
            //Console.WriteLine(index);
            //Console.WriteLine(indexLast);

            //if (name.StartsWith("t"))
            //if (name.EndsWith("izu.edu.tr"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //if (name.ToLower().Contains("turkey"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No.");
            //}
            //Console.WriteLine(name[0]);


            //string newemail = email.Replace("$", "@");

            //Console.WriteLine(email);
            //Console.WriteLine(newemail);

            //if (email.ToLower() == "akhtar@izu.edu.tr"
            //    && password=="Abc")
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Console.WriteLine(email.ToUpper());
            //Console.WriteLine(s2.ToLower());


            //Console.WriteLine("Welcome, Bilgisayarcilar");
            //Console.Write("Enter Your email: ");
            //string email =  Console.ReadLine();

            //int len = email.Length;

            //Console.WriteLine(len);

            //if (len<6)
            //{
            //    Console.WriteLine("Email must have at least 6 charachters.");
            //}

            //Console.WriteLine("Welcome," + email);
            Console.ReadLine();
        }
    }
}
