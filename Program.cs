using System;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.
            //int n = 1;
            //int m = 23;
            //int count = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region
            //Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.

            //int n = 17;
            //int m = 0;
            //if (n<2)
            //{
            //    Console.WriteLine("1 Den boyuk eded daxil edin");
            //}
            //else if (n == 2)
            //{
            //    Console.WriteLine("Sade eded");
            //}
            //else
            //{
            //    for (int i = 2; i < i; i++)
            //    {
            //        if (n%i==0)
            //        {
            //            m = 1;
            //            break;
            //        }
            //    }
            //}
            //if (m != 1)
            //{
            //    Console.WriteLine("Sade eded");
            //}
            //else 
            //{
            //    Console.WriteLine("Nurekkeb eded");
            //}
            #endregion


            #region
            //Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

            //int n = 8;

            //while (n%2==0)
            //{
            //    n /= 2;
            //}
            //if (n == 1)
            //{
            //    Console.WriteLine("quvvetidir");
            //}
            //else
            //{
            //    Console.WriteLine("quvveti deyil");
            //}
            #endregion


            #region
            //Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
            //int n = 1234567;
            //int count =0;

            //if (n<0)
            //{
            //    n *= -1;   //Tam ededler menfi ededde ola biler deye evvelce eger menfi olarsa musbet edirik
            //}

            //if (n != 0)
            //{
            //    while (n >= 1)
            //    {
            //        n /= 10;
            //        count++;
            //    }
            //    Console.WriteLine(count);
            //}
            #endregion

            int n = 83;
            if (n%21==0)
            {
                Console.WriteLine("Bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
        }
    }
}
