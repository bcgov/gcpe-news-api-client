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


namespace Gov.News.Api.ClientTests
{
    public class Category : ApiTestBase
    {
        /// <summary>
        /// Test invalid GET category
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            // get the top post.
            var topPost = await _client.Post.GetTopPostAsync(currentApiVersion);


            string key = topPost.LeadMinistryKey;
            string collection = topPost.Collection;


            // get an article.
            var item = await _client.Category.GetOneAsync(collection, key, currentApiVersion);

            Assert.True(item == null);            
        }

    }
}
