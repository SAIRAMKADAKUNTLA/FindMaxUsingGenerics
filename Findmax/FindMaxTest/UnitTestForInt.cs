using NUnit.Framework;
using FindmaxOf3;

namespace FindMaxTest
{
    public class Tests
    {

        [Test]
        public void As_Given_firstNumber_Return_samenumber()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            int firstNumber = 30;
            int secondNumber = 20;
            int thirdNumber = 10;
            int expected = 30;
            ////Act
            int result = maximum.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void As_Given_secondNumber_Return_samenumber()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            int firstNumber = 20;
            int secondNumber = 30;
            int thirdNumber = 10;
            int expected = 30;
            ////Act
            int result = maximum.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_thirdNumber_Return_samenumber()
        {
            Maximum maximum = new Maximum();
            ///Arrande
            int firstNumber = 20;
            int secondNumber = 10;
            int thirdNumber = 30;
            int expected = 30;
            ///Act
            int result = maximum.FindIntMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }

    }
}