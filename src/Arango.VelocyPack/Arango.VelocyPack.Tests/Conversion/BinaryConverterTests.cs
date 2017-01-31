using System;
using NUnit.Framework;
using Arango.VelocyPack.Converters;

namespace Arango.VelocyPack.Tests.Conversion
{
    [TestFixture]
    public class BinaryConverterTests
    {
        #region Signed integers

        [Test]
        public void ConvertPositiveThreeByteSignedIntDataToInteger()
        {
            // given
            const int expectedValue = 123456;
            // binary representation of expected value
            var data = new byte[] { 64, 226, 1 };

            // when
            var value = BinaryConverter.ToInteger(data);

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
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 255));
            Assert.IsInstanceOf<int>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveFiveByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 12345678901;
            // binary representation of expected value
            var data = new byte[] { 53, 28, 220, 223, 2 };

            // when
            var value = BinaryConverter.ToInteger(data);

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
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, new byte[] { 255, 255, 255 }));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveSixByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 1234567890123;
            // binary representation of expected value
            var data = new byte[] { 203, 4, 251, 113, 31, 1 };

            // when
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, new byte[] { 0, 0 }));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeSixByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -1234567890123;
            // binary representation of expected value
            var data = new byte[] { 53, 251, 4, 142, 224, 254 };

            // when
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, new byte[] { 255, 255 }));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveSevenByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 1234567890123456;
            // binary representation of expected value
            var data = new byte[] { 192, 186, 138, 60, 213, 98, 4 };

            // when
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeSevenByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -1234567890123456;
            // binary representation of expected value
            var data = new byte[] { 64, 69, 117, 195, 42, 157, 251 };

            // when
            var value = BinaryConverter.ToInteger(data);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 255));
            Assert.IsInstanceOf<long>(value);
            Assert.AreEqual(expectedValue, value);
        }

        #endregion

        #region Unsigned integers

        [Test]
        public void ConvertEightByteUnsignedIntDataToInteger()
        {
            // given
            const ulong expectedValue = 18446744073709551615;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 };

            // when
            var value = BinaryConverter.ToInteger(data, true);

            // then
            CollectionAssert.AreEqual(BitConverter.GetBytes(expectedValue), data);
            Assert.IsInstanceOf<ulong>(value);
            Assert.AreEqual(expectedValue, value);
        }

        #endregion
    }
}
