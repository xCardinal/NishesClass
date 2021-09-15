//using NUnit.Framework;
//using APITestApp.PostcodesIOService;
//using System.Threading.Tasks;
//using System.Collections.Generic;

//namespace APITestApp.Tests
//{
//    public class WhenTheBulkPostcodeServiceIsCalled_WithValidPostcode
//    {
//        private BulkPostcodeService _bulkPostService;

//        [OneTimeSetUp]
//        public async Task OneTimeSetUpAsync()
//        {
//            _bulkPostService = new BulkPostcodeService();
//            await _bulkPostService.MakeRequestAsync(new List<string> { "OX49 5NU", "M32 0JG", "NE30 1DP" });
//        }

//        [Test]
//        public void StatusIs200()
//        {
//            Assert.That(_bulkPostService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
//        }
//        [Test]
//        public void StatusIs200_Alt()
//        {
//            Assert.That(_bulkPostService.Statuscode, Is.EqualTo(200));
//        }
//        [Test]
//        public void CorrectPostcodeIsReturned()
//        {
//            //Assert.That(_bulkPostService.ResponseContent["result"]["postcode"].ToString(),
//            //    Is.EqualTo("EC2Y 5AS"));
//        }

//        [Test]
//        public void ObjectStatusIs200()
//        {
//            //var 
//        }




//    }
//}
