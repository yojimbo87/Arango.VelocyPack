using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NoneValueTests
    {
        [Test]
        public void DeserializeNoneValueHexDump()
        {
            // given
            var data = ValueHexDumps.None;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
