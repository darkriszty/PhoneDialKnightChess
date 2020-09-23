using NUnit.Framework;

namespace PhoneDialKnightChess
{
    public class PhoneDialKnightChessSolverTests
    {
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 1)]
        [TestCase(6, 3)]
        [TestCase(7, 2)]
        [TestCase(8, 2)]
        [TestCase(9, 2)]
        [TestCase(0, 2)]
        public void GetDistinctNumbersDialed_ValidStartKeyAndOneHop_ReturnsExpectedResult(int startingKey, int expectedResult)
        {
            Assert.That(PhoneDialKnightChessSolver.GetDistinctNumbersDialed(startingKey, 1), Is.EqualTo(expectedResult));
        }

        [TestCase(13)]
        [TestCase(23)]
        [TestCase(33)]
        [TestCase(43)]
        [TestCase(53)]
        [TestCase(63)]
        [TestCase(73)]
        [TestCase(83)]
        [TestCase(93)]
        [TestCase(103)]
        public void GetDistinctNumbersDialed_InvalidValidStartKeyAndOneHop_ReturnsNegativeOne(int startingKey)
        {
            Assert.That(PhoneDialKnightChessSolver.GetDistinctNumbersDialed(startingKey, 1), Is.EqualTo(-1));
        }

        [TestCase(1, 3)]
        [TestCase(2, 6)]
        [TestCase(3, 16)]
        public void GetDistinctNumbersDialed_StartingOnSixWithGivenHops_ReturnsExpectedResult(int numberOfHops, int expectedResult)
        {
            Assert.That(PhoneDialKnightChessSolver.GetDistinctNumbersDialed(6, numberOfHops), Is.EqualTo(expectedResult));
        }
    }
}