using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            {//Arrange 
            double number1 = 3.4;
            double number2 = 5.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition(); 
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            }
        [Test]
        public void GetAddition_Inputminus3and5_Returns2()
        {//Arrange 
            double number1 = -3;
            double number2 = 2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Inputminus99point99_and0_Returnsminus99point99()
        {//Arrange 
            double number1 = -99.99;
            double number2 = 0;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input64_and23_Returns41()
        {//Arrange 
            double number1 = 64;
            double number2 = 23;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input2_and69_Returnsminus67()
        {//Arrange 
            double number1 = 2;
            double number2 = 69;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Inputminus1_andminus999_Returnsminus998()
        {//Arrange 
            double number1 = -1;
            double number2 = -999;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input0and99_Returns0()
        {//Arrange 
            double number1 = 0;
            double number2 = 99;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input2and3_Returns6()
        {//Arrange 
            double number1 = 2;
            double number2 = 3;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point4and3point9_Returns9point36()
        {//Arrange 
            double number1 = 2.4;
            double number2 = 3.9;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input3and0_Returnsinfinity()
        {//Arrange 
            double number1 = 3;
            double number2 = 0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input333and10_Returns33point3()
        {//Arrange 
            double number1 = 333;
            double number2 = 10;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input25and5_Returns5()
        {//Arrange 
            double number1 = 25;
            double number2 = 5;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
