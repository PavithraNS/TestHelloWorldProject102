
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloProject102
{
    /// <summary>
    /// Creating FibonocciSeries class inorder generate series
    /// </summary>
    /// Syntax of class- accessmodifier class className
   class FibonocciSeries
    {
        ////instance variable
        //public int first = 0;
        ////static varible
        //public static int second = 0;

        public void FindFibonocciSeries()
        {
            Console.WriteLine("Please enter how many fibonocci numbers we hav to generate");
            int number=Convert.ToInt32(Console.ReadLine()); //5
            int first=0, second = 1;
            int result = 0;
            result = first + second;
            Console.Write("{0} {1} {2}", first, second, result);
            //0 1 1 
            for (int i=3;i<number;i++)
            {//0 1 1 2 3
                first = second; //first=1 1
                second = result; //second=1 2
                result = first + second; //result=2 3
                Console.Write(" "+result);
            }
        }

    }
}
