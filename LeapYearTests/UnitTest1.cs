using LeapYearKata;
using NUnit.Framework;
using System;

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

        [Test]
        public void Returns_1800_False([Values(1800)] int year)
        {
            var x = Program.IsLeapYear(year);

            Assert.IsFalse(x);
        }

        [Test]
        public void Returns_0_Exception([Values(0)] int year) =>
            Assert.Throws<ArgumentNullException>(() => Program.IsLeapYear(year));

    }
}