using System.Collections.Generic;

namespace WeatherService.OpenWeather.Classes
{
	public class WeatherData {
		public decimal lat { get; set; } 
		public decimal lon { get; set; } 
		public string timezone { get; set; } 
		public int timezone_offset { get; set; } 
		public Current current { get; set; } 
		public List<Minutely> minutely { get; set; } 
		public List<Hourly> hourly { get; set; } 
		public List<Daily> daily { get; set; } 
	}

	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class Weather    {
		public int id { get; set; } 
		public string main { get; set; } 
		public string description { get; set; } 
		public string icon { get; set; } 
 	}

	public class Current    {
		public int dt { get; set; } 
		public int sunrise { get; set; } 
		public int sunset { get; set; } 
		public int temp { get; set; } 
		public decimal feels_like { get; set; } 
		public int pressure { get; set; } 
		public int humidity { get; set; } 
		public decimal dew_point { get; set; } 
		public int uvi { get; set; } 
		public int clouds { get; set; } 
		public int visibility { get; set; } 
		public decimal wind_speed { get; set; } 
		public int wind_deg { get; set; } 
		public List<Weather> weather { get; set; } 
	}

	public class Minutely    {
		public int dt { get; set; } 
		public int precipitation { get; set; } 
	}    

	public class Rain: Dictionary<string, decimal> {}

	public class Hourly    {
		public int dt { get; set; } 
		public decimal temp { get; set; } 
		public decimal feels_like { get; set; } 
		public int pressure { get; set; } 
		public int humidity { get; set; } 
		public decimal dew_point { get; set; } 
		public decimal uvi { get; set; } 
		public int clouds { get; set; } 
		public int visibility { get; set; } 
		public decimal wind_speed { get; set; } 
		public int wind_deg { get; set; } 
		public List<Weather> weather { get; set; } 
		public decimal pop { get; set; } 
		public Rain rain { get; set; } 
	}

	public class Temperature {
		public decimal day { get; set; } 
		public decimal min { get; set; } 
		public decimal max { get; set; } 
		public decimal night { get; set; } 
		public decimal eve { get; set; } 
		public decimal morn { get; set; } 
	}

	public class FeelsLike    {
		public decimal day { get; set; } 
		public decimal night { get; set; } 
		public decimal eve { get; set; } 
		public decimal morn { get; set; } 
	}

 	public class Daily    {
		public int dt { get; set; } 
		public int sunrise { get; set; } 
		public int sunset { get; set; } 
		public Temperature temp { get; set; } 
		public FeelsLike feels_like { get; set; } 
		public int pressure { get; set; } 
		public int humidity { get; set; } 
		public decimal dew_point { get; set; } 
		public decimal wind_speed { get; set; } 
		public int wind_deg { get; set; } 
		public List<Weather> weather { get; set; } 
		public int clouds { get; set; } 
		public decimal pop { get; set; } 
		public decimal uvi { get; set; } 
		public decimal? rain { get; set; } 
		public decimal? snow { get; set; } 
	}    
}