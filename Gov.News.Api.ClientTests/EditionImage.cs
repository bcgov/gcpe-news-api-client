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
    public class EditionImage : ApiTestBase
    {

        /// <summary>
        /// Test GET edition image
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
            var item = await _client.EditionImage.GetOneAsync(key, currentApiVersion);

            Assert.True(item != null);
        }


        /// <summary>
        /// Test invalid get
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            bool foundException = false;
            try
            {
                // get an article.
                var item = await _client.EditionImage.GetOneAsync(invalidPathKey, currentApiVersion);
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
