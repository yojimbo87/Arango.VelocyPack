using NUnit.Framework;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NonSensicalValueTests
    {
        [Test]
        public void DeserializeMinKeyValueHexDump()
        {
            // given
            var data = ValueHexDumps.MinKey;

            // when
            var value = VelocyPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }

        [Test]
        public void DeserializeMaxKeyValueHexDump()
        {
            // given
            var data = ValueHexDumps.MaxKey;

            // when
            var value = VelocyPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
