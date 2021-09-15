//using NUnit.Framework;
//using APITestApp.PostcodesIOService;
//using System.Threading.Tasks;

//namespace APITestApp.Tests
//{
//    public class WhenTheSingleOutcodeServiceIsCalled_WithValidPostcode
//    {
//        private SingleOutcodeService _singleOutcodeService;

//        [OneTimeSetUp]
//        public async Task OneTimeSetUpAsync()
//        {
//            _singleOutcodeService = new SingleOutcodeService();
//            await _singleOutcodeService.MakeRequestAsync("EC2Y");
//        }

//        [Test]
//        public void StatusIs200()
//        {
//            Assert.That(_singleOutcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
//        }
//        [Test]
//        public void StatusIs200_Alt()
//        {
//            Assert.That(_singleOutcodeService.Statuscode, Is.EqualTo(200));
//        }
//        [Test]
//        public void CorrectPostcodeIsReturned()
//        {
//            Assert.That(_singleOutcodeService.ResponseContent["result"]["outcode"].ToString(),
//                Is.EqualTo("EC2Y"));
//        }

//        //[Test]
//        //public void ObjectStatusIsOk()
//        //{
//        //    Assert.That(_singleOutcodeService.ResponseContent["status"], Is.EqualTo("OK"));
//        //}




//    }
//}
