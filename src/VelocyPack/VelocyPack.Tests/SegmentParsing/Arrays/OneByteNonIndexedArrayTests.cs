using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class OneByteNonIndexedArrayTests
    {
        [Test]
        public void ParseArrayWithSmallIntegerSubSegments()
        {
            // given
            // hex dump of [1, 2, 3]
            var data = new byte[] { 0x02, 0x05, 0x31, 0x32, 0x33 };

            // when
            var segment = VelocyPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            // array
            Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            Assert.IsInstanceOf<IArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(5, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonIndexedArray, segment.Type);
            Assert.AreEqual(ValueType.OneByteNonIndexedArray, segment.ValueType);
            Assert.AreEqual(3, segment.Items.Count);

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

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment1);
            Assert.AreEqual(4, subSegment3.StartIndex);
            Assert.AreEqual(5, subSegment3.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, subSegment3.ValueType);
        }
    }
}
