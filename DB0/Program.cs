using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DB0
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(5 % 2);       // int
            Console.WriteLine(-5 % 2);      // int
            Console.WriteLine(5.0 % 2.2);   // double
            Console.WriteLine(5.0m % 2.2m); // decimal
            Console.WriteLine(-5.2 % 2.0);  // double
            Console.WriteLine(110 % 10);  // zero

            Console.ReadLine(); 
            return;


            var src = Enumerable.Range(100,20000);

            var result = from num in src.AsParallel()
                         where num % 10 == 0
                         select num;

            // Process result sequence in parallel
            result.ForAll((e) => DoSomething(e));

            //foreach (var VARIABLE in result)
            //{
            //    Console.WriteLine(VARIABLE);
            //}
            Console.ReadLine(); 

            return; 
            
            var dict = new Dictionary<int, string> {{0, "this"}, {1, "this"}, {2, "this"}};

            string val;
            dict.TryGetValue(1,out val);
            if (dict.ContainsValue("this"))
            {
                Console.Write("contains");

            }
                
            
            Console.Write(val);



            var xx = new
            {

                album = "some album",
                artist = "Rush"
            };

            Console.Write("Album {0} by {1}",xx.album, xx.artist);


            try
            {
                Console.Write(ThrowEx(3, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("caught here");



            }
            catch (Exception ex)
            {
                switch (ex.GetType().ToString())
                {
                    case "System.DivideByZeroException":
                        Console.WriteLine("Divide by zero exception");
                        Console.WriteLine(ex.StackTrace);
                        break;
                }
            }
            finally
            {
                Console.ReadLine();

            }




        }

        private static void DoSomething(int i)
        {
           Console.WriteLine(i.ToString());
        }

        static int ThrowEx(int primary, int secondary)
        {

            return (primary / secondary);

        }
    }
}
