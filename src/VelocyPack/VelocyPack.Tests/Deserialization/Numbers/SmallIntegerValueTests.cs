using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void DeserializeZeroIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.ZeroInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(0, value);
        }

        [Test]
        public void DeserializePosOneIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosOneInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(1, value);
        }

        [Test]
        public void DeserializePosTwoIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosTwoInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(2, value);
        }

        [Test]
        public void DeserializePosThreeIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosThreeInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(3, value);
        }

        [Test]
        public void DeserializePosFourIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosFourInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(4, value);
        }

        [Test]
        public void DeserializePosFiveIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosFiveInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(5, value);
        }

        [Test]
        public void DeserializePosSixIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosSixInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(6, value);
        }

        [Test]
        public void DeserializePosSevenIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosSevenInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(7, value);
        }

        [Test]
        public void DeserializePosEightIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosEightInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(8, value);
        }

        [Test]
        public void DeserializePosNineIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.PosNineInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(9, value);
        }

        [Test]
        public void DeserializeNegSixIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegSixInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-6, value);
        }

        [Test]
        public void DeserializeNegFiveIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegFiveInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-5, value);
        }

        [Test]
        public void DeserializeNegFourIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegFourInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-4, value);
        }

        [Test]
        public void DeserializeNegThreeIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegThreeInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-3, value);
        }

        [Test]
        public void DeserializeNegTwoIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegTwoInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-2, value);
        }

        [Test]
        public void DeserializeNegOneIntValueHexDump()
        {
            // given
            var data = ValueHexDumps.NegOneInt;

            // when
            var value = VelocyPack.ToObject<sbyte>(data);

            // then
            Assert.AreEqual(-1, value);
        }
    }
}
