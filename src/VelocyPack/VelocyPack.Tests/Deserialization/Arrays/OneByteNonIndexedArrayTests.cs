using System.Collections.Generic;
using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class OneByteNonIndexedArrayTests
    {
        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_ZeroZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.OneByteNonIndexedWithZeroZeroBytes;

            // when
            var value = VelocyPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_OneZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.OneByteNonIndexedWithOneZeroBytes;

            // when
            var value = VelocyPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_ThreeZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.OneByteNonIndexedWithThreeZeroBytes;

            // when
            var value = VelocyPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArrayHexDump_With_SevenZeroByteByteLengthSize()
        {
            // given
            var data = ArrayHexDumps.OneByteNonIndexedWithSevenZeroBytes;

            // when
            var value = VelocyPack.ToObject<List<object>>(data);

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
