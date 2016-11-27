using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class BooleanValueTests
    {
        [Test]
        public void SegmentizeFalseBooleanValueHexDump()
        {
            // given
            var data = ValueHexDumps.False;

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Boolean, segment.Type);
            Assert.AreEqual(ValueType.False, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTrueBooleanValueHexDump()
        {
            // given
            var data = ValueHexDumps.True;

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Boolean, segment.Type);
            Assert.AreEqual(ValueType.True, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
