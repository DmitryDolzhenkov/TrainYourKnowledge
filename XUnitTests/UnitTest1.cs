using System;
using System.Collections.Generic;
using Xunit;
using YieldTest;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void DivideSequaence_Exception()
        {
            Assert.Throws<ArgumentException>(()=> YieldTest.Program.DivideSequaence(0));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        public void DivideSequaence_SimpleDividerShouldCalculate(int i)
        {
            //Arrange

            // Actual
            var sequance1 = YieldTest.Program.DivideSequaence(i);
            Console.WriteLine("!!!");
            foreach (var item in sequance1)
            {
                Console.WriteLine(item);
            }

            // Assert

        }
    }
}
