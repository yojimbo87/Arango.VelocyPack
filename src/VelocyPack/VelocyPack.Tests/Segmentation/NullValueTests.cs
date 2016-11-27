using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class NullValueTests
    {
        [Test]
        public void SegmentizeNullValueHexDump()
        {
            // given
            var data = ValueHexDumps.Null;

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NullSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Null, segment.Type);
            Assert.AreEqual(ValueType.Null, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
