using System.Collections.Generic;
using NUnit.Framework;
using Arango.VelocyPack.Tests.HexDumps;

namespace Arango.VelocyPack.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class EmptyArrayTests
    {
        [Test]
        public void DeserializeEmptyArrayHexDump()
        {
            // given
            var data = ArrayHexDumps.Empty;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(0, value.Count);
        }
    }
}
