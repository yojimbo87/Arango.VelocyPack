using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
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
            var value = VPack.ToObject<double>(data);

            // then
            Assert.AreEqual(0d, value);
        }
    }
}
