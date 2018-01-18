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
    public class Posts : ApiTestBase
    {
        /// <summary>
        /// Test GET Post
        /// </summary>
        [Fact]
        public async Task Get()
        {
            // get a post key.

            var home = await _client.Home.GetAsync(currentApiVersion);
            
            string key = home.FeaturePostKey;

            var post = await _client.Posts.GetOneAsync(key,currentApiVersion);

            Assert.True(post != null);
        }

        /// <summary>
        /// Test GET list of posts.
        /// </summary>
        [Fact]
        public async Task GetList()
        {
            // get a post key.

            var home = await _client.Home.GetAsync(currentApiVersion);

            string key = home.FeaturePostKey;

            var post = await _client.Posts.GetOneAsync(key, currentApiVersion);

            List<string> postKeys = new List<string>();
            postKeys.Add(key);

            var posts = await _client.Posts.GetAsync(currentApiVersion, postKeys);

            Assert.Equal(posts[0].Key, post.Key);

        }

        /// <summary>
        /// Test GET latest
        /// </summary>
        [Fact]
        public async Task GetLatest()
        {
            // get a post key.

            var home = await _client.Home.GetAsync(currentApiVersion);

            string key = home.FeaturePostKey;

            var post = await _client.Posts.GetOneAsync(key, currentApiVersion);

            string indexKind = post.Kind;
            string indexKey = post.LeadMinistryKey;

            var latest = await _client.Posts.GetLatestAsync(indexKind, indexKey, currentApiVersion);

            Assert.True(latest != null);

        }

        /// <summary>
        /// Test GET All Keys
        /// </summary>
        [Fact]
        public async Task GetAllKeys()
        {
            // get a post key.

            var home = await _client.Home.GetAsync(currentApiVersion);

            string key = home.FeaturePostKey;

            var post = await _client.Posts.GetOneAsync(key, currentApiVersion);

            string indexKind = post.Kind;
            string indexKey = post.LeadMinistryKey;

            var allKeys = await _client.Posts.GetAllKeysAsync(indexKind, indexKey, currentApiVersion);

            Assert.True(allKeys != null);

        }

        /// <summary>
        /// Test GET by reference
        /// </summary>
        [Fact]
        public async Task GetByReference()
        {
            // get a post key.

            var home = await _client.Home.GetAsync(currentApiVersion);

            string key = home.FeaturePostKey;

            var post = await _client.Posts.GetOneAsync(key, currentApiVersion);

            string reference = post.Reference;

            var keyPair = await _client.Posts.GetKeyFromReferenceAsync(reference, currentApiVersion);

            Assert.True(keyPair != null);

            Assert.Equal(keyPair.Key, key);

        }

        /// <summary>
        /// Test GET latest media uri
        /// </summary>
        [Fact]
        public async Task GetLatestMediaUri()
        {
            var youtube = await _client.Posts.GetLatestMediaUriAsync("youtube", currentApiVersion);

            Assert.True(youtube != null);

            var flickr =  await _client.Posts.GetLatestMediaUriAsync("flickr", currentApiVersion);

            Assert.True(flickr != null);

        }

    }
}

