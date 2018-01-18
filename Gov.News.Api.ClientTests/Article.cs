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
    public class Article : ApiTestBase
    {
        /// <summary>
        /// Test GET search
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            // get an article.
            var item = await _client.Article.GetAllAsync(currentApiVersion);

            Assert.True(item != null);

            string key = item[0].ArticleKey;  
            
        }

    }
}
