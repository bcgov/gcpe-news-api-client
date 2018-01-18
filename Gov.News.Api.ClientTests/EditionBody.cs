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
    public class EditionBody : ApiTestBase
    {

        /// <summary>
        /// Test GET EditionBody
        /// </summary>
        [Fact]
        public async void Get()
        {
            var editions = await _client.Edition.GetAllAsync(currentApiVersion);
            // get a calendar
            var edition = editions[0];

            string editionKey = edition.EditionKey;
            string newsletterKey = edition.NewsletterKey;

            string key = newsletterKey + "/" + editionKey;

            // get an article.
            var item = await _client.EditionBody.GetOneAsync(key, currentApiVersion);

            Assert.True(item != null);

            // get using the alternate method.

            var second = await _client.EditionBody.GetOneByNewsletterKeyAndEditionKeyAsync(newsletterKey, editionKey, currentApiVersion);

            Assert.True(second != null);

            Assert.Equal(item.HtmlBody, second.HtmlBody);
        }

        /// <summary>
        /// Test GET search
        /// </summary>
        [Fact]
        public async Task InvalidGet()
        {
            bool foundException = false;
            try
            {
                // attempt a get using an invalid key. 
                var item = await _client.EditionBody.GetOneAsync(invalidPathKey, currentApiVersion);
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
