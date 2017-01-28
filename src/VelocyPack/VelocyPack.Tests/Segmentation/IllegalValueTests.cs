using NUnit.Framework;
using VelocyPack.Segments;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class IllegalValueTests
    {
        [Test]
        public void SegmentizeIllegalValueHexDump()
        {
            // given
            var data = ValueHexDumps.Illegal;

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<IllegalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Illegal, segment.Type);
            Assert.AreEqual(ValueType.Illegal, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
