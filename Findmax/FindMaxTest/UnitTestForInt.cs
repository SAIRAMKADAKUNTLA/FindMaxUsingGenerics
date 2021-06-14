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
        [Test]
        public void As_Given_FloatfirsttNumber_Return_sameNumber()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            float firstNumber = 30.2f;
            float secondNumber = 20.2f;
            float thirdNumber = 10.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_FloatsecondNumber_Return_sameNumber()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            float firstNumber = 20.2f;
            float secondNumber = 30.2f;
            float thirdNumber = 10.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_FloatthirdNumber_Return_sameNumber()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            float firstNumber = 20.2f;
            float secondNumber = 10.2f;
            float thirdNumber = 30.2f;
            float expected = 30.2f;
            ///Act
            float result = maximum.FindFloatMax(firstNumber, secondNumber, thirdNumber);
            ///Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_Stringfirst_Return_Samevalue()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            string first = "Johnson";
            string second = "Clarke";
            string third = "Jobi";
            string expected = "Johnson";
            ///Act
            string result = maximum.FindStringMax(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_Stringsecond_Return_Samevalue()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            string first = "Sai";
            string second = "Sairam";
            string third = "Bob";
            string expected = "Sairam";
            ///Act
            string result = maximum.FindStringMax(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void As_Given_Stringthird_Return_Samevalue()
        {
            Maximum maximum = new Maximum();
            ///Arrange
            string first = "Apple";
            string second = "Mango";
            string third = "Watermelon";
            string expected = "Watermelon";
            ///Act
            string result = maximum.FindStringMax(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}