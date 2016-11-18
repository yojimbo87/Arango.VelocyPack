using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class CompactArrayTests
    {
        [Test]
        public void ParseArrayWithSmallIntegerSubSegments()
        {
            // given
            // hex dump of [1, 2, 3]
            var data = new byte[] { 0x13, 0x06, 0x31, 0x32, 0x33, 0x03 };

            // when
            var segment = VelocyPack.ToSegment<CompactArraySegment>(data);

            // then
            // array
            Assert.IsInstanceOf<CompactArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(6, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.CompactArray, segment.Type);
            Assert.AreEqual(ValueType.CompactNonIndexedArray, segment.ValueType);
            Assert.AreEqual(3, segment.Items.Count);
            Assert.AreEqual(segment.ItemCount, segment.Items.Count);

            // first small integer sub segment
            var subSegment1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment1);
            Assert.AreEqual(2, subSegment1.StartIndex);
            Assert.AreEqual(3, subSegment1.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment1.Type);
            Assert.AreEqual(ValueType.PosOneInt, subSegment1.ValueType);

            // second small integer sub segment
            var subSegment2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment2);
            Assert.AreEqual(3, subSegment2.StartIndex);
            Assert.AreEqual(4, subSegment2.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, subSegment2.ValueType);

            // third small integer sub segment
            var subSegment3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment3);
            Assert.AreEqual(4, subSegment3.StartIndex);
            Assert.AreEqual(5, subSegment3.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, subSegment3.ValueType);
        }
    }
}
