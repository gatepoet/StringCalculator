using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Adding_zero_numbers_returns_zero()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            var result = calculator.Add("");

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(10)]
        public void Adding_one_number_returns_same_number(int number)
        {
            //Arrange
            var caluculator = new StringCalculator();

            //Act
            var result = caluculator.Add(number.ToString());

            //Assert
            Assert.That(result, Is.EqualTo(number));
        }



        [Test]
        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        [TestCase("100,200", 300)]
        [TestCase("1,2,3", 6)]
        [TestCase("6,7,8,9,10", 40)]
        [TestCase("10,20,30,40,50,60", 210)]
        public void Adding_multiple_numbers_returns_sum(string numbers, int sum)
        {
            //Arrange
            var caluculator = new StringCalculator();

            //Act
            var result = caluculator.Add(numbers);

            //Assert
            Assert.That(result, Is.EqualTo(sum));
        }
    }
}
