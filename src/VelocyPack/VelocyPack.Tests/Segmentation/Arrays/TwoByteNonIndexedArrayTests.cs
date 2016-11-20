using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation.Arrays
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
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(data.Length, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.TwoByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(3, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
            Assert.AreEqual(3, segment.Items.Count);

            TestSmallIntegerItems(data, segment);
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
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(data.Length, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.TwoByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(5, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
            Assert.AreEqual(3, segment.Items.Count);

            TestSmallIntegerItems(data, segment);
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
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(data.Length, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.TwoByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(9, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
            Assert.AreEqual(3, segment.Items.Count);

            TestSmallIntegerItems(data, segment);
        }

        private void TestSmallIntegerItems(byte[] data, NonIndexedArraySegment segment)
        {
            // first small integer segment item
            var item1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(item1);
            Assert.AreEqual(SegmentType.SmallInteger, item1.Type);
            Assert.AreEqual(ValueType.PosOneInt, item1.ValueType);

            // second small integer segment item
            var item2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(item2);
            Assert.AreEqual(SegmentType.SmallInteger, item2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, item2.ValueType);

            // third small integer segment item
            var item3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(item3);
            Assert.AreEqual(SegmentType.SmallInteger, item3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, item3.ValueType);
        }
    }
}
