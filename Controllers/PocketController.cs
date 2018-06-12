using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using web_api_test.Models;

namespace web_api_test.Controllers
{
    [Route("api/PocketController")]
    public class PocketController : Controller
    {                
        public object Get()
        {
            string consumer_key = "54288-1cbff625e4ad6f2ff32f144d";
            string access_token = "9636d93f-f2f2-dfdd-2238-8ab3ae";

            var client = new WebClient();

            JsonSerializer serializer  = new JsonSerializer();

            var postData = JsonConvert.SerializeObject(new { consumer_key = consumer_key, access_token = access_token  });

            client.Headers.Add(System.Net.HttpRequestHeader.ContentType, "application/json");

            var json = client.UploadString("https://getpocket.com/v3/get", postData);

            BaseObject pocketJSON = JsonConvert.DeserializeObject<BaseObject>(json);

            return pocketJSON;
        }
    }
}