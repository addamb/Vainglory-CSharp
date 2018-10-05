using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Vainglory_CSharp.Model.Status;
using Vainglory_CSharp.Utils;

namespace Vainglory_CSharp.API
{
    public class AbstractAPI
    {
        //HTTP Headers and Values
        public const string AcceptHeader = "Accept";
        public const string AcceptValue = "application/vnd.api+json";

        public const string AuthorizationHeader = "Authorization";

        public string APIKey = null;

        public StatusData APIStatus;
        public bool statusChecked;

        public Shard shard = Shard.NorthAmerica;

        //Api Urls
        public const string APIUrl = "https://api.dc01.gamelockerapp.com/shards/";
        public const string StatusUrl = "https://api.dc01.gamelockerapp.com/status/";

        public AbstractAPI(string key)
        {
            this.APIKey = key;
        }

        public void CheckAPIStatus()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + APIKey);
                    client.DefaultRequestHeaders.Add("Accept", "application/vnd.api+json");
                    var response = client.GetAsync(StatusUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        //var players = PlayerData.FromJson(result);
                        APIStatus = StatusData.FromJson(result);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            statusChecked = true;
        }
    }
}
