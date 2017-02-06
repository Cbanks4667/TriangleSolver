using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* CBAssignment2
 * 
 * 
 * Main Program
 * Revision History:
 * Chris Banks Created: Feb 6th 2017
 * 
 */


namespace CBAssignment2
{
    /// <summary>
    /// Program that checks wether 3 side lengths will form a valid triangle
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Program runs on load accepts string arguments as input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input = "";
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;
            do
            {
                Menu();
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        {
                            do
                            {
                                Console.WriteLine("Please enter the length of the first Side");
                                {
                                    try
                                    {
                                        sideA = int.Parse(Console.ReadLine());
                                        if (sideA > 0)
                                        {
                                            break;
                                        }                                        
                                    }
                                    catch (Exception)
                                    {

                                        Console.WriteLine("Please Enter an integer greater than 0");
                                    }
                                }
                            } while (true);

                            do
                            {
                                Console.WriteLine("Please enter the length of the Second Side");
                                {
                                    try
                                    {
                                        sideB = int.Parse(Console.ReadLine());
                                        if (sideB > 0)
                                        {
                                            break;
                                        }
                                    }
                                    catch (Exception)
                                    {

                                        Console.WriteLine("Please Enter an integer greater than 0");
                                    }
                                }
                            } while (true);

                            do
                            {
                                Console.WriteLine("Please enter the length of the Third Side");
                                {
                                    try
                                    {
                                        sideC = int.Parse(Console.ReadLine());
                                        if (sideC > 0)
                                        {
                                            break;
                                        }
                                    }
                                    catch (Exception)
                                    {

                                        Console.WriteLine("Please Enter an integer greater than 0");
                                    }
                                }
                            } while (true);
                        }
                        Console.WriteLine(TriangleSolver.Analyze(sideA, sideB, sideC)); 
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("\n Invalid menu Input");
                        }
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// displays the menu
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("\n 1. Enter triangle dimensions \n 2. Exit");
        }
    }
}
