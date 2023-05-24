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
        public void emptyAndNullSTring()
        {
            Assert.AreEqual(Text.Str.UniqueChar(""),-1);
            Assert.AreEqual(Text.Str.UniqueChar(null), -1);
            Assert.AreEqual(Text.Str.UniqueChar("aabbcc"), -1);
        }

        [Test]
        public void ReturnZero()
        {
            Assert.AreEqual(Text.Str.UniqueChar("abcde"), 0);
            Assert.AreEqual(Text.Str.UniqueChar("abbccde"), 0);
            Assert.AreEqual(Text.Str.UniqueChar("a"), 0);
        }

        [Test]
        public void CheckInTheMiddle()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbcddee"), 4);
        }

        [Test]
        public void CheckAtTheEnd()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbc"), 4);
        }
    }
}