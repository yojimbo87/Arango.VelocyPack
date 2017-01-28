using NUnit.Framework;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void DeserializeDoubleValueHexDump()
        {
            // given
            var data = NumberHexDumps.Double;

            // when
            var value = VelocyPack.ToObject<double>(data);

            // then
            Assert.AreEqual(0d, value);
        }
    }
}
