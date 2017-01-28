using System;
using NUnit.Framework;
using VelocyPack.Converters;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Conversion
{
    [TestFixture]
    public class BinaryConverterTests
    {
        [Test]
        public void ConvertThreeBytesToInt32()
        {
            // given
            var threeByteIntegerMinValue = -8388608;
            var threeByteIntegerMinValueBytes = BitConverter.GetBytes(threeByteIntegerMinValue);
            var threeByteIntegerMaxValue = 8388607;
            var threeByteIntegerMaxValueBytes = BitConverter.GetBytes(threeByteIntegerMaxValue);

            // when
            var convertedIntegerMinValue = BinaryConverter.ToInt32(
                threeByteIntegerMinValueBytes[2],
                threeByteIntegerMinValueBytes[1],
                threeByteIntegerMinValueBytes[0]
            );
            var convertedIntegerMaxValue = BinaryConverter.ToInt32(
                threeByteIntegerMaxValueBytes[2],
                threeByteIntegerMaxValueBytes[1],
                threeByteIntegerMaxValueBytes[0]
            );

            // then
            Assert.AreEqual(threeByteIntegerMinValue, convertedIntegerMinValue);
            Assert.AreEqual(threeByteIntegerMaxValue, convertedIntegerMaxValue);
        }

        [Test]
        public void ConvertEightBytesToInt64()
        {
            // given
            var minValue = -9223372036854775808;
            var minValueBytes = BitConverter.GetBytes(minValue);

            // when
            var convertedIntegerMinValue = BinaryConverter.ToInt64(minValueBytes);

            // then
            Assert.AreEqual(minValue, convertedIntegerMinValue);
        }

        [Test]
        public void ConvertOneByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.OneByteSignedInt, 1, 1);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<sbyte>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertTwoByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.TwoByteSignedInt, 1, 2);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<short>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertThreeByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.ThreeByteSignedInt, 1, 3);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<int>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertFourByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.FourByteSignedInt, 1, 4);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<int>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertFiveByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.FiveByteSignedInt, 1, 5);

            // when
            //var value = BinaryConverter.ToSignedInteger(data);
            var value = BinaryConverter.ToInt64(data);

            var d2 = data;
            var v2 = BinaryConverter.ToInt64(
                d2[0],
                d2[1],
                d2[2],
                d2[3],
                d2[4],
                0xff,
                0xff,
                0xff
                );

            // then
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertSixByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.SixByteSignedInt, 1, 6);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertSevenByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.SevenByteSignedInt, 1, 7);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(-10, value);
        }

        [Test]
        public void ConvertEightByteSignedIntToInteger()
        {
            // given
            // first byte which represents VPack value type needs to be omitted
            var data = ArrayConverter.Slice(NumberHexDumps.EightByteSignedInt, 1, 8);

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(-10, value);
        }
    }
}
