using System;
using NUnit.Framework;
using FluentAssertions;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz.FizzBuzz _fizzBuzz;

        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [Test]
        public void OneIsOne()
        {
            _fizzBuzz.Calculate(1).Should().Be("1");
        }

        [Test]
        public void TwoIsTwo()
        {
            _fizzBuzz.Calculate(2).Should().Be("2");
        }

        [Test]
        public void ThreeIsFizzBecauseItIsDisableByThree()
        {
            _fizzBuzz.Calculate(3).Should().Be("Fizz");
        }

        [Test]
        public void FiveIsBuzzBecauseItIsDivisibleByFive()
        {
            _fizzBuzz.Calculate(5).Should().Be("Buzz");
        }

        [Test]
        public void FifteenIsFizzBuzzBecauseItIsDivisibleByThreeAndFive()
        {
            _fizzBuzz.Calculate(15).Should().Be("FizzBuzz");
        }
    }
}
