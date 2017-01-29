using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void SegmentizeDoubleValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonDouble);

            // when
            var segment = VPack.ToSegment(data);

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
