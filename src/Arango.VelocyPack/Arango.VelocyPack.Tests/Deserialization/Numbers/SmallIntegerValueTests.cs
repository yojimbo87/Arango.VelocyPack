using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void DeserializeZeroIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonZeroInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(0, value);
        }

        [Test]
        public void DeserializePosOneIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosOneInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(1, value);
        }

        [Test]
        public void DeserializePosTwoIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosTwoInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(2, value);
        }

        [Test]
        public void DeserializePosThreeIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosThreeInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(3, value);
        }

        [Test]
        public void DeserializePosFourIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFourInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(4, value);
        }

        [Test]
        public void DeserializePosFiveIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFiveInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(5, value);
        }

        [Test]
        public void DeserializePosSixIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSixInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(6, value);
        }

        [Test]
        public void DeserializePosSevenIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSevenInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(7, value);
        }

        [Test]
        public void DeserializePosEightIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosEightInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(8, value);
        }

        [Test]
        public void DeserializePosNineIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosNineInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(9, value);
        }

        [Test]
        public void DeserializeNegSixIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegSixInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-6, value);
        }

        [Test]
        public void DeserializeNegFiveIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFiveInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-5, value);
        }

        [Test]
        public void DeserializeNegFourIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFourInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-4, value);
        }

        [Test]
        public void DeserializeNegThreeIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegThreeInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-3, value);
        }

        [Test]
        public void DeserializeNegTwoIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegTwoInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-2, value);
        }

        [Test]
        public void DeserializeNegOneIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegOneInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-1, value);
        }
    }
}
