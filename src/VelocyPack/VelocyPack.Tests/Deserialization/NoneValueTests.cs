using NUnit.Framework;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Deserialization
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
            var value = VelocyPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
