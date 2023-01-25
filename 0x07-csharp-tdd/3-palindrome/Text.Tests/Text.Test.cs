using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyString()
        {
            var test = "";
            var result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("Racecar")]
        [TestCase("RaceCar")]
        [TestCase("RACECAR")]
        [TestCase("racecar")]
        [TestCase("level")]
        [TestCase("A man, a plan, a canal: Panama.")]
        public void IsTruePalindrome(string text)
        {
            var res = Str.IsPalindrome(text);
            Assert.IsTrue(res);
        }

        [Test]
        [TestCase("Bondi")]
        [TestCase("BONDI")]
        [TestCase("bondi")]
        [TestCase("Med Amin")]
        [TestCase("Hello World!")]
        public void IsFalsePlanidrome(string text)
        {
            var res = Str.IsPalindrome(text);
            Assert.IsFalse(res);
        }
    }
}