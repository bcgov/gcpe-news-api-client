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
using Microsoft.Rest;

namespace Gov.News.Api.ClientTests
{
    public class FacebookPage : ApiTestBase
    {
        /// <summary>
        /// Test GET facebook page
        /// </summary>
        [Fact]
        public async void Get()
        {
            /* Is FacebookPage deprecated in the API?  we may not need this test.
             * 
            var faceBookPost = await _client.FacebookPost.GetNewestAsync(currentApiVersion);
            String key = faceBookPost.Key;

            
    

            var facebookPage = await _client.FacebookPage.GetOneAsync(topPost.Key, currentApiVersion);

            Assert.True(facebookPage != null);
            */
        }

        /// <summary>
        /// Test invalid GET facebook page
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            bool foundException = false;
            try
            {
                // attempt a get using an invalid key.      
                var item = await _client.FacebookPage.GetOneAsync(invalidPathKey, currentApiVersion);
            }
            catch (HttpOperationException e)
            {
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    foundException = true;
                }
            }
            Assert.True(foundException);
        }


    }
}
