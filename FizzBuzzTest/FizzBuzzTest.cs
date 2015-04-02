using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private FizzBuzz.FizzBuzz _fizzBuzz;

        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [Fact]
        public void OneIsOne()
        {
            _fizzBuzz.Calculate(1).Should().Be("1");
        }

        [Fact]
        public void TwoIsTwo()
        {
            _fizzBuzz.Calculate(2).Should().Be("2");
        }

        [Fact]
        public void ThreeIsFizzBecauseItIsDisableByThree()
        {
            _fizzBuzz.Calculate(3).Should().Be("Fizz");
        }

        [Fact]
        public void FiveIsBuzzBecauseItIsDivisibleByFive()
        {
            _fizzBuzz.Calculate(5).Should().Be("Buzz");
        }
    }
}
