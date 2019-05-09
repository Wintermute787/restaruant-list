using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Restaurants.Models
{
  public class Restaurant
  {
    private string _name;
    private int _id;
    private int _cuisineId;

    public Restaurant(string name, int cuisineId, int id = 0)
    {
      _name = name;
      _id = id;
      _cuisineId = cuisineId;
    }

    public int GetCuisineId()
    {
      return _cuisineId;
    }
    public int GetId()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public static List<Restaurant> GetAll()
    {
      List<Restaurant> allItems = new List<Restaurant>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM best_restaurant;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string restaurantName = rdr.GetString(1);
        int restCuisineId = rdr.GetInt32(2);
        Restaurant newRestaurant = new Restaurant(restaurantName, restCuisineId, itemId);
        allItems.Add(newRestaurant);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    public static Restaurant Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `best_restaurant` WHERE id = @thisId;";
      MySqlParameter thisId = new MySqlParameter();
      thisId.ParameterName = "@thisId";
      thisId.Value = id;
      cmd.Parameters.Add(thisId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int itemId = 0;
      string restName = "";
      rdr.Read();
      itemId = rdr.GetInt32(0);
      restName = rdr.GetString(1);
      int cusId = rdr.GetInt32(2);
      Restaurant foundItem = new Restaurant(restName,itemId, cusId);

      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return foundItem;
    }

    public override bool Equals(System.Object otherRestaurant)
    {
      if(!(otherRestaurant is Restaurant))
      {
        return false;
      }
      else
      {
        Restaurant newRestaurant = (Restaurant) otherRestaurant;
        bool idEqality = (this.GetId() == newRestaurant.GetId());
        bool nameEquality = (this.GetName() == newRestaurant.GetName());
        bool cuisineEquality = (this.GetCuisineId() == newRestaurant.GetCuisineId());
        return (idEqality && nameEquality && cuisineEquality);
      }
    }

    public void Edit(string newRestaurant)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE best_restaurant SET name = @newRestaurant WHERE id = @searchId;";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = _id;
      cmd.Parameters.Add(searchId);
      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@newRestaurant";
      name.Value = newRestaurant;
      cmd.Parameters.Add(name);
      cmd.ExecuteNonQuery();
      _name = newRestaurant;
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
    }

    public void Delete()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM best_restaurant WHERE id = @thisId;";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@thisId";
      searchId.Value = _id;
      cmd.Parameters.Add(searchId);
      cmd.ExecuteNonQuery();
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO best_restaurant (name, cuisine_id) VALUES (@restName, @cusId);";
      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@restName";
      name.Value = this._name;
      MySqlParameter cuisine_id = new MySqlParameter();
      cuisine_id.ParameterName = "@cusId";
      cuisine_id.Value = this._cuisineId;
      cmd.Parameters.Add(cuisine_id);
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
