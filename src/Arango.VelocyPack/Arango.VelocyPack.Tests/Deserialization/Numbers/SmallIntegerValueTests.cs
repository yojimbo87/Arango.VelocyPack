using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void DeserializeZeroIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.ZeroInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(0, value);
        }

        [Test]
        public void DeserializePosOneIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosOneInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(1, value);
        }

        [Test]
        public void DeserializePosTwoIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosTwoInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(2, value);
        }

        [Test]
        public void DeserializePosThreeIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosThreeInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(3, value);
        }

        [Test]
        public void DeserializePosFourIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosFourInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(4, value);
        }

        [Test]
        public void DeserializePosFiveIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosFiveInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(5, value);
        }

        [Test]
        public void DeserializePosSixIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosSixInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(6, value);
        }

        [Test]
        public void DeserializePosSevenIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosSevenInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(7, value);
        }

        [Test]
        public void DeserializePosEightIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosEightInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(8, value);
        }

        [Test]
        public void DeserializePosNineIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.PosNineInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(9, value);
        }

        [Test]
        public void DeserializeNegSixIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegSixInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-6, value);
        }

        [Test]
        public void DeserializeNegFiveIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegFiveInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-5, value);
        }

        [Test]
        public void DeserializeNegFourIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegFourInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-4, value);
        }

        [Test]
        public void DeserializeNegThreeIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegThreeInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-3, value);
        }

        [Test]
        public void DeserializeNegTwoIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegTwoInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-2, value);
        }

        [Test]
        public void DeserializeNegOneIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.NegOneInt;

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-1, value);
        }
    }
}
