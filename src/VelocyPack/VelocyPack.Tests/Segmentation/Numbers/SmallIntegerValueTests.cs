using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SmallIntegerValueTests
    {
        [Test]
        public void ParseZeroIntValue()
        {
            // given
            // hex dump of 0
            var data = new byte[] { 0x30 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosOneIntValue()
        {
            // given
            // hex dump of 1
            var data = new byte[] { 0x31 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosTwoIntValue()
        {
            // given
            // hex dump of 2
            var data = new byte[] { 0x32 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosThreeIntValue()
        {
            // given
            // hex dump of 3
            var data = new byte[] { 0x33 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosFourIntValue()
        {
            // given
            // hex dump of 4
            var data = new byte[] { 0x34 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosFiveIntValue()
        {
            // given
            // hex dump of 5
            var data = new byte[] { 0x35 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosSixIntValue()
        {
            // given
            // hex dump of 6
            var data = new byte[] { 0x36 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosSevenIntValue()
        {
            // given
            // hex dump of 7
            var data = new byte[] { 0x37 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosEightIntValue()
        {
            // given
            // hex dump of 8
            var data = new byte[] { 0x38 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParsePosNineIntValue()
        {
            // given
            // hex dump of 9
            var data = new byte[] { 0x39 };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegSixIntValue()
        {
            // given
            // hex dump of -6
            var data = new byte[] { 0x3a };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegFiveIntValue()
        {
            // given
            // hex dump of -5
            var data = new byte[] { 0x3b };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegFourIntValue()
        {
            // given
            // hex dump of -4
            var data = new byte[] { 0x3c };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegThreeIntValue()
        {
            // given
            // hex dump of -3
            var data = new byte[] { 0x3d };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegTwoIntValue()
        {
            // given
            // hex dump of -2
            var data = new byte[] { 0x3e };

            // when
            var segment = VelocyPack.ToSegment(data);

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
        public void ParseNegOneIntValue()
        {
            // given
            // hex dump of -1
            var data = new byte[] { 0x3f };

            // when
            var segment = VelocyPack.ToSegment(data);

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
