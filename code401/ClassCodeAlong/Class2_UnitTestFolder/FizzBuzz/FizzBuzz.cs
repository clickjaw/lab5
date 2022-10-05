using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FizzBuzz{

    public class FizzBuzz{
        public static string Convert(int num){
            
            switch(num % 15){
                case 0:
                return "fizzbuzz";

                case 5:
                case 10:
                return "buzz";

                case 3:
                case 6:
                case 9: 
                case 12:
                return "fizz";

                default:
                return num.ToString();
            }

        }
    }
}