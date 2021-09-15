//using System;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using RestSharp;


//namespace APITestApp.PostcodesIOService
//{
//    public class SingleOutcodeService
//    {
//        //RestSharp Object which handles comans with the api
//        public RestClient Client;

//        //A newtonsoft object representing the json response
//        public JObject ResponseContent { get; set; }

//        //The postcode used in this API request
//        public string OutcodeSelected { get; set; }

//        //Store the status code
//        public int Statuscode { get; set; }

//        public SingleOutcodeService ResponseObject { get; set; }

//        //Constructor - Creates the restclient object
//        public SingleOutcodeService()
//        {
//            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
//        }

//        public async Task MakeRequestAsync(string outcode)
//        {
//            //Set up the request
//            var request = new RestRequest();
//            //request.Method = Method.GET;

//            request.AddHeader("Content-Type", "application.json");

//            OutcodeSelected = outcode;

//            //Definethe request path
//            request.Resource = $"outcodes/{outcode.ToLower()}";

//            //Make the request
//            IRestResponse response = await Client.ExecuteAsync(request);

//            //Parse JSON in response content
//            ResponseContent = JObject.Parse(response.Content);

//            //Capture status code
//            Statuscode = (int)response.StatusCode;

//            //Parse JSON string into an object tree
//            ResponseObject = JsonConvert.DeserializeObject<SingleOutcodeService>(response.Content);

//        }
//        public void MakeRequestAsync(string[] outcode)
//        {
//            //Set up the request
//            var request = new RestRequest();
//            //request.Method = Method.GET;

//            request.AddHeader("Content-Type", "application.json");

//            //OutcodeSelected = outcode;

//            ////Definethe request path
//            //request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

//            //Make the request
//            IRestResponse response = Client.Execute(request);

//            //Parse JSON in response content
//            ResponseContent = JObject.Parse(response.Content);

//            //Capture status code
//            Statuscode = (int)response.StatusCode;

//            //Parse JSON string into an object tree
//            ResponseObject = JsonConvert.DeserializeObject<SingleOutcodeService>(response.Content);

//        }

//    }
//}
