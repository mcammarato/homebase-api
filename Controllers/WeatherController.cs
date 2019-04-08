using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using web_api_test.Models;

namespace web_api_test.Controllers
{
    [Route("api/WeatherController")]
    public class WeatherController : Controller
    {                
        public object Get()
        {
            var client = new WebClient();

            string weatherUrl = "https://api.darksky.net/forecast/45a89ed8f8357c162a4fd38c0cabdac5/40.840933,-74.301815";

            var weatherJson = client.DownloadString(weatherUrl);

            return weatherJson;
        }        
    }
}
