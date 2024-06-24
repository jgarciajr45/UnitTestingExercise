using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 4, 1, 8)]
        [InlineData(1, 1, 1, 3)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator instance = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = instance.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }
        

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(5, 2, 3)]
        [InlineData(6, 2, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(5, 2, 10)]
        [InlineData(6, 2, 12)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Mult(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(2, 2, 1)]
        [InlineData(6, 2, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Div(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
