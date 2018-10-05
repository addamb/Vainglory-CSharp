using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vainglory_CSharp.Model.Player;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Vainglory_CSharp.Model.Match;
using Vainglory_CSharp.API;
using System;

namespace VaingloryCSharpTests
{
    [TestClass]
    public class AbstractAPI_UnitTest
    {
        [TestMethod]
        public void Test_AbstactApi_CheckAPIStatus()
        {
            string token = ""; // Add Token Here
            string versionReleasedAtDate = "2018-04-05T15:18:52Z";
            string version = "v7.10.2";

            //Created AbstractAPI with token
            AbstractAPI testApi = new AbstractAPI(token);

            Assert.IsFalse(testApi.statusChecked);
            //Run CheckAPIStatus
            testApi.CheckAPIStatus();

            Assert.IsTrue(testApi.statusChecked);

            var status = testApi.APIStatus.Status;

            //Check that status is not null
            Assert.IsNotNull(status);

            //Verify that the Id is correct
            Assert.AreEqual(status.Id, "gamelocker");

            //Verify that the type is status
            Assert.AreEqual(status.Type, "status");

            //Convert versionReleasedAtDate to DateTimeOffset
            if (!DateTimeOffset.TryParse(versionReleasedAtDate, out DateTimeOffset versionDate))
                versionDate = DateTimeOffset.Now;

            //Check ReleasedAt for current version
            Assert.AreEqual(status.Attributes.ReleasedAt, versionDate);

            //Check current Version
            Assert.AreEqual(status.Attributes.Version, version);
        }

        [TestMethod]
        public void TestMethod()
        {
            string player = "Blacklistedrnd";
            string player2 = "ThirdSiege";
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI2NDJlNGI1MC05NjhmLTAxMzYtOWU0OS0wYTU4NjQ2MGZlYWQiLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTM2NTE5MTM0LCJwdWIiOiJzZW1jIiwidGl0bGUiOiJ2YWluZ2xvcnkiLCJhcHAiOiJ0ZXN0c2RrIiwic2NvcGUiOiJjb21tdW5pdHkiLCJsaW1pdCI6MTB9.BNcA0qSiNnWgTZ3T23osZfiIj2HHG_ZMCieMQmWpTVA";
            //Bearer
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri($"https://api.dc01.gamelockerapp.com/shards/na/players?filter[playerNames]={player}");
            //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            //client.DefaultRequestHeaders.Add("Accept", "application/vnd.api+json");

            //var shard = new ShardId().GetDescription(ShardId.Shard.NorthAmerica);

            using (var client = new HttpClient())
            {
                var urlPlayer = $"https://api.dc01.gamelockerapp.com/shards/na/players?filter[playerNames]={player},{player2}";
                var url = $"https://api.dc01.gamelockerapp.com/shards/na/matches/030bf701-41a2-41f0-929b-3a8ae7f268e2";
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                client.DefaultRequestHeaders.Add("Accept", "application/vnd.api+json");
                var response = client.GetAsync(url).Result;//.GetStringAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    //var players = PlayerData.FromJson(result);
                    var matches = MatchData.FromJson(result);
                }
                
            }

        }
    }
}
