using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using scs_demo_client.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Pivotal.Discovery.Client;
using Steeltoe.Common.Discovery;
using Newtonsoft.Json;

namespace scs_demo_client.Controllers
{
    public class HomeController : Controller
    {
        DiscoveryHttpClientHandler _handler;
        IDiscoveryClient _client;

        public HomeController(IDiscoveryClient client)
        {
            _handler = new DiscoveryHttpClientHandler(client);
            _client = client;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CallResult()
        {

            // the following code snippet is for check if we can get the registered information from Register Service.

            //try
            //{
            //    var instances = _client.GetInstances("scs-demo-server");
            //    ViewData["CallResult"] = JsonConvert.SerializeObject(instances);

            //}
            //catch (Exception ex)
            //{
            //    ViewData["CallResult"] = ex.ToString();
            //}

            // try to call selected API, and return result.

            HttpClient client = new HttpClient(_handler, false);
            // client.BaseAddress = new Uri("http://scs-demo-server");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = client.GetAsync("http://scs-demo-server/api/values/5").Result;

                if (response.IsSuccessStatusCode)
                {
                    ViewData["CallResult"] = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    ViewData["CallResult"] = "No resonse";
                }
            }
            catch (Exception ex)
            {
                ViewData["CallResult"] = ex.ToString();
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
