using System;

namespace Gov.News.Api.ClientTests
{
    public abstract class ApiTestBase
    {
        protected readonly Gov.News.Api.IClient _client;
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
