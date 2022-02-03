using LeapYearKata;
using NUnit.Framework;

namespace LeapYearTests
{
    public class Tests
    {
      
        [Test]
        public void Returns_True()
        {
            var x = Program.IsLeapYear(2022);

            Assert.IsTrue(x);
        }
    }
}