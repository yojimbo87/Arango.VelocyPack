using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class UnsignedIntegerValueTests
    {
        [Test]
        public void SegmentizeEightByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.EightByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(8, segment.ValueByteLength);
        }
    }
}
