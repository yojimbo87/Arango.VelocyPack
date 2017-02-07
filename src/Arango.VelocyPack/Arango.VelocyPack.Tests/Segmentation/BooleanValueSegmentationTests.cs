using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class BooleanValueSegmentationTests
    {
        [Test]
        public void SegmentizeFalseBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFalseValue);

            // when
            var segment = VPack.ToSegment(data);

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
        public void SegmentizeTrueBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTrueValue);

            // when
            var segment = VPack.ToSegment(data);

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
