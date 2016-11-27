using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NullValueTests
    {
        [Test]
        public void DeserializeNullValueHexDump()
        {
            // given
            var data = ValueHexDumps.Null;

            // when
            var value = VelocyPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
