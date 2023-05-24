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
            Assert.AreEqual(Text.Str.CamelCase(""), 0);
        }

        [Test]
        public void OneWordString()
        {
            Assert.AreEqual(Text.Str.CamelCase("bondi"), 1);
            Assert.AreEqual(Text.Str.CamelCase("Bondi"), 2);
        }
        [Test]
        public void CamelCaseReturnNumberOfWords()
        {
            Assert.AreEqual(Text.Str.CamelCase("hello World Programming Is Fun"), 5);
        }
    }
}