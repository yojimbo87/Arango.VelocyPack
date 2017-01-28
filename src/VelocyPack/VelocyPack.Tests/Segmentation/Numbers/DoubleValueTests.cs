using NUnit.Framework;
using VelocyPack.Segments;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void SegmentizeDoubleValueHexDump()
        {
            // given
            var data = NumberHexDumps.Double;

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<DoubleSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Double, segment.Type);
            Assert.AreEqual(ValueType.Double, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(8, segment.ValueByteLength);
        }
    }
}
