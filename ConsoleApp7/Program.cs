using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan iki sayı al aldığın sayıların birincisi pozitif 2.si pozitifse topla,1p 2n ise çıkar,1n 2p ise çarp,1n 2 n ise böl
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                Console.Write(a + b);
            }
            else if(a<0 && b<0)
                Console.WriteLine(a/b);
            else if(a>0 && b<0)
                Console.WriteLine(a-b);
            else
                Console.WriteLine(a*b);


        }
    }
}
