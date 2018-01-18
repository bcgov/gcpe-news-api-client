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
    public class ArticleBody : ApiTestBase
    {
        /// <summary>
        /// Test GET 
        /// </summary>
        [Fact]
        public async void Get()
        {
            // get an article.
            var items = await _client.Article.GetAllAsync(currentApiVersion);
            var item = items[0];

            string articleKey = item.ArticleKey;
            string newsletterKey = item.NewsletterKey;
            string editionKey = item.EditionKey;

            string key = newsletterKey + "/" + editionKey + "/" + articleKey;

            var articleBody = await _client.ArticleBody.GetOneAsync(key, currentApiVersion);
            
            Assert.True(articleBody != null);

            // get using the second variant.

            var second = await _client.ArticleBody.GetOneCompoundKeyAsync(newsletterKey, editionKey, articleKey, currentApiVersion);

            Assert.True(second != null);

            Assert.Equal(articleBody.HtmlBody, second.HtmlBody);
        }

    }
}
