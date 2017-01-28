using System.Collections.Generic;
using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class TwoByteNonIndexedArrayTests
    {
        [Test]
        public void DeserializeNonIndexedArrayHexDump_With__ZeroZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.TwoByteNonIndexedWithZeroZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_TwoZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.TwoByteNonIndexedWithTwoZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_SixZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.TwoByteNonIndexedWithSixZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        private void TestSmallIntegerItems(List<object> items)
        {
            // first item
            var item1 = items[0];

            Assert.IsInstanceOf<sbyte>(item1);
            Assert.AreEqual(1, item1);

            // second item
            var item2 = items[1];

            Assert.IsInstanceOf<sbyte>(item2);
            Assert.AreEqual(2, item2);

            // third item
            var item3 = items[2];

            Assert.IsInstanceOf<sbyte>(item3);
            Assert.AreEqual(3, item3);
        }
    }
}
