using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class NullValueTests
    {
        [Test]
        public void SegmentizeNullValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNullValue);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NullSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Null, segment.Type);
            Assert.AreEqual(ValueType.Null, segment.ValueType);
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
