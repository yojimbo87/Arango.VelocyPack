using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class EightByteNonIndexedArrayTests
    {
        [Test]
        public void ParseArrayWithSmallIntegerSubSegments()
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
            Assert.AreEqual(3, segment.Items.Count);

            // first small integer sub segment
            var subSegment1 = segment.Items[0];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment1);
            Assert.AreEqual(9, subSegment1.StartIndex);
            Assert.AreEqual(10, subSegment1.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment1.Type);
            Assert.AreEqual(ValueType.PosOneInt, subSegment1.ValueType);

            // second small integer sub segment
            var subSegment2 = segment.Items[1];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment2);
            Assert.AreEqual(10, subSegment2.StartIndex);
            Assert.AreEqual(11, subSegment2.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment2.Type);
            Assert.AreEqual(ValueType.PosTwoInt, subSegment2.ValueType);

            // third small integer sub segment
            var subSegment3 = segment.Items[2];

            Assert.IsInstanceOf<SmallIntegerSegment>(subSegment3);
            Assert.AreEqual(11, subSegment3.StartIndex);
            Assert.AreEqual(12, subSegment3.CursorIndex);
            Assert.AreEqual(SegmentType.SmallInteger, subSegment3.Type);
            Assert.AreEqual(ValueType.PosThreeInt, subSegment3.ValueType);
        }
    }
}
