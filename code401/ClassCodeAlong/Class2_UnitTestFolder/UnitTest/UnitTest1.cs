using System;
using FizzBuzz;
using Xunit;

namespace NewUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnString()
        {
            Assert.Equal("1", FizzBuzz.FizzBuzz.Convert(1));
        }
        [Fact]
        public void ReturnsFizzForThree()
        {
            Assert.Equal("fizz", FizzBuzz.FizzBuzz.Convert(3));
        }
        [Fact]
        public void ReturnsFizzForFive()
        {
            Assert.Equal("buzz", FizzBuzz.FizzBuzz.Convert(5));
        }
        [Fact]
        public void ReturnsFizzForFifteen()
        {
            Assert.Equal("fizzbuzz", FizzBuzz.FizzBuzz.Convert(15));
        }

        [Theory]
        [InlineData(1,"1")]
        [InlineData(2,"2")]
        [InlineData(3,"fizz")]
        [InlineData(4,"4")]
        [InlineData(5,"buzz")]
        [InlineData(6,"fizz")]
        [InlineData(7,"7")]
        [InlineData(8,"8")]
        [InlineData(9,"fizz")]
        [InlineData(10,"buzz")]
        [InlineData(11,"11")]
        [InlineData(12,"fizz")]
    
        public void CheckAllTheNumbers(int input, string expectedOutput){
            Assert.Equal(expectedOutput, FizzBuzz.FizzBuzz.Convert(input));

        }

    }
}