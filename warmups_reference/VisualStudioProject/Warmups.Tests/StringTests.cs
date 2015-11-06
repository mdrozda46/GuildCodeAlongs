using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class StringTests
    { 
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            // arrange
            Strings obj = new Strings();

            // act
            string actual = obj.SayHi(name);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
