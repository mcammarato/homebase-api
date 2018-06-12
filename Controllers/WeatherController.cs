using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_api_test.Controllers
{
    [Route("api/WeatherController")]
    public class WeatherController : Controller
    {                
        public object Get()
        {
            var client = new WebClient();

            string weatherUrl = "http://api.wunderground.com/api/bb2eae0cb8e12806/conditions/q/NJ/Caldwell.json";

            var weatherJson = client.DownloadString(weatherUrl);

            return weatherJson;
        }
    }
}
