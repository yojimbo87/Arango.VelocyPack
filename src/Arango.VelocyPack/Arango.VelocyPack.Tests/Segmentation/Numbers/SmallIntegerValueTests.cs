using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void SegmentizeZeroIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonZeroInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.ZeroInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosOneIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosOneInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosOneInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosTwoIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosTwoInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosTwoInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosThreeIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosThreeInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosThreeInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosFourIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFourInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosFourInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosFiveIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFiveInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosFiveInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosSixIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSixInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosSixInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosSevenIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSevenInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosSevenInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosEightIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosEightInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosEightInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosNineIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosNineInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosNineInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegSixIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegSixInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegSixInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegFiveIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFiveInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegFiveInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegFourIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFourInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegFourInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegThreeIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegThreeInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegThreeInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegTwoIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegTwoInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegTwoInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegOneIntValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegOneInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegOneInt, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
