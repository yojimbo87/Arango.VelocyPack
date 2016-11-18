using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class OneByteNonIndexedArrayTests
    {
        [Test]
        public void ParseArray_With_SmallIntegerItems_And_ZeroZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 1B LENGTHBYTE followed by 0 zero bytes
            var data = new byte[] { 0x02, 0x05, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        [Test]
        public void ParseArray_With_SmallIntegerItems_And_OneZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 1B LENGTHBYTE followed by 1 zero byte
            var data = new byte[] { 0x02, 0x06, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        [Test]
        public void ParseArray_With_SmallIntegerItems_And_ThreeZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 1B LENGTHBYTE followed by 3 zero bytes
            var data = new byte[] { 0x02, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        [Test]
        public void ParseArray_With_SmallIntegerItems_And_SevenZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 1B LENGTHBYTE followed by 7 zero bytes
            var data = new byte[] { 0x02, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        private void TestArrayWithSmallIntegerItems(byte[] data, NonIndexedArraySegment segment)
        {
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(data.Length, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.OneByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(3, segment.Items.Count);

            // first small integer sub segment
            var subSegment1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment1);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment1.Type);
            Assert.AreEqual(ValueType.PosOneInt, subSegment1.ValueType);

            // second small integer sub segment
            var subSegment2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment2);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, subSegment2.ValueType);

            // third small integer sub segment
            var subSegment3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment1);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, subSegment3.ValueType);
        }
    }
}
