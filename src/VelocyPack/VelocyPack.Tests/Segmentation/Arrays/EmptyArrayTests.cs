using NUnit.Framework;
using VelocyPack.Segments;
using VelocyPack.Tests.HexDumps;

namespace VelocyPack.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class EmptyArrayTests
    {
        [Test]
        public void SegmentizeEmptyArrayHexDump()
        {
            // given
            var data = ArrayHexDumps.Empty;

            // when
            var segment = VelocyPack.ToSegment<EmptyArraySegment>(data);

            // then
            Assert.IsInstanceOf<EmptyArraySegment>(segment);
            Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.EmptyArray, segment.Type);
            Assert.AreEqual(ValueType.EmptyArray, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
            Assert.AreEqual(0, segment.Items.Count);
        }
    }
}
