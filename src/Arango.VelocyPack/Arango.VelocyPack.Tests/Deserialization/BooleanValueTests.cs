using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class BooleanValueTests
    {
        [Test]
        public void DeserializeFalseBooleanValueHexDump()
        {
            // given
            var data = ValueHexDumps.False;

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.IsFalse(value);
        }

        [Test]
        public void DeserializeTrueBooleanValueHexDump()
        {
            // given
            var data = ValueHexDumps.True;

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.IsTrue(value);
        }
    }
}
