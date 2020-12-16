using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            bool flag= false;
            Console.WriteLine("Enter range");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=m;i<=n;i++)
            {
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    Console.WriteLine(i);
                else
                    flag = false;
            }
            
            Console.WriteLine("Edit by Shrihari Oze");
        }
    }
}
