using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Number1;
            Int32 Number2;
            Int32 TmpNumber;
            String Operator;

            Console.WriteLine("Whoo-hoo, this is my first Application");

            Console.Write("Enter your 1st numberic number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0} as your 1st number",Number1);
            Console.WriteLine();

            Console.Write("Enter your 2nd numberic number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0} as your 2nd number",Number2);
            Console.WriteLine();

            Console.WriteLine("GREAT!, now what would you like to do with these numbers? ");
            Operator = Console.ReadLine();

            if (Operator != "")
            {
                switch(Operator)
                {
                    case "+":
                        Double.Parse(Number1);

                        TmpNumber = Convert.ToInt32(Number1 + Number2);
                        Console.WriteLine("{0} {1} {2} = {4}",Convert.ToInt32(Number1), Convert.ToString(Operator), Convert.ToInt32(Number2), TmpNumber);
                    break;
                    case "-":
                        TmpNumber = Convert.ToInt32(Number1 + Number2);
                        Console.WriteLine("{0} {1} {2} = {4}", Convert.ToInt32(Number1), Operator, Convert.ToInt32(Number2), Convert.ToDecimal(TmpNumber));
                    break;
                    case "*":
                        TmpNumber = Convert.ToInt32(Number1 * Number2);
                        Console.WriteLine("{0} {1} {2} = {4}", Convert.ToInt32(Number1), Operator, Convert.ToInt32(Number2), Convert.ToDecimal(TmpNumber));
                    break;
                    case "/":
                        if(Number1 > Number2)
                        {
                            TmpNumber = Convert.ToInt32(Number1 / Number2);
                            Console.WriteLine("{0} {1} {2} = {4}", Convert.ToInt32(Number1), Operator, Convert.ToInt32(Number2), Convert.ToDecimal(TmpNumber));
                        }
                        else
                        {
                            TmpNumber = Convert.ToInt32(Number2 / Number1);
                            Console.WriteLine("{0} {1} {2} = {4}", Convert.ToInt32(Number2), Operator, Convert.ToInt32(Number1), Convert.ToDecimal(TmpNumber));
                        }
                    break;
                }
            }

            
            Console.ReadKey();


        }
    }
}
