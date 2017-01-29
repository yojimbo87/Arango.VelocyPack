using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void DeserializeDoubleValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonDouble);

            // when
            var value = VPack.ToObject<double>(data);

            // then
            Assert.AreEqual(0.33333333333333331, value);
        }
    }
}
