using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace web_api_test.Controllers
{
    [Route("api/StatsController")]
    public class StatsController : Controller
    {                
        public object Get()
        {
            var client = new WebClient();            

            var date = DateTime.Now.ToString("yyyyMMdd"); 

            //string statsUrl = string.Format("http://data.nba.net/10s/prod/v1/{0}/scoreboard.json", date);                                   
            string statsUrl = string.Format("http://data.nba.net/10s/prod/v1/20190301/scoreboard.json", date);                                   

            var statsJson = client.DownloadString(statsUrl);

            return statsJson;
        }
    }
}