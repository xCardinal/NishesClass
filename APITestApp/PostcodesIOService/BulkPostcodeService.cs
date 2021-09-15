//using RestSharp;
//using System;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System.Collections.Generic;

//namespace APITestApp.PostcodesIOService
//{
//    public class BulkPostcodeService
//    {
//        public RestClient Client;
//        public JObject ResponseContent { get; set; }
//        public List<string> OutcodesSelected { get; set; }

//        public int Statuscode { get; set; }

//        public BulkPostcodeService ResponseObject { get; set; }

//        public BulkPostcodeService()
//        {
//            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
//        }

//        public async Task MakeRequestAsync(List<string> outcodesList)
//        {
//            JObject postcodes = new JObject { new JProperty("postcodes", new JArray(outcodesList)) };

//            var request = new RestRequest();

//            request.AddHeader("Content-Type", "application.json");

//            OutcodesSelected = outcodesList;

//            request.Resource = $"postcodes/";

//            request.AddJsonBody(postcodes.ToString());

//            IRestResponse response = await Client.ExecuteAsync(request);

//            //Parse JSON in response content
//            ResponseContent = JObject.Parse(response.Content);

//            Statuscode = (int)response.StatusCode;

//            //Parse JSON string into an object treetcodeService>(r
//            ResponseObject = JsonConvert.DeserializeObject<BulkPostcodeService>(response.Content);


//        }
//    }
//}
