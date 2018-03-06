using FooBarQixKata;
using NUnit.Framework;

namespace FooBarQixKataTest
{
    public class FooBarQixTest
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(11, "11")]
        public void should_return_same_number_if_not_divisible_by_3_5_7_or_contains_3_5_7(int number, string expected)
        {
            string result = new FooBarQix().Transform(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(6, "Foo")]
        [TestCase(9, "Foo")]
        public void should_return_Foo_when_number_is_divisible_by_3(int number, string expected)
        {
            string result = new FooBarQix().Transform(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase(13, "Foo")]
        public void Should_return_Foo_when_number_contains_3(int number, string expected)
        {
            string actual = new FooBarQix().Transform(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(17, "Qix")]
        public void Should_return_Qix_when_number_contains_7(int number, string expected)
        {
            string actual = new FooBarQix().Transform(number);
            Assert.AreEqual(expected, actual);
        }

    }
}
