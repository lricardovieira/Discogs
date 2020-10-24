using Discogs.Infra.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Discogs.Test.Tests
{
    public class GetDiscogsTest
    {
        #region THEORY
        #endregion

        #region FACT
        [Fact]
        public async Task Fact_GetDiscogs()
        {

            var environment = DiscogsApiEnvironment.CreateDefault();
            var client =  DiscogsApiClient.Create(environment);
            var db = client.Database;
            var searchResults = await db.Search();

            Assert.NotNull(searchResults);

        }


  
        [Fact]
        public async Task Fact_GetDiscogsParamter()
        {
            int num = 2;

            var environment = DiscogsApiEnvironment.CreateDefault();
            var client = DiscogsApiClient.Create(environment);
            var db = client.Database;
            var searchResults = await db.Search();
            
            var rng = new Random();
            var result = Enumerable.Range(1, num).Select(n => searchResults.Releases[rng.Next(searchResults.Releases.Count)]).ToList();

            Assert.Equal(2, result.Count());

        }

        #endregion
    }
}
