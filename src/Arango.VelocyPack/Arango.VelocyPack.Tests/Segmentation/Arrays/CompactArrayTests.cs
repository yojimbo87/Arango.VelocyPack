using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class CompactArrayTests
    {
        [Test]
        public void SegmentizeCompactArrayHexDump()
        {
            // given
            var data = ArrayHexDumps.Compact;

            // when
            var segment = VPack.ToSegment<CompactArraySegment>(data);

            // then
            // array
            Assert.IsInstanceOf<CompactArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(6, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.CompactArray, segment.Type);
            Assert.AreEqual(ValueType.CompactNonIndexedArray, segment.ValueType);
            Assert.AreEqual(2, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
            Assert.AreEqual(3, segment.Items.Count);
            Assert.AreEqual(segment.ItemCount, segment.Items.Count);

            // first small integer segment item
            var item1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(item1);
            Assert.AreEqual(2, item1.StartIndex);
            Assert.AreEqual(3, item1.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item1.Type);
            Assert.AreEqual(ValueType.PosOneInt, item1.ValueType);
            Assert.AreEqual(2, item1.ValueStartIndex);
            Assert.AreEqual(1, item1.ValueByteLength);

            // second small integer segment item
            var item2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(item2);
            Assert.AreEqual(3, item2.StartIndex);
            Assert.AreEqual(4, item2.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, item2.ValueType);
            Assert.AreEqual(3, item2.ValueStartIndex);
            Assert.AreEqual(1, item2.ValueByteLength);

            // third small integer segment item
            var item3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(item3);
            Assert.AreEqual(4, item3.StartIndex);
            Assert.AreEqual(5, item3.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, item3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, item3.ValueType);
            Assert.AreEqual(4, item3.ValueStartIndex);
            Assert.AreEqual(1, item3.ValueByteLength);
        }
    }
}
