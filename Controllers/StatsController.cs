using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_api_test.Controllers
{
    [Route("api/StatsController")]
    public class StatsController : Controller
    {                
        public object Get()
        {
            var client = new WebClient();

            string statsUrl = "http://stats.nba.com/js/data/widgets/home_daily.json";

            var statsJson = client.DownloadString(statsUrl);

            return statsJson;
        }
    }
}