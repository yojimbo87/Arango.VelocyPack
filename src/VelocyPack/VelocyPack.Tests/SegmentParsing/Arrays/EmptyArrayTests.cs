using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class EmptyArrayTests
    {
        [Test]
        public void ParseEmptyArray()
        {
            // given
            // hex dump of []
            var data = new byte[] { 0x01 };

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
            Assert.AreEqual(0, segment.Items.Count);
        }
    }
}
