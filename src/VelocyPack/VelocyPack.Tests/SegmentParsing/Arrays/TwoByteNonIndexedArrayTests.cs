using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class TwoByteNonIndexedArrayTests
    {
        [Test]
        public void ParseArray_With_SmallIntegerItems_And_ZeroZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 2B LENGTHBYTE followed by 0 zero bytes
            var data = new byte[] { 0x03, 0x06, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        [Test]
        public void ParseArray_With_SmallIntegerItems_And_TwoZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 2B LENGTHBYTE followed by 2 zero bytes
            var data = new byte[] { 0x03, 0x08, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            TestArrayWithSmallIntegerItems(data, segment);
        }

        [Test]
        public void ParseArray_With_SmallIntegerItems_And_SixZeroByteByteLengthSize()
        {
            // given
            // hex dump of [1, 2, 3] with 2B LENGTHBYTE followed by 6 zero bytes
            var data = new byte[] { 0x03, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

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
            Assert.AreEqual(ValueType.TwoByteNonIndexedArray, segment.ValueType);
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
