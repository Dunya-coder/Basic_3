using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_3Github_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            //2
            int l;
            l = Convert.ToInt32(Console.ReadLine());
            for(int i1=2;i1<=10;i1++)
            {
                if(l%i1==0)
                { Console.WriteLine(i1); }
            }

            //3
            int n,i=1,a,p=1;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                while (i <= a)
                {
                    p *= n;
                    i++;
                }
                Console.WriteLine($"{n}^{a}=" + p);
            }
            //4
            int h,s=0,nn;
            Console.Write("\n to'plam elementlar soni,n=");
            nn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int j=0;j<nn;j++)
            {
                Console.Write("h=");
                h = Convert.ToInt32(Console.ReadLine());
                s += h;
            }
            Console.WriteLine(s);
            //5

            //6
            int n_6,i6=1;
            n_6 = Convert.ToInt32(Console.ReadLine());
            while (n_6 / i6 != 1)
            {
                if(n_6%i6==0)
                { Console.WriteLine(i6);
                }
                i6++;
            }

           
        

        }
    }
}
