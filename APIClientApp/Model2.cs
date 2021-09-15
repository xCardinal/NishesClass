using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp
{
    public class SingleOutcodeResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        public OutCodeResult result { get; set; }
    }
    public class BulkOutcodeResponse
    {
        [JsonProperty("status")]
        public int status { get; set; }
        public SingleOutResult[] @result { get; set; }
    }
    public class SingleOutResult
    {
        public string query { get; set; }

        [JsonProperty("result")]
        public OutCodeResult outcode { get; set; }
    }

    public class OutCodeResult
    {
        public string outcode { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public int northings { get; set; }
        public int eastings { get; set; }
        public string[] admin_district { get; set; }
        public string[] parish { get; set; }
        public string[] admin_county { get; set; }
        public string[] admin_ward { get; set; }
        public string[] country { get; set; }
    }

}
