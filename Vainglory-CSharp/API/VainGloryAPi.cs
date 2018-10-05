using System;
using System.Collections.Generic;
using System.Net.Http;
using Vainglory_CSharp.Model.Match;
using Vainglory_CSharp.Model.Player;
using Vainglory_CSharp.Utils;

namespace Vainglory_CSharp.API
{
    public class VainGloryAPI : AbstractAPI
    {
        public const string PlayerEndpoint = "/players";
        public const string PlayerFilterByIds = "?filter[playerIds]=";
        public const string PlayerFilterByNames = "?filter[playerNames]=";

        public const string MatchesEndpoint = "/matches";

        public VainGloryAPI(string key) : base(key)
        {
            
        }

        public PlayerData GetPlayerByIdJson(string playerId)
        {
            PlayerData player = null;
            var shardId = GetShardDescription(shard);

            var playerIdUrl = $"{APIUrl}{shardId}{PlayerEndpoint}/{playerId}";
            var result = GetApiJsonResponse(playerIdUrl);

            player = PlayerData.FromJson(result);

            return player;
        }

        public PlayerData GetPlayersByIdsJson(List<string> playersIds)
        {
            PlayerData players = null;

            var ids = string.Join(",", playersIds.ToArray());
            var shardId = GetShardDescription(shard);
            
            var playersIdsUrl = $"{APIUrl}{shardId}{PlayerEndpoint}{PlayerFilterByIds}{ids}";
            var result = GetApiJsonResponse(playersIdsUrl);

            players = PlayerData.FromJson(result);

            return players;
        }

        public PlayerData GetPlayerByNameJson(string name)
        {
            PlayerData player = null;
            var shardId = GetShardDescription(shard);

            var playerNameUrl = $"{APIUrl}{shardId}{PlayerEndpoint}{PlayerFilterByNames}{name}";
            var result = GetApiJsonResponse(playerNameUrl);

            player = PlayerData.FromJson(result);

            return player;
        }

        public PlayerData GetPlayersByNamesJson(List<string> playersNames)
        {
            PlayerData players = null;
            var shardId = GetShardDescription(shard);

            var names = string.Join(",", playersNames.ToArray());

            var playersNamesUrl = $"{APIUrl}{shardId}{PlayerEndpoint}{PlayerFilterByNames}{names}";
            var result = GetApiJsonResponse(playersNamesUrl);

            players = PlayerData.FromJson(result);

            return players;
        }

        public MatchData GetMatch()
        {
            MatchData match = null;
            var shardId = GetShardDescription(shard);
       
            var matchUrl = $"{APIUrl}{shardId}{MatchesEndpoint}";
            var result = GetApiJsonResponse(matchUrl);

            match = MatchData.FromJson(result);

            return match;
        }

        private string GetApiJsonResponse(string url)
        {
            string result = "";
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APIKey);
                    client.DefaultRequestHeaders.Add("Accept", "application/vnd.api+json");

                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsStringAsync().Result;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                client.Dispose();
            }

            return result;
        }

        private string GetApiGZipResponse(string url)
        {
            string result = "";
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APIKey);
                    client.DefaultRequestHeaders.Add("Accept-Encoding","gzip");

                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsStringAsync().Result;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                client.Dispose();
            }

            return result;
        }

        private string GetShardDescription(Shard shard)
        {
            return (new Utils.ShardId().GetDescription(shard));
        }
    }
}
