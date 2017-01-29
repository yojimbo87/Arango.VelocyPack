using NUnit.Framework;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Deserialization
{
    [TestFixture]
    public class NullValueTests
    {
        [Test]
        public void DeserializeNullValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNullValue);

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.IsNull(value);
        }
    }
}
