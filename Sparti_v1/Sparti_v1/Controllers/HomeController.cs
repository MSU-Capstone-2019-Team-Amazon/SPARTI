using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Mvc;
using Sparti_v1.Models;

namespace Sparti_v1.Controllers
{
    public class HomeController : Controller
    {
        private IAmazonDynamoDB _clientDb;

        public HomeController(IAmazonDynamoDB amazonDynamoDbClient)
        {
            _clientDb = amazonDynamoDbClient;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
