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
    public class FlickrAsset : ApiTestBase
    {
        /// <summary>
        /// Test GET Flickr asset
        /// </summary>
        [Fact]
        public async void Get()
        {
            // get a post.
            var post = await _client.Post.GetFeaturePostAsync(currentApiVersion);

            var flickrAsset = await _client.FlickrAsset.GetFromPostReferenceAsync(currentApiVersion, post.Reference);

            Assert.True(flickrAsset != null);

        }
        

    }
}
