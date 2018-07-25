using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ReturnFirstPrimeNumber2()
        {
            var input = 2;
            var output = PrimeService.GetPrimes(input);
            Assert.AreEqual(2, output);
        }

        [Test]
        public void CheckPrimes_When1_ReturnsFalse()
        {
            var input = 1;
            var output = PrimeService.CheckPrimes(input);
            Assert.AreEqual(false, output);
        }

        [Test]
        public void CheckPrimes_When4_ReturnsFalse()
        {
            var input = 4;
            var output = PrimeService.CheckPrimes(input);
            Assert.AreEqual(false, output);
        }
        [Test]
        public void CheckPrimes_When3_ReturnsTrue()
        {
            var input = 3;
            var output = PrimeService.CheckPrimes(input);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckPrimes_WhenPrime_ReturnTrue([Values(2,3,5,7,41,97)]int input)
        {
            var output = PrimeService.CheckPrimes(input);
            Assert.AreEqual(true, output);
        }
        
        [Test]
        public void CheckPrimes_WhenNotPrime_ReturnFalse([Values(8, 12, 9, 15, 18, 92)]int input)
        {
            var output = PrimeService.CheckPrimes(input);
            Assert.AreEqual(false, output);
        }
    }
}