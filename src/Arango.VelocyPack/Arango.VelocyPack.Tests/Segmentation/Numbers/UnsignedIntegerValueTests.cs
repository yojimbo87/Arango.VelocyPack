using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class UnsignedIntegerValueTests
    {
        [Test]
        public void SegmentizeOneByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(2, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.OneByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTwoByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(3, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.TwoByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(2, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeThreeByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(4, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.ThreeByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFourByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(5, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.FourByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(4, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFiveByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(6, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.FiveByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(5, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSixByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSixByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(7, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.SixByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(6, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSevenByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSevenByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(8, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.UnsignedInteger, segment.Type);
            Assert.AreEqual(ValueType.SevenByteUInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(7, segment.ValueByteLength);
        }

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
