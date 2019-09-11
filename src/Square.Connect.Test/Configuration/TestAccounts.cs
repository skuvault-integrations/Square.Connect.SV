using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Square.Connect.Test
{
    public class TestAccounts
    {
        private static readonly string jsonFilePath = @"\..\..\..\TestAccounts.json";
        private static Dictionary<String, AccountInfo> accounts;

        public AccountInfo this[String name]
        {
            get
            {
                if (accounts == null)
                {
                    var json = LoadAccountsJson();
                    accounts = JsonConvert.DeserializeObject<Dictionary<String, AccountInfo>>(json);
                }
                return accounts[name];
            }
        }

        private string LoadAccountsJson()
        {
            var path = new Uri( Path.GetDirectoryName( Assembly.GetExecutingAssembly().CodeBase ) ).LocalPath;

            using (var streamReader = new StreamReader(path + jsonFilePath, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }
    }

    public class AccountInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("location_id")]
        public string LocationId { get; set; }
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }
}