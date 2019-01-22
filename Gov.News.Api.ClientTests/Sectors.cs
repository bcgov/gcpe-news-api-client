using Xunit;

namespace Gov.News.Api.ClientTests
{
    public class Sectors : ApiTestBase
    {
        /// <summary>
        /// Test GET sectors
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var sectors = await _client.Sectors.GetAllAsync(currentApiVersion);
            var sector = sectors[0];
            Assert.True(sector != null);
        }


        /// <summary>
        /// Test GET sectors
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var sectors = await _client.Sectors.GetAllAsync(currentApiVersion);
            var sector = sectors[0];

            var second = await _client.Sectors.GetOneAsync(sector.Key, currentApiVersion);
            Assert.True(second != null);

            Assert.Equal(sector.Key, second.Key);
        }

    }
}
