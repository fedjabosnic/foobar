using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test
{
    [TestClass]
    public class tests
    {
        [TestMethod]
        public void should_work()
        {
            true.Should().Be(true);
        }
    }
}
