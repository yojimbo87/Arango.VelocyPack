using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SignedIntegerValueTests
    {
        [Test]
        public void DeserializeOneByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteSignedInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual((sbyte)- 12, value);
        }

        [Test]
        public void DeserializeTwoByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteSignedInt);

            // when
            var value = VPack.ToObject<short>(data);

            // then
            Assert.AreEqual((short)-12345, value);
        }

        [Test]
        public void DeserializeThreeByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteSignedInt);

            // when
            var value = VPack.ToObject<int>(data);

            // then
            Assert.AreEqual(-123456, value);
        }

        [Test]
        public void DeserializeFourByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteSignedInt);

            // when
            var value = VPack.ToObject<int>(data);

            // then
            Assert.AreEqual(-123456789, value);
        }

        [Test]
        public void DeserializeFiveByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.AreEqual(-12345678901, value);
        }

        [Test]
        public void DeserializeEightByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.AreEqual(-1234567890123456789, value);
        }
    }
}
