using LeapYearKata;
using NUnit.Framework;

namespace LeapYearTests
{
    public class Tests
    {
      
        [Test]
        public void Returns_1997_False([Values(1997)] int year)
        {
            var x = Program.IsLeapYear(year);

            Assert.IsFalse(x);
        }

        [Test]
        public void Returns_1996_True([Values(1996)] int year)
        {
            var x = Program.IsLeapYear(year);

            Assert.IsTrue(x);
        }

        [Test]
        public void Returns_1600_True([Values(1600)] int year)
        {
            var x = Program.IsLeapYear(year);

            Assert.IsTrue(x);
        }
    }
}