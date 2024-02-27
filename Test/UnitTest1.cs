using System.Net;
using System.Text.Json;
using FluentAssertions;
using InoDayJenkins;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;
using System.Security.Principal;

namespace InnoDayJenkinsTest
{
    public class Tests
    {
        private string _baseUrl => "https://localhost:7008/";

        private RestClient client;

        private PrimeService _primeService;

        [SetUp]
        public void Setup()
        {
            client = new RestClient(_baseUrl);
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            result.Should().BeFalse("1 should not be prime");
            Assert.Pass();
        }

        //[Test]
        public void Test1()
        {
            RestRequest restRequest = new RestRequest(_baseUrl + "WeatherForecast", Method.Get);
            RestResponse restResponse = client.Execute(restRequest);

            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            restResponse.Content.Should().NotBeNull();

            IEnumerable<WeatherForecast> list = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(restResponse.Content);
            list.Should().NotBeNull();
            list.Should().HaveCount(5);
            Assert.Pass();
        }

        [TearDown]
        public void CleanUp()
        {
            client.Dispose();
        }

        class PrimeService
        {
            public bool IsPrime(int candidate)
            {
                if (candidate == 1)
                {
                    return false;
                }
                throw new NotImplementedException("Please create a test first.");
            }
        }
    }
}