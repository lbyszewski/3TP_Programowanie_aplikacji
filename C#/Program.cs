using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Program
    {
        static void Main(string[] args)
        {


            // output
            Console.WriteLine("cis tam");
            // input convert to user type

            int myValue = Convert.ToInt32(Console.ReadLine());

            // types
            // int, double, string, bool, char
                


            // logic and armethic

            //+ - * /  += -= *= % 
            // && || !=

            // for loop and if

            for (int i = 0; i < myValue; i++)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine("podana liczba jest podzielna przez 5" + " " + myValue );

                }
            }

            // initaliztion and array

            int suma = 0;

            int[] ints = new int[10];
            ints[0] = 5;
            ints[1] = 5;
            ints[2] = 5;
            ints[3] = 5;
            ints[4] = 5;
            ints[5] = 5;
            ints[6] = 5;
            ints[7] = 5;
            ints[8] = 5;
            ints[9] = 5;

            for (int i = 0;i < ints.Length;i++) {

                suma +=ints[i] ;
            }

            Console.WriteLine("suma elementów tablicy wynosi" + " " +  suma);

            // before console close

            Console.ReadKey();









        }
    }
}
