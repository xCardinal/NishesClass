using System;
using System.Threading.Tasks;
using APIClientApp.PostcodesIOService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APITestApp.PostcodesIOService
{
    class SinglePostcodeService
    {
        #region OldProperties
        ////RestSharp Object which handles comans with the api
        //public RestClient Client;

        ////A newtonsoft object representing the json response
        //public JObject ResponseContent { get; set; }

        ////The postcode used in this API request
        //public string PostcodeSelected { get; set; }

        ////Store the status code
        //public int Statuscode { get; set; }

        //public SinglePostcodeService ResponseObject { get; set; }
        #endregion

        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }

        //The Response DATA TRANSFER OBJECT ( DTO ) 
        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }

        //The postcode is in the API Request
        public string PostcodeSelected { get; set; }
        public string PostcodeResponse { get; set; }

        //Constructor - Creates the restclient object
        public SinglePostcodeService()
        {
            //Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
            CallManager = new CallManager();
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();

        }

        public async Task MakeRequestAsync(string postcode)
        {
            PostcodeSelected = postcode;

            //Make REQUEST
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync(postcode);

            //Parse JSON in response content
            Json_Response = JObject.Parse(PostcodeResponse);

            //Use DTO to convert JSON string into an object tre
            SinglePostcodeDTO.DeserializeResponse(PostcodeResponse);

            ////Set up the request
            //var request = new RestRequest();
            ////request.Method = Method.GET;

            //request.AddHeader("Content-Type", "application.json");

            //PostcodeSelected = postcode;

            ////Define the request path
            //request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            ////Make the request
            //IRestResponse response = await Client.ExecuteAsync(request);

            //Parse JSON in response content
            //ResponseContent = JObject.Parse(response.Content);

            //Capture status code
            //Statuscode = (int)response.StatusCode;

            //Parse JSON string into an object tree
            //ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeService>(response.Content);

        }

        public int CodeCount()
        {
            var count = 0;
            foreach(var code in Json_Response["result"]["codes"])
            {
                count++;
            }
            return count;
        }

    }
}
