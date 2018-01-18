using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Text;
using Newtonsoft.Json;
using System.Net;


namespace Gov.News.Api.ClientTests
{
    public class FacebookPosts : ApiTestBase
    {
        /// <summary>
        /// Test GET Newest Facebook Post
        /// </summary>
        [Fact]
        public async Task GetNewest()
        {
            var facebookPost = await _client.FacebookPosts.GetNewestAsync(currentApiVersion);
            Assert.True(facebookPost != null);
        }

        /// <summary>
        /// Test GET Facebook Post by URI
        /// </summary>
        [Fact]
        public async Task GetByUri()
        {
            var newestFacebookPost = await _client.FacebookPosts.GetNewestAsync(currentApiVersion);

            var facebookPost = await _client.FacebookPosts.GetByUriAsync(currentApiVersion, newestFacebookPost.Key);

            Assert.Equal(newestFacebookPost.Key, facebookPost.Key);
        }
    }
}
