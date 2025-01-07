using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
          public static int Add(int a, int b)
            {
                return a + b;
            }
        
        
            public static double Add(double c, double d)
            {
                return c + d;
            }


            public static string Add(int a, int b, bool haveMoney)
            { 
             if (haveMoney == true && (a + b) > 1 )
                { 
                    return $"{a + b} dollars";
                }
            else if (haveMoney == true && (a + b) == 1)
                { 
                    return $"{a+b} dollar";
                }
            else if (haveMoney == true && (a + b) < 1)
                {
                    return $"{a} + {b} cents";
                }
            else 
                {
                    return "No money";
                }  
            }  
        
        static void Main(string[] args)
        {
           var a = 23;
           var b = 4;
           var c = 23.93453;
           var d = 12.45445;



           var answer = Add(a, b);

           Console.WriteLine(answer);

           var decimalAnswer = Add(c, d);

           Console.WriteLine(decimalAnswer);

           var boolAnswer = Add(a, b, true);

           Console.WriteLine($"{boolAnswer}");
         }   

    }
}

