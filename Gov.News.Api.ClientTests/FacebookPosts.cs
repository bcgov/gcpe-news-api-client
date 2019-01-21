using System.Threading.Tasks;
using Xunit;


namespace Gov.News.Api.ClientTests
{
    public class FacebookPosts : ApiTestBase
    {

        /// <summary>
        /// Test GET Facebook Post by URI
        /// </summary>
        [Fact]
        public async Task GetByUri()
        {
            var home = await _client.Home.GetAsync(currentApiVersion);

            var post = await _client.Posts.GetOneAsync(home.FeaturePostKey, currentApiVersion);

            if (post.AssetUrl.ToLower().Contains("facebook"))
            {

                var facebookPost = await _client.FacebookPosts.GetByUriAsync(currentApiVersion, post.AssetUrl);

                Assert.Equal(post.AssetUrl, facebookPost.Key);
            }
        }
    }
}
