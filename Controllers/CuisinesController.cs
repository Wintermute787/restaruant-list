using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;

namespace Restaurants.Controllers
{
  public class CuisinesController : Controller
  {
    [HttpGet("/cuisines")]
    public ActionResult Index()
    {
      List<Cuisine> allCuisines = Cuisine.GetAll();
      return View(allCuisines);
    }

    [HttpGet("/cuisines/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cuisines")]
    public ActionResult Create(string cuisineName)
    {
      Cuisine newCuisine = new Cuisine(cuisineName);
      newCuisine.Save();
      List<Cuisine> allCuisines = Cuisine.GetAll();
      return View("Index", allCuisines);
    }

    [HttpGet("/cuisines/{id}")]
    public ActionResult Show (int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Cuisine selectedCuisine = Cuisine.Find(id);
      List<Restaurant> cuisineRest = selectedCuisine.GetItems();
      model.Add("cuisine", selectedCuisine);
      model.Add("best_restaurant", cuisineRest);
      return View(model);
    }

    [HttpPost("/cuisines/{cuisineId}/restaurants")]
    public ActionResult Create(string restName, int cuisineId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Cuisine foundCuisine = Cuisine.Find(cuisineId);
      Restaurant newRest = new Restaurant(restName, cuisineId);
      newRest.Save();
      foundCuisine.AddRestaurant(newRest);
      List<Restaurant> restNames = foundCuisine.GetItems();
      model.Add("best_restaurant", restNames);
      model.Add("cuisine", foundCuisine);
      return View("Show", model);
    }
  }
}
