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

        [Test]
        public void Returns_1996_True([Values(1996)] int year)
        {
            var x = Program.IsLeapYear(1996);

            Assert.IsTrue(x);
        }
    }
}