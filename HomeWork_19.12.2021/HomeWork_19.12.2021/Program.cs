using HomeWork_19._12._2021.Extensions;
using System;
using System.Text;

namespace HomeWork_19._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("\n********************* START Task -1 *********************\n");
            DeathStar deathstar = new();
            deathstar.FireLaser();
            #endregion


            #region Task 2
            Console.WriteLine("\n********************* START Task -2 *********************\n");
            Car car = new();
            car.Drive();
            #endregion

            #region Task 3

            Console.WriteLine("\n********************* START Task -3 *********************\n");
            Console.WriteLine("<<== Cumleni daxil edin ==>>");
            string str = Console.ReadLine();

            Console.WriteLine("<<== Axtarilan hisseni daxil edin ==>>");
            string word = Console.ReadLine();
            Console.WriteLine($"netice= {str.CheckWord(word)}"); 

            #endregion
           

        }
    }
}
