using NUnit.Framework;
using Is2Plus2Equal4;
using FluentAssertions;

namespace UnitTestsGoHere
{
    public class Tests
    {

        [Test]
        public void Is2Plus2Equal4_IsTrue_ReturnsTrue()
        {
            bool placeHolder;

            placeHolder = Example.Is2Plus2Equal4Method();

            placeHolder.Should().BeFalse();
        }
    }
}
