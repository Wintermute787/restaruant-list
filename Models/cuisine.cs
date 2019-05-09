using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace Restaurants.Models
{
  public class Cuisine
  {
    private static List<Cuisine> _instances = new List<Cuisine>{};
    private string _cuisineName;
    private int _id;
    private List<Restaurant> _name;

    public Cuisine(string cuisineName , int id =0)
    {
      _cuisineName = cuisineName;
      _id = id;
      _name = new List<Restaurant>{};
    }

    public override int GetHashCode()
    {
      return this.GetId().GetHashCode();
    }

    public string GetCuisineName()
    {
      return _cuisineName;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Cuisine> GetAll()
    {
      List<Cuisine> allCuisines = new List<Cuisine> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM cuisine;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int cuisineId = rdr.GetInt32(0);
        string cuisineName = rdr.GetString(1);
        Cuisine newCuisine = new Cuisine(cuisineName,cuisineId);
        allCuisines.Add(newCuisine);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allCuisines;
    }

    public static Cuisine Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM cuisine WHERE id = (@searchId);";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = id;
      cmd.Parameters.Add(searchId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int cuisineId = 0;
      string cuisineName = "";
      while(rdr.Read())
      {
        cuisineId = rdr.GetInt32(0);
        cuisineName = rdr.GetString(1);
      }
      Cuisine newCuisine = new Cuisine(cuisineName, cuisineId);
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return newCuisine;
    }

    public List<Restaurant> GetItems()
    {
      List<Restaurant> allCuisinesRestaurants = new List<Restaurant>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM best_restaurant WHERE cuisine_id = @cuisine_id;";
      MySqlParameter cuisineId = new MySqlParameter();
      cuisineId.ParameterName = "@cuisine_id";
      cuisineId.Value = this._id;
      cmd.Parameters.Add(cuisineId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int restaurantId = rdr.GetInt32(0);
        string restaurantName = rdr.GetString(1);
        int restCuisineId = rdr.GetInt32(2);
        Restaurant newRestaurant = new Restaurant(restaurantName, restCuisineId,  restaurantId);
        allCuisinesRestaurants.Add(newRestaurant);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allCuisinesRestaurants;
    }


    public void AddRestaurant(Restaurant restaurant)
    {
      _name.Add(restaurant);
    }


    public override bool Equals(System.Object otherCuisine)
    {
      if(!(otherCuisine is Cuisine))
      {
        return false;
      }
      else
      {
        Cuisine newCuisine = (Cuisine) otherCuisine;
        bool idEquality = this.GetId().Equals(newCuisine.GetId());
        bool nameEquality = this.GetCuisineName().Equals(newCuisine.GetCuisineName());
        return (idEquality && nameEquality);
      }
    }


    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO cuisine (name) VALUES (@name);";
      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@name";
      name.Value = this._cuisineName;
      cmd.Parameters.Add(name);
      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
    }


  }
}
