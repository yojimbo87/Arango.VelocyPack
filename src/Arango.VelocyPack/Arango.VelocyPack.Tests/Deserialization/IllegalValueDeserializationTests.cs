using NUnit.Framework;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class IllegalValueDeserializationTests
    {
        [Test]
        public void DeserializeIllegalValue()
        {
            // given
            var data = new byte[] { 0x17 };

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
