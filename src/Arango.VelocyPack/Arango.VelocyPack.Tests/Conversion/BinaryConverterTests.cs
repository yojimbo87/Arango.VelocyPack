using System;
using NUnit.Framework;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Tests.Conversion
{
    [TestFixture]
    public class BinaryConverterTests
    {
        [Test]
        public void ConvertPositiveThreeByteSignedIntDataToInteger()
        {
            // given
            const int expectedValue = 123456;
            // binary representation of expected value
            var data = new byte[] { 64, 226, 1 };

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            Assert.IsInstanceOf<int>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeThreeByteSignedIntDataToInteger()
        {
            // given
            const int expectedValue = -123456;
            // binary representation of expected value
            var data = new byte[] { 192, 29, 254 };

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 255));
            Assert.IsInstanceOf<int>(value);
            Assert.AreEqual(expectedValue, value);
        }

        //-12345678901
        [Test]
        public void ConvertPositiveFiveByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 12345678901;
            // binary representation of expected value
            var data = new byte[] { 53, 28, 220, 223, 2 };

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, new byte[] { 0, 0, 0 }));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeFiveByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -12345678901;
            // binary representation of expected value
            var data = new byte[] { 203, 227, 35, 32, 253 };

            // when
            var value = BinaryConverter.ToSignedInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, new byte[] { 255, 255, 255 }));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }
    }
}
