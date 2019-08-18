using System;

namespace Erankyun
{
    class Program
    {
        static void Main(string[] args)
        {
           erankyun(7);
        }

        static String astgh(int k)
        {
            if (k <= 0)
            {
                return "";
            }
            return "* " + astgh(k - 1);
        }



         static String bacat (int l) {
          if (l <=0) {
             return "";
          }
          return "  " +bacat(l-1) ;
        }
          static void miacum  (int x,int z,int y) {
            if (x <= 0) {
               return;
            }
                  Console.WriteLine(bacat(y)+astgh(z));
                    miacum((x-1),(z+2),(y-1));
          }
           
           static void erankyun(int n) {
                 miacum(n,1,n);
            }
    
          
    }
}