namespace StrykerDemo.Tests
{
    using Xunit;

    public class UtilityTests
    {
        [Fact]
        public void IsAdultShouldReturnResultAsExpected()
        {
            var isAdult = Utility.IsAdult(20);

            Assert.True(isAdult);
        }

        [Fact]
        public void AppendGuidTest()
        {
            var updatedValue = Utility.AppendWithGuid("aaa");

            Assert.NotNull(updatedValue);
            Assert.NotEqual("aaa", updatedValue);
        }
    }
}