using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class EightByteNonIndexedArrayTests
    {
        [Test]
        public void ParseArray_With_SmallIntegerItems()
        {
            // given
            // hex dump of [1, 2, 3]
            var data = new byte[] { 0x05, 0x0c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(12, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.EightByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(9, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
            Assert.AreEqual(3, segment.Items.Count);

            // first small integer segment item
            var item1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(item1);
            Assert.AreEqual(9, item1.StartIndex);
            Assert.AreEqual(10, item1.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item1.Type);
            Assert.AreEqual(ValueType.PosOneInt, item1.ValueType);
            Assert.AreEqual(9, item1.ValueStartIndex);
            Assert.AreEqual(1, item1.ValueByteLength);

            // second small integer segment item
            var item2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(item2);
            Assert.AreEqual(10, item2.StartIndex);
            Assert.AreEqual(11, item2.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, item2.ValueType);
            Assert.AreEqual(10, item2.ValueStartIndex);
            Assert.AreEqual(1, item2.ValueByteLength);

            // third small integer segment item
            var item3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(item3);
            Assert.AreEqual(11, item3.StartIndex);
            Assert.AreEqual(12, item3.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, item3.ValueType);
            Assert.AreEqual(11, item3.ValueStartIndex);
            Assert.AreEqual(1, item3.ValueByteLength);
        }
    }
}
