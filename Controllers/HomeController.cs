using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Restaurants.Controllers;
using Restaurants.Models;

namespace Restaurants.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
