using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NonSensicalValueTests
    {
        [Test]
        public void DeserializeMinKeyValue()
        {
            // given
            var data = Hex.MinKeyValue;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }

        [Test]
        public void DeserializeMaxKeyValue()
        {
            // given
            var data = Hex.MaxKeyValue;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
