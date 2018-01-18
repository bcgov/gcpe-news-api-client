using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

using System.IO;
using System.Net.Http;

namespace Gov.News.Api.ClientTests
{
    public abstract class ApiTestBase
    {
        protected readonly IClient _client;
        protected const string currentApiVersion = "1.0";
        protected const string invalidPathKey = "invalidPathKey1234567890";

        /// <summary>
        /// Setup the test
        /// </summary>        
        public ApiTestBase()
        {
            _client = new Gov.News.Api.Client();
            _client.BaseUri = new Uri("https://dev.api.news.gov.bc.ca");
        }
    }
}
