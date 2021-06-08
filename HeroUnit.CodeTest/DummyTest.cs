using FluentAssertions;
using HeroUnit.Code;
using System;
using Xunit;

namespace HeroUnit.CodeTest
{
    public class DummyTest
    {
        [Fact]
        public void Dummy_Multiply_ShouldReturn4()
        {
            //arrange

            Dummy dummy = new();

            // action

            var result = dummy.Multiply();

            // assert
            result.Should().Be(4);
        }

        [Fact]
        public void Dummy_Multiply_ShouldFail()
        {
            //arrange

            Dummy dummy = new();

            // action

            var result = dummy.Multiply();

            // assert
            result.Should().Be(0);
        }
    }
}
