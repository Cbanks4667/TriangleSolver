using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/* CBAssignment2
 * 
 * 
 * TriangleSolver Class Library
 * 
 * Revision History:
 * Chris Banks Created: Feb 6th 2017
 * 
 */
 /// <summary>
 /// Triangle Solver Project
 /// </summary>
namespace TriangleSolver.Tests
{
    /// <summary>
    /// TriangleSolverTests Class
    /// </summary>
    [TestFixture]
    public class TriangleSolverTests
    {
        /// <summary>
        /// test for Scalene Triangle no sides equal
        /// </summary>
        [Test]
        public void analyzeMethod_Given_1_2_3_ResultIs_Scalene()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(1, 2, 3);
            //Assert
            Assert.AreSame("Scalene", result);
        }
        /// <summary>
        /// test for Isosceles triangle b == c != a
        /// </summary>
        [Test]
        public void analyzeMethod_Given_1_2_2_ResultIs_Isosceles()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(1, 2, 2);
            //Assert
            Assert.AreSame("Isosceles", result);
        }
        /// <summary>
        /// test for Isosceles triangle a == c != b
        /// </summary>
        [Test]
        public void analyzeMethod_Given_4_1_4_ResultIs_Isosceles()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(4, 1, 4);
            //Assert
            Assert.AreSame("Isosceles", result);
        }
        /// <summary>
        /// test for Isosceles triangle a == b != c
        /// </summary>
        [Test]
        public void analyzeMethod_Given_5_5_2_ResultIs_Isosceles()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(5, 5, 2);
            //Assert
            Assert.AreSame("Isosceles", result);
        }
        /// <summary>
        /// test for Equilateral triangle a == b == c
        /// </summary>
        [Test]
        public void analyzeMethod_Given_8_8_8_ResultIs_Equilateral()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(8, 8, 8);
            //Assert
            Assert.AreSame("Equilateral", result);
        }
        /// <summary>
        /// test for invalid input a + b < c
        /// </summary>
        [Test]
        public void analyzeMethod_Given_5_2_100_ResultIs_Invalid()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(5, 2, 100);
            //Assert
            Assert.AreSame("Invalid", result);
        }
        /// <summary>
        /// test for invalid input b + c < a
        /// </summary>
        [Test]
        public void analyzeMethod_Given_100_5_2_ResultIs_Invalid()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(100, 5, 2);
            //Assert
            Assert.AreSame("Invalid", result);
        }
        /// <summary>
        /// test for invalid input a + c < b
        /// </summary>
        [Test]
        public void analyzeMethod_Given_5_100_2_ResultIs_Invalid()
        {
            //Arrange
            string result = "";
            //Act
            result = CBAssignment2.TriangleSolver.Analyze(5, 100, 2);
            //Assert
            Assert.AreSame("Invalid", result);
        }
    }
}
