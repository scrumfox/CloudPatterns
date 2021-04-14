using CQRS.Domain.Commands;
using CQRS.Domain.Commands.Command;
using CQRS.Domain.Queries;
using CQRS.Domain.Queries.Query;
using CQRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var query = new AllWidgetsQuery();
            //var query = new OneWidgetQuery(1);
            //var handler = WidgetQueryHandlerFactory.Build(query);
            //handler.Get();

            var command = new SaveWidgetCommand(new Domain.Widget() { ID = 101, Name = "New", Shape = "New Shape"});
            var handler = WidgetCommandHandlerFactory.Build(command);
            var response = handler.Execute();

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
