using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* CBAssignment2
 * 
 * 
 * TriangleSolver Class
 * Determines if side lengths create a valid triangle
 * Revision History:
 * Chris Banks Created: Feb 6th 2017
 * 
 */
namespace CBAssignment2
{
    /// <summary>
    /// Triangle Solver Class
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// Analyzes if the inputs form a valid triangle
        /// </summary>
        /// <param name="a">The first side length</param>
        /// <param name="b">The second side length</param>
        /// <param name="c">The third side length</param>
        /// <returns></returns>
        public static string Analyze(int a, int b, int c)
        {
            
            if ((a + b) < c)
            {
                return "Invalid triangle";

            }
            else if ((a + c) < b)
            {
                return "Invalid triangle";
            }
            else if ((b + c) < a)
            {
                return "Invalid triangle";
            }

            if ((a == b) && (a == c))
            {
                return "Equilateral";
            }

            if ((a == b) || (a == c) || (b == c))
            {
                return "Isosceles";
            }

            return "Scalene";
        }
    }
}
