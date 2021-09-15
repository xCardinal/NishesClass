using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.PostcodesIOService
{
    public class CallManager
    {
        //Restsharp Object which handles comms with the API
        private readonly IRestClient _client;

        //capture status
        public int StatusCode { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        ///<summary>
        ///define and makes the API request and stores the response
        ///</summary>
        ///<param name="postcode"></param>
        
        public async Task<string> MakePostcodeRequestAsync(string postcode)
        {
            //Set up the request
            var request = new RestRequest();

            //Add Header ( extra notes ( I want the results to return in json format)  )
            request.AddHeader("Content-Type", "application/json");

            //Define the request resource path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            //Make Request
            IRestResponse response = await _client.ExecuteAsync(request);

            //Status Code
            StatusCode = (int)response.StatusCode;

            return response.Content;


        }
    }
}
