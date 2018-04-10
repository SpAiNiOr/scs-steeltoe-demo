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

namespace scs_demo_client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //public scs_demo_service(IDiscoveryClient, client)
            //{
                
            //}
            //_handler = new DiscoveryHttpClientHandler(IDiscoveryClient client);

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://www.mithril.cc/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.GetAsync("/").Result;




            //if (response.IsSuccessStatusCode)
            //{
            //    ViewData["CallResult"] = response;
            //}
            //else
            //{
            //    ViewData["CallResult"] = "No resonse";
            //}

            return View();
        }

        [HttpPost]
        public string Index2()
        {
            return "test is ok";
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
