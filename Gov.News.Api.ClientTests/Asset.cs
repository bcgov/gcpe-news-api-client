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

using System.Reflection;
using Microsoft.Rest;

namespace Gov.News.Api.ClientTests
{
    public class Asset : ApiTestBase
    {
        /// <summary>
        /// Test GET Asset
        /// </summary>
        [Fact]
        public async void ValidGet()
        {
            // get a path to an asset.
            string path = "xcvbxcvbxcv";
            // get an article.
            var item = await _client.Asset.GetOneAsync(path, currentApiVersion);

            Assert.True(item != null);
            
        }

        /// <summary>
        /// Test invalid data
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            // intentionally pass an invalid path.

            bool foundException = false;
            try
            {
                var item = await _client.Asset.GetOneAsync(invalidPathKey, currentApiVersion);
            }
            catch (HttpOperationException e)
            {
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    foundException = true;
                }
            }
            // the request should not crash the api server...

            Assert.True(foundException);
        }
    }
}
