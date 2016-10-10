using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1

{
    class Program
    {
        static void Main(string[] args)

       {   
          // 1 - Area of the Rectangle

            decimal a = GetPositiveDecimal("Enter value of 'Side 1' : ", "Wrong Entry Repeat", "The number must be greater than 0 ");
            decimal b = GetPositiveDecimal("Enter value of 'Side 2' : ", "Wrong Entry Repeat", "The number must be greater than 0 ");
            decimal area = Rectangle(a, b);
            Console.WriteLine("The area of the  regtangle '{0}' x '{1}' equals : {2}" ,a,b,area);
            Console.ReadLine();

            // 2 - Multiplication table
            
            int no = GetPositiveInteger("Enter a number for the 'multiplication table' : ", "Wrong Entry Repeat", "The number must be greater than 0 "); ;
            Multi_table(no);
            
            // 3 - Arrays Max, Min, Average 

            
            int ArrSize = GetPositiveInteger("Enter the size of the Array of integers : ", "Wrong Entry Repeat", "The number must be greater than 0 ");
            int [] arr = new int[ArrSize];
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                int NumI = 0;
                do
                {
                    Console.Write("Enter the next element " + (i + 1) + " / " + arr.Length + " :");
                    string s = Console.ReadLine();
                    string[] inputs = s.Split();
                    if (inputs.Length > 1)
                    {
                        Console.WriteLine("Wrong Entry Repeat");
                    }
                    else
                    {

                        if (int.TryParse(inputs[0], out NumI))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Entry, Repeat");
                        }
                    }

                } while (flag);
                arr[i] = NumI; 
                Console.WriteLine("\r");
            }
            int MaxElement = Maximum(arr);
            int MinElement = Minimum(arr);
            decimal AvElement = Aver(arr);
            Console.WriteLine("The Max Element of the Array is : "+ MaxElement);
            Console.WriteLine("The Min Element of the Array is : " + MinElement);
            Console.WriteLine("The Average value of the Array is : " + AvElement);

            Console.ReadLine();

        }

        static decimal Rectangle(decimal x, decimal y)
        {
            decimal result = x  *  y;
            return result;
        }
        static void Multi_table(int number)
        {
            for (int i = 1; i <= number; i ++)
            {
                for (int j =1; j <=  number; j ++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
        static int Maximum(int [] arr)
        {
            int MaxResult = arr.Max();
            return MaxResult;
        }
        static int Minimum(int[] arr)
        {
            int MinResult = arr.Min();
            return MinResult;
        }
        static decimal Aver(int[] arr)
        {
            int sum = arr.Sum();
            decimal AvResult = (decimal)sum / arr.Length;
            return AvResult;
        }

        static decimal GetPositiveDecimal(string s1,string s2, string s3)
        {
            decimal EntDecimal = 0;
            bool fl = true;
           
            do
            {
                Console.Write(s1);
                string s = Console.ReadLine();
                string[] inputs = s.Split();
                if (inputs.Length > 1)
                {
                    Console.WriteLine(s2);
                }
                else
                {
                    if (decimal.TryParse(inputs[0], out EntDecimal))
                    {
                        if (EntDecimal <= 0)
                        {
                            Console.WriteLine(s2);
                            Console.WriteLine(s3);
                        }
                        else
                        {
                            fl = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine(s2);
                    }
                }

            } while (fl);
            return EntDecimal;
        }

        static int GetPositiveInteger(string s1, string s2, string s3)
        {
            int EntInt = 0;
            bool fl = true;

            do
            {
                Console.Write(s1);
                string s = Console.ReadLine();
                string[] inputs = s.Split();
                if (inputs.Length > 1)
                {
                    Console.WriteLine(s2);
                }
                else
                {
                    if (int.TryParse(inputs[0], out EntInt))
                    {
                        if (EntInt <= 0)
                        {
                            Console.WriteLine(s2);
                            Console.WriteLine(s3);
                        }
                        else
                        {
                            fl = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine(s2);
                    }
                }

            } while (fl);
            return EntInt;
        }

    }
}
