using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class FloatValueSegmentationTests
    {
        [Test]
        public void SegmentizePosOneByteFloatValue()
        {
            // given
            var data = Hex.PosOneByteLengthFloatValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<FloatSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Float, segment.Type);
            Assert.AreEqual(ValueType.PosOneByteFloat, segment.ValueType);
            Assert.AreEqual(6, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegOneByteFloatValue()
        {
            // given
            var data = Hex.NegOneByteLengthFloatValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<FloatSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Float, segment.Type);
            Assert.AreEqual(ValueType.NegOneByteFloat, segment.ValueType);
            Assert.AreEqual(6, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
        }
    }
}
