using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class UnsignedIntegerValueTests
    {
        [Test]
        public void DeserializeEightByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteUnsignedInt);

            // when
            var value = VPack.ToObject<ulong>(data);

            // then
            Assert.AreEqual(18446744073709551615, value);
        }
    }
}
