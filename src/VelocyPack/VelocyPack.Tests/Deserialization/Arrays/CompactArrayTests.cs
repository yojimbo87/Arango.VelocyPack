using System.Collections.Generic;
using NUnit.Framework;

namespace VelocyPack.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class CompactArrayTests
    {
        [Test]
        public void DeserializeCompactArrayHexDump()
        {
            // TODO: cast to List<sbyte>

            // given
            var data = ArrayHexDumps.Compact;

            // when
            var value = VelocyPack.ToObject<List<object>>(data);

            // then
            // array
            Assert.IsInstanceOf<List<object>>(value);
            Assert.AreEqual(3, value.Count);

            // first item
            var item1 = value[0];

            Assert.IsInstanceOf<sbyte>(item1);
            Assert.AreEqual(1, item1);

            // second item
            var item2 = value[1];

            Assert.IsInstanceOf<sbyte>(item2);
            Assert.AreEqual(2, item2);

            // third item
            var item3 = value[2];

            Assert.IsInstanceOf<sbyte>(item3);
            Assert.AreEqual(3, item3);
        }
    }
}
