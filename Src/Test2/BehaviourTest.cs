using FluentAssertions;
using NUnit.Framework;
using Test2.Console;

namespace Test2
{
    [TestFixture]
    public class BehaviourTest
    {
        private NumberGenerator _nums;

        [SetUp]
        public void SetUp()
        {
            _nums = new NumberGenerator();
        }

        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Ansible")]
        [TestCase(4, "4")]
        [TestCase(5, "Australia")]
        [TestCase(6, "Ansible")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(9, "Ansible")]
        [TestCase(10, "Australia")]
        [TestCase(11, "11")]
        [TestCase(12, "Ansible")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        [TestCase(15, "Ansible Australia")]
        [TestCase(16, "16")]
        [TestCase(17, "17")]
        public void StateTests(int input, string expected)
        {
            _nums.Get(input).Should().Be(expected);
        }
    }

}
