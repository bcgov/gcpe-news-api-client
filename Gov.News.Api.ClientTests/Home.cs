using Xunit;


namespace Gov.News.Api.ClientTests
{
    public class Home : ApiTestBase
    {
        /// <summary>
        /// Test GET Home
        /// </summary>
        [Fact]
        public async void GetHome()
        {
            var home = await _client.Home.GetAsync(currentApiVersion);
            Assert.True(home != null);
        }
    }
}
