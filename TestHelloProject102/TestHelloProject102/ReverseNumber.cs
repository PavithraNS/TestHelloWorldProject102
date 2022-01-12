using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloProject102
{
    class ReverseNumber
    {
        //syntax- accessModifier static returntype methodName
        public static void FindReverseNumber()
        {
            Console.WriteLine("Please enter number to reverse");
            int number=Convert.ToInt32(Console.ReadLine()); //123 //321
            int reminder,reverse=0;
            while(number>0)
            {
                reminder=number % 10; //3 2 1
                reverse = (reverse*10)+reminder; //3 32 320+1=321
                number = number / 10; //12 1 0
            }
            Console.WriteLine("After reverse:"+ reverse);
        }
    }
}
