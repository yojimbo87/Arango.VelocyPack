using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void SegmentizeZeroIntValueHexDump()
        {
            // given
            var data = NumberHexDumps.ZeroInt;

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
            var data = NumberHexDumps.PosOneInt;

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
            var data = NumberHexDumps.PosTwoInt;

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
            var data = NumberHexDumps.PosThreeInt;

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
            var data = NumberHexDumps.PosFourInt;

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
            var data = NumberHexDumps.PosFiveInt;

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
            var data = NumberHexDumps.PosSixInt;

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
            var data = NumberHexDumps.PosSevenInt;

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
            var data = NumberHexDumps.PosEightInt;

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
            var data = NumberHexDumps.PosNineInt;

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
            var data = NumberHexDumps.NegSixInt;

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
            var data = NumberHexDumps.NegFiveInt;

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
            var data = NumberHexDumps.NegFourInt;

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
            var data = NumberHexDumps.NegThreeInt;

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
            var data = NumberHexDumps.NegTwoInt;

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
            var data = NumberHexDumps.NegOneInt;

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
