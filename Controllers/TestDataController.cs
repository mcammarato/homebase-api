using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace web_api_test.Controllers
{
    [Route("api/TestDataController")]
    public class TestDataController : Controller
    {                
        public object Get()
        {
            var json = System.IO.File.Open("test_data/nba-stats.json", FileMode.Open);

            return json;
        }
    }
}