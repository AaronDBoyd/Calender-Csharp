using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;
// imports namespace

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
      // The first argument is what we expect the result of the test to be. The second is the expression to be evaluated 
    }
  }
}