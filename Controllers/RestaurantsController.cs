using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;
using System.Collections.Generic;
using System;

namespace Restaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    [HttpGet("/cuisines/{cuisineId}/restaurants/new")]
    public ActionResult New(int cuisineId)
    {
      Cuisine cuisine = Cuisine.Find(cuisineId);
      return View(cuisine);
    }

    [HttpGet("/cuisines/{cuisineId}/restaurants/{restaurantId}")]
    public ActionResult Show(int cuisineId, int restId)
    {
      Restaurant restaurant = Restaurant.Find(restId);
      Dictionary<string,object> model = new Dictionary<string, object>();
      Cuisine cuisine = Cuisine.Find(cuisineId);
      model.Add("best_restaurant", restaurant);
      model.Add("cuisine", cuisine);
      return View(model);
    }

    [HttpPost("/cuisines/{cuisineId}/restaurant/{restaurantId}/Delete")]
    public ActionResult DeleteItem(int cuisineId, int restId)
    {
      Restaurant restaurant = Restaurant.Find(restId);
      restaurant.Delete();
      Dictionary<string, object> model = new Dictionary<string, object>();
      Cuisine foundCuisine = Cuisine.Find(cuisineId);
      List<Restaurant> restItems = foundCuisine.GetItems();
      model.Add("best_restaurant", restItems);
      model.Add("cuisine", foundCuisine);
      return View(model);
    }

    [HttpGet("/cuisines/{cuisineId}/restaurants/{restaurantId}/edit")]
    public ActionResult Edit(int cuisineId, int restId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Cuisine cuisine = Cuisine.Find(cuisineId);
      model.Add("cuisine", cuisine);
      Restaurant restaurant = Restaurant.Find(restId);
      model.Add("best_restaurant", restaurant);
      return View(model);
    }

    [HttpPost("/cuisines/{cuisineId}/restaurants/{restaurantId}")]
    public ActionResult Update(int cuisineId, int restId, string newName)
    {
      Restaurant restaurant = Restaurant.Find(restId);
      restaurant.Edit(newName);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Cuisine cuisine = Cuisine.Find(cuisineId);
      model.Add("cuisine", cuisine);
      model.Add("best_restaurant", restaurant);
      return View("Show", model);
    }
  }
}
