using Xunit;


namespace Gov.News.Api.ClientTests
{
    public class Tags : ApiTestBase
    {
        /// <summary>
        /// Test GET tags
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var tag = await _client.Tags.GetAllAsync(currentApiVersion);

            Assert.True(tag != null);
        }

        /// <summary>
        /// Test GET tag (one)
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var tags = await _client.Tags.GetAllAsync(currentApiVersion);
            var tag = tags[0];

            Assert.True(tag != null);

            var second = await _client.Tags.GetOneAsync(tag.Key, currentApiVersion);

            Assert.True(second != null);
            Assert.Equal(tag.Key, second.Key);
        }
    }
}
