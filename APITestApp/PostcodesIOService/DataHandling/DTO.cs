using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Constraints specify that the DTO can only be of IResponse type, AND specifies the new()
//that a type argument in a general class declaration MUST have a public parameterless constructor.

//the new() method instantiates and reads the constructor
namespace APITestApp.PostcodesIOService
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        //A property which creates the model
        public ResponseType Response { get; set; }


        //Method that creates the above objects using the response from the API
        public void DeserializeResponse(string postcodeResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(postcodeResponse);
        }
    }
}
