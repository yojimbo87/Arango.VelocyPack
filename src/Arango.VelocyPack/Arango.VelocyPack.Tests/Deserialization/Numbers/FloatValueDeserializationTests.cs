using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class FloatValueDeserializationTests
    {
        [Test]
        public void DeserializePosOneByteFloatValue()
        {
            // given
            var data = Hex.PosOneByteLengthFloatValue;

            // when
            var value = VPack.ToObject<float>(data);

            // then
            Assert.AreEqual((float)12345, value);
        }

        [Test]
        public void DeserializeNegOneByteFloatValue()
        {
            // given
            var data = Hex.NegOneByteLengthFloatValue;

            // when
            var value = VPack.ToObject<float>(data);

            // then
            Assert.AreEqual((float)-12345, value);
        }
    }
}
