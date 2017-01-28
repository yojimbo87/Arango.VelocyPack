using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class IllegalValueTests
    {
        [Test]
        public void DeserializeIllegalValueHexDump()
        {
            // given
            var data = ValueHexDumps.Illegal;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
