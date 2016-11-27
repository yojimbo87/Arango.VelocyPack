using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void DeserializeDoubleValueHexDump()
        {
            // given
            var data = ValueHexDumps.Double;

            // when
            var value = VelocyPack.ToObject<double>(data);

            // then
            Assert.AreEqual(0d, value);
        }
    }
}
