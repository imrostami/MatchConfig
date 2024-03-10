namespace MatchConfig.Test
{
    public class MatchersTest
    {
        ConfigMatcher matcher;

        public MatchersTest()
        {
            matcher = new ConfigMatcher();
        }



        [Fact]
        public void VlessMatcherTest()
        {
            var result = matcher.VlessProxy.Match(SampleData.VlessShadowSocksComplexData);
            
            Assert.NotEmpty(result);
        }
        [Fact]
        public void VmessMatcherTest()
        {
            var result = matcher.VmessProxy.Match(SampleData.VmessShadowsocksCleanData);
            Assert.NotEmpty(result);
        }
        [Fact]
        public void ShadowSocksMatcherTest()
        {
            var result = matcher.ShadowSocksProxy.Match(SampleData.VmessShadowsocksCleanData);
            Assert.NotEmpty(result);
        }
        [Fact]
        public void TrojanMatcherTest()
        {
            var result = matcher.TrojanProxy.Match(SampleData.TrojanData);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TelegramProxyMatcherTest()
        {
            var result = matcher.TelegramProxy.Match(SampleData.TelegramProxy);

            Assert.NotEmpty(result);
        }
    }
}