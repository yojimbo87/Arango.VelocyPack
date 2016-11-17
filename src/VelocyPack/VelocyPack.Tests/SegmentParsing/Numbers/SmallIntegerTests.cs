using NUnit.Framework;

namespace VelocyPack.Tests.SegmentParsing.Numbers
{
    [TestFixture]
    public class SmallIntegerTests
    {
        [Test]
        public void ParseZeroInt()
        {
            // given
            // hex dump of 0
            var data = new byte[] { 0x30 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.ZeroInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosOneInt()
        {
            // given
            // hex dump of 1
            var data = new byte[] { 0x31 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosOneInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosTwoInt()
        {
            // given
            // hex dump of 2
            var data = new byte[] { 0x32 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosTwoInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosThreeInt()
        {
            // given
            // hex dump of 3
            var data = new byte[] { 0x33 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosThreeInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosFourInt()
        {
            // given
            // hex dump of 4
            var data = new byte[] { 0x34 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosFourInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosFiveInt()
        {
            // given
            // hex dump of 5
            var data = new byte[] { 0x35 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosFiveInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosSixInt()
        {
            // given
            // hex dump of 6
            var data = new byte[] { 0x36 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosSixInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosSevenInt()
        {
            // given
            // hex dump of 7
            var data = new byte[] { 0x37 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosSevenInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosEightInt()
        {
            // given
            // hex dump of 8
            var data = new byte[] { 0x38 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosEightInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParsePosNineInt()
        {
            // given
            // hex dump of 9
            var data = new byte[] { 0x39 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.PosNineInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegSixInt()
        {
            // given
            // hex dump of -6
            var data = new byte[] { 0x3a };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegSixInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegFiveInt()
        {
            // given
            // hex dump of -5
            var data = new byte[] { 0x3b };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegFiveInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegFourInt()
        {
            // given
            // hex dump of -4
            var data = new byte[] { 0x3c };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegFourInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegThreeInt()
        {
            // given
            // hex dump of -3
            var data = new byte[] { 0x3d };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegThreeInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegTwoInt()
        {
            // given
            // hex dump of -2
            var data = new byte[] { 0x3e };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegTwoInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseNegOneInt()
        {
            // given
            // hex dump of -1
            var data = new byte[] { 0x3f };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SmallInteger, segment.Type);
            Assert.AreEqual(ValueType.NegOneInt, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }
    }
}
