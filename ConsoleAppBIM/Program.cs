using ConsoleAppBIM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBIM
{
    //struct Point
    //{
    //   public int x;
    //   public int y;

    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}

    public interface IBank
    {
        // only method signature
        void Deposit(int AccountNo, double Amount);
        void Withdraw(int AccountNo, double Amount);
        bool TransferAmount(int SenderAccountNo, int ReceiverAccountNo, double Amount);
    }

   public class Account
    {
        int accountNo;
        string name;
        double balance;

        public Account(int accountNo, string name, double balance)
        {
            this.AccountNo = accountNo;
            this.Name = name;
            this.Balance = balance;
        }

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string Name
        {
            get => name;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null.");
                }
                name = value;
            }
        }
        public double Balance { get => balance;

            set
            {
                if (value<0)
                {
                    throw new Exception("Balance cannot be negative.");
                }
                balance = value;
            }
        }
    }
    class IsBank : IBank
    {
        List<Account> Customers;

        public IsBank()
        {
            Customers = new List<Account>();
        }
        public void CreateAccount( string name, double balance = 0.0)
        {
            try
            {
                Account account = new Account(Customers.Count + 1, name, balance);
                Customers.Add(account);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in creating account. \n" + ex.Message);
            }
        }

        public void Display()
        {
            try
            {
                foreach (var cust in Customers)
                {
                    Console.WriteLine($"Acc. No. = {cust.AccountNo}, Name = {cust.Name}, Balance = {cust.Balance}");
                }
            }
            catch (Exception)
            {
                throw new Exception("Error in display method.");
            }
        }
        public int SearchAccountByID(int AccountNo)
        {
            int Id = -1;
            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].AccountNo==AccountNo)
                {
                    Id = i;
                    break;
                }
            }

            return Id;
        }
        public void Deposit(int AccountNo, double Amount)
        {
            try
            {
                var index = SearchAccountByID(AccountNo);
                if (index==-1)
                {
                    throw new Exception("Account No is invalid.");
                }

                if (Amount<=0)
                {
                    throw new Exception("Amount cannot be zero or less.");
                }

                Customers[index].Balance += Amount;

            }
            catch (Exception ex)
            {
                throw new Exception("Error in depositing amount \n" + ex.Message);
            }
        }

        public bool TransferAmount(int SenderAccountNo, int ReceiverAccountNo, double Amount)
        {
            try
            {
                var indexSender = SearchAccountByID(SenderAccountNo);
                var indexReceiver = SearchAccountByID(ReceiverAccountNo);

                if (indexSender == -1 || indexReceiver==-1)
                {
                    throw new Exception("Sender / Receiver Account No is invalid.");
                }

                if (Amount <= 0)
                {
                    throw new Exception("Amount cannot be zero or less.");
                }

                if (Customers[indexSender].Balance < Amount)
                {
                    throw new Exception("Balace is not sufficient.");
                }

                Customers[indexSender].Balance -= Amount;
                Customers[indexReceiver].Balance += Amount;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in depositing amount \n" + ex.Message);
            }
        }

        public void Withdraw(int AccountNo, double Amount)
        {
            try
            {
                var index = SearchAccountByID(AccountNo);
                if (index == -1)
                {
                    throw new Exception("Account No is invalid.");
                }

                if (Amount <= 0)
                {
                    throw new Exception("Amount cannot be zero or less.");
                }

                if (Customers[index].Balance<Amount )
                {
                    throw new Exception("Balace is not sufficient.");
                }

                Customers[index].Balance -= Amount;

            }
            catch (Exception ex)
            {
                throw new Exception("Error in Withdraw amount \n" + ex.Message);
            }
        }
    }

    class AkBank : IBank
    {
        public void Deposit(int AccountNo, double Amount)
        {
            throw new NotImplementedException();
        }

        public bool TransferAmount(int SenderAccountNo, int ReceiverAccountNo, double Amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int AccountNo, double Amount)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        
        
        static void Main(string[] args)
        {

            try
            {

                Student s = new Student();
                s.Address = new Address("Istanbul", "12345", "Halkali 102", "Turkey");

                //IsBank isBank = new IsBank();
                //isBank.CreateAccount("Akhtar Jamil");
                //isBank.CreateAccount("Ali",500);
                //isBank.CreateAccount("Hasan", 200);

                //isBank.Display();
                ////isBank.Deposit(1, -100);
                ////isBank.Withdraw(2, 200);
                //if (isBank.TransferAmount(2, 3, 300))
                //{
                //    Console.WriteLine("Money transferred successfully.\n");
                //}
                //isBank.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Student s = new Student();
            //s.ViewNotification();

            //Employee se = new Employee();
            //se.ViewNotification();


            //Point p;
            //p.x = 10;
            //p.y = 20;




            // Week: 5 -2


            //Student s = new Student();
            //Employee e = new Employee();

            //Console.WriteLine(e.Login("admin", "123"));
            //Console.WriteLine(s.Login("admin", "1234"));

            //s.Logout(s);
            // Polymorphism
            //Person p1 = new Employee();
            //Person p2 = new Student();


            //Student s = new Student(1,"Ali","hasan","Male","ali@izu","123",1,101,1200);
            //s.Display();

            //s.FirstName = "Muhammad Ali";
            //s.LastName = "Khan";
            //s.Display();
            //Console.WriteLine(s.getFirstName());
            //s.setFirstName("Muhammad Ali");
            //Console.WriteLine(s.getFirstName());
            //s.Display();

            // Object Oriented Programming
            //overloading: same name but different parameters
            //Student s1 = new Student();

            //Employee e = new Employee();
            //Dean d = new Dean();
            //s1.studentID = 100;
            //s1.firstName = "Ehsan";
            //s1.lastName = "Ali";
            //s1.gender = "Male";

            //s2.studentID = 101;
            //s2.firstName = "Hande";
            //s2.lastName = "Baladin";
            //s2.gender = "Female";

            //Console.WriteLine($"ID= {s1.studentID}, Name = {s1.firstName} {s1.lastName}," +
            //    $" Gender = {s1.gender}");

            //Console.WriteLine($"ID= {s2.studentID}, Name = {s2.firstName} {s2.lastName}," +
            //    $" Gender = {s2.gender}");
            // exception/error handling Try-Catch
            // every try must have a catch
            // ABC
            //try
            //{
            //    // odev: research about File class's function
            //    string path2 = @"F:\test-1.txt";
            //    //string data = File.ReadAllText(path2);
            //    string []data= File.ReadAllLines(path2);
            //    foreach (string s in data)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error in reading file.");
            //}

            //if (File.Exists(path2))
            //{
            //    File.Delete(path2);
            //}
            //StreamWriter writer = new StreamWriter(path2,false);

            //try
            //{

            //    writer.WriteLine("Hello Computer Engineers.");
            //    writer.WriteLine("Hello Software Engineers.");
            //    writer.WriteLine("Hello IZU.");
            //    writer.WriteLine("Welcome to Visual Programming.");
            //    Console.WriteLine("Created Successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    writer.Close();
            //}

            //string path = @"F:\test.txt";
            //StreamReader reader = new StreamReader(path);
            //try
            //{
            //    string str = reader.ReadToEnd();
            //    Console.WriteLine(str);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    reader.Close();
            //}

            // bir try ile 1 ve birden fazla catch olabilir
            //try
            //{

            //    int []ar =new  int[]{ 1,2,3};
            //    //string str = "15xxx";
            //    //int num = int.Parse(str);

            //    Console.WriteLine(ar[5]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata Oldu." + ex.Message);
            //}

            //List<string> list = new List<string> {"Ali Halid","Yasin Sahin","Anila Polani",
            //    "Husain Haqqani", "Nisa Nur"
            //};

            //DisplayList(list);
            //Console.WriteLine(SearchByName("A", list));
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Contains("Ali"));

            //int[] numbers = new int[] {60,50,100,5,34,75 };

            //List<int> temparray =  numbers.ToList();
            //temparray.Sort();

            //var arr = temparray.ToArray();
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(20);
            //list.Add(5);
            //list.Add(-7);
            //list.Add(-5);


            ////Console.WriteLine("Average = {0}", list.Average());
            ////Console.WriteLine("Sum = {0}", list.Sum());
            ////Console.WriteLine("Maximum = {0}", list.Max());
            ////Console.WriteLine("Minimum = {0}", list.Min());
            ////Console.WriteLine("Contain = {0}", list.Contains(20));
            ////Console.WriteLine("Count = {0}", list.Count);

            //DisplayList(list);
            ////list.Reverse();
            //list.Sort();
            //DisplayList(list);


            //Console.WriteLine($" Sum = {list.Sum()}");

            //Console.WriteLine($" Average = {list.Average()}");
            //Console.WriteLine($" Sum = {list.Sum()}");


            //DisplayList(list);
            //int[] ar = new int[] {200,300,400,500 };

            //list.AddRange(ar);

            //DisplayList(list);


            // Lambda expression
            //int num =  list.RemoveAll(x=>x<0);
            // Console.WriteLine("Deleted = " + num);
            // //list.RemoveAt(0);
            // list.RemoveRange(0, 2);

            // list.Insert(0, 30);
            // list.Add(40);
            // DisplayList(list);
            //int []array  = list.ToArray();
            // Console.WriteLine(list.Count);
            // list.Clear();
            // Console.WriteLine(list.Count);
            // list.Add(50);
            // list.Add(100);
            // list.Add(20);
            // list.Add(100);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    //Console.WriteLine(list[i]);
            //    //Console.Write(list[i] + " ");
            //    //Console.Write("{0} ",list[i]);
            //    Console.Write($"{list[i]} ");
            //}
            //bool result =  list.Remove(200);
            //if (result==true)
            //{
            //    Console.WriteLine("Sildi");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted.");
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    //Console.WriteLine(list[i]);
            //    //Console.Write(list[i] + " ");
            //    //Console.Write("{0} ",list[i]);
            //    Console.Write($"{list[i]} ");
            //}
            // Arrays

            //int[] nums = new int[] { 95,100,58,-26,54,75};

            //// while
            //int counter = nums.Length-1;

            //// break; continue;
            //while (counter>=0)
            //{
            //    if (nums[counter]<0)
            //    {
            //        //Console.WriteLine("Error: Less than 0 not allowed;");
            //        counter--;
            //        continue;
            //    }
            //    Console.WriteLine(nums[counter]);
            //    counter--;
            //}

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
        //static void DisplayList(List<int> list)
        //{
        //    foreach (int x in list)
        //    {
        //        Console.WriteLine(x + " ");
        //    }
        //}
        //static void DisplayList(List<string> list)
        //{
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item.ToUpper());
        //    }
        //}
        //static bool SearchByName(string name, List<string> list)
        //{
        //    bool result = false;
        //    foreach (var item in list)
        //    {
        //        if (item.ToLower().Contains(name.ToLower()))
        //        {
        //            result = true;
        //            break;
        //        }
        //    }

        //    return result;
        //}

    }
}
