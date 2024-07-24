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
            //1
            int number1, i;
            string s = "";
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 1 == 0)
            {
                for (i = 2; i < number1; i++)
                {
                    if (number1 % i != 0)
                    {
                        s = "tub";
                    }
                    else
                    {
                        s = "tub emas"; break;
                    }
                }
                Console.WriteLine(s);
            }

            //2
            int l;
            l = Convert.ToInt32(Console.ReadLine());
            for(int i1=2;i1<=10;i1++)
            {
                if(l%i1==0)
                { Console.WriteLine(i1); }
            }

            //3
            int n,i3=1,a,p=1;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                while (i3 <= a)
                {
                    p *= n;
                    i3++;
                }
                Console.WriteLine($"{n}^{a}=" + p);
            }
            //4
            int h,s4=0,nn;
            Console.Write("\n to'plam elementlar soni,n=");
            nn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int j4=0;j4<nn;j4++)
            {
                Console.Write("h=");
                h = Convert.ToInt32(Console.ReadLine());
                s4 += h;
            }
            Console.WriteLine(s4);
            //5
            int num, j = 0, m = 0, ii = 0;
            num = Convert.ToInt32(Console.ReadLine());
            ii = num;
            while (num != 0)
            {
                num /= 10; j++;

            }

            num = ii;
            while (num != 0)
            {


                m += (int)Math.Pow((num % 10), j);
                num /= 10;
            }
            num = ii;
            if (num == m)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("armstrong emas");
            }

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
