using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class BooleanValueTests
    {
        [Test]
        public void DeserializeFalseBooleanValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFalseValue);

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.IsFalse(value);
        }

        [Test]
        public void DeserializeTrueBooleanValueHexDump()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTrueValue);

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.IsTrue(value);
        }
    }
}
