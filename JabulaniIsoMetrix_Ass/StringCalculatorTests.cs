using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JabulaniIsoMetrix_Ass
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase(0,"")]
        [TestCase(1, "1")]
        [TestCase(3, "1,2")]
        [TestCase(7, "1,2,4")]
        [TestCase(19, "3,2,6,8")]
        [TestCase(7, "1\n2,4")]
        [TestCase(6, "//;\n2;4")]
        [TestCase(3, "//;\n3;1001")]
        [TestCase(8, "//***\n3***1***4")]
        [TestCase(8, "//*%\n3*1%4")]
        public void Add_Number_Returns_Sum(int expectedResult, string num)
        {
            //Arrange

            //Act
            var result = Calculator.Add(num);
            //Assert
            Assert.AreEqual(expectedResult,result);
        }


        [Test]
        public void Add_NegativeNumber_ThrowException()
        {
            //Arrange
            var number = "1\n-2,-4";

            //Act
            var exception = Assert.Throws<Exception>(() => Calculator.Add(number));

            //Assert
            Assert.AreEqual($"{ResourceFile.NegativeValue} {-2} {-4}", exception.Message);
        }
    }

    
}
