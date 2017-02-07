using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class DoubleValueDeserializationTests
    {
        [Test]
        public void DeserializeDoubleValue()
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
