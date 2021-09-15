using NUnit.Framework;
using APITestApp.PostcodesIOService;
using System.Threading.Tasks;

namespace APITestApp.PostcodesIOService.Tests
{
    public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }
        [Test]
        public void StatusIs200_Alt()
        {
            Assert.That(_singlePostcodeService.Statuscode, Is.EqualTo(200));
        }
        [Test]
        public void CorrectPostcodeIsReturned()
        {
            Assert.That(_singlePostcodeService.ResponseContent["result"]["postcode"].ToString(),
                Is.EqualTo("EC2Y 5AS"));
        }

        [Test]
        public void ObjectStatusIs200()
        {
            //var 
        }




    }
}
