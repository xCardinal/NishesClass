using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Set up Request
            //Client property which is equaly to a new 'RestSharp'.
            //We are going to create a Uri Objects which 

            var restClient = new RestClient(@"http://api.postcodes.io/");

            //Set up request
            var restRequest = new RestRequest(Method.GET);

            //Set method as GET
            restRequest.Method = Method.GET;

            //Add head
            restRequest.AddHeader("Content-Type", "application/json");

            //Set time out
            restRequest.Timeout = -1;

            var postcode = "EC2Y 5AS";
            restRequest.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            #endregion

            #region Execute Request
            //Execute the Request - if code is 200 , it's ok !
            var singlePostcodeResponse = restClient.Execute(restRequest);

            //Query everything in the response variable "singlePostcodeResponse"

            //Console.WriteLine("Response Content as string");
            //Console.WriteLine(singlePostcodeResponse.Content);

            #endregion

            #region Set Up & Post

            var client = new RestClient("http://api.postcodes.io/postcodes/");

            client.Timeout = -1;

            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");

            //Jproperty is a key/value pair
            JObject postcodes = new JObject { new JProperty("postcodes", new JArray(new string[] { "OX49 5NU", "M32 0JG", "NE30 1DP" })) };

            request.AddJsonBody(postcodes.ToString());
            //request.AddParameter("application/json", postcodes.ToString(), ParameterType.RequestBody);

            IRestResponse bulkPostcodeResponse = client.Execute(request);

            //Console.WriteLine(bulkPostcodeResponse.Content);

            //Cast the enum StatusCode to an int to see the actual integer status code
            Console.WriteLine($"Status Code: {bulkPostcodeResponse.StatusCode}");
            Console.WriteLine($"Status Code: {(int)bulkPostcodeResponse.StatusCode}");

            //var course = new JObject
            //{
            //    new JProperty ("name", "eng91"),
            //    new JProperty("trainees", new JArray(new string[] { "Ringo", "Paul", "John"})),
            //    new JProperty ("total", 4)
            //    };

            //Query tje results to a Json object

            var bulkJsonResponse = JObject.Parse(bulkPostcodeResponse.Content);
            var singleJsonResponse = JObject.Parse(singlePostcodeResponse.Content);

            //Console.WriteLine(singleJsonResponse["status"]);
            //Console.WriteLine(singleJsonResponse["result"]["codes"]);
            //Console.WriteLine(singleJsonResponse["result"]["codes"]["parish"]);
            //Console.WriteLine(bulkJsonResponse["result"][0]["query"]);
            //Console.WriteLine(bulkJsonResponse["result"][1]["result"]["country"]);

            #endregion

            var singPostCode = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
            var bulkPostCode = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content);

            //Console.WriteLine(singPostCode.result.country);
            //Console.WriteLine(singPostCode.result.codes.admin_county);

            foreach (var result in bulkPostCode.result)
            {
                Console.WriteLine(result.query);
                Console.WriteLine(result.postcode.region);
            }

            var result2 = bulkPostCode.result.Where(p => p.query == "OX49 5NU").Select(p => p.postcode.parish).FirstOrDefault();
        }



    }
}
