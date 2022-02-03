using LeapYearKata;
using NUnit.Framework;

namespace LeapYearTests
{
    public class Tests
    {
      
        [Test]
        public void Returns_1997_False([Values(1997)] int year)
        {
            var x = Program.IsLeapYear(1997);

            Assert.IsFalse(x);
        }
    }
}