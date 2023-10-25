using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Somthing
    {
        // filds

        public string firstName;
        public string lastName;


        // constructor
        public Somthing(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        




        // method - return type

        public double someMethReturnSomthing(double z)
        {
            if(z> 0)
            {
                return z * 3;
            }
            return 0;
        }



        // method - view type

        public void showSomething() { 
            Console.WriteLine("Nazywam się: " + this.firstName + " " + this.lastName);  



        }



    }
}
