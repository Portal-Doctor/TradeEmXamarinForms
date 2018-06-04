using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TabSet.DataModel
{

        public partial class DataPosts
        {
            [JsonProperty("userId")]
            public long UserId { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }
        }

        public partial class DataPosts
        {
            public static List<DataPosts> FromJson(string json) => JsonConvert.DeserializeObject<List<DataPosts>>(json);
        }


    }

