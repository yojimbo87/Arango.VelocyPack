using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class IllegalValueTests
    {
        [Test]
        public void DeserializeIllegalValueHexDump()
        {
            // given
            var data = ValueHexDumps.Illegal;

            // when
            var value = VelocyPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
