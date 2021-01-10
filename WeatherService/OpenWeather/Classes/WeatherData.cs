using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherService.OpenWeather.Classes
{
	public class WeatherData {
		[JsonPropertyName("lat")]
		public decimal Lat { get; set; }

		[JsonPropertyName("lon")]
		public decimal Lon { get; set; }

		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }

		[JsonPropertyName("timezone_offset")]
		public int TimezoneOffset { get; set; }

		[JsonPropertyName("current")]
		public WeatherInfo Current { get; set; }

		[JsonPropertyName("minutely")]
		public List<Minutely> Minutely { get; set; }

		[JsonPropertyName("hourly")]
		public List<WeatherInfo> Hourly { get; set; }
		
		[JsonPropertyName("daily")]
		public List<Daily> Daily { get; set; }

		[JsonPropertyName("alerts")]
		public ICollection<Alert> Alerts { get; set; }
	}

	public class Alert
	{
		[JsonPropertyName("sender_name")]
		public string SenderName { get; set; }

		[JsonPropertyName("event")]
		public string Event { get; set; }

		[JsonPropertyName("start")]
		public int Start { get; set; }

		[JsonPropertyName("end")]
		public int End {get; set; }

		[JsonPropertyName("description")]
		public string Description {get; set; }
	}

	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class Weather    {
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("main")]
		public string Main { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("icon")]
		public string Icon { get; set; } 
 	}

	public class WeatherInfo {
		[JsonPropertyName("dt")]
		public int Dt { get; set; }

		[JsonPropertyName("sunrise")]
		public int Sunrise { get; set; }

		[JsonPropertyName("sunset")]
		public int Sunset { get; set; }

		[JsonPropertyName("Temp")]
		public decimal Temp { get; set; }

		[JsonPropertyName("feels_like")]
		public decimal FeelsLike { get; set; }

		[JsonPropertyName("pressure")] 
		public int Pressure { get; set; }

		[JsonPropertyName("humidity")] 
		public int Humidity { get; set; }

		[JsonPropertyName("dew_point")]
		public decimal DewPoint { get; set; }

		[JsonPropertyName("uvi")]
		public decimal Uvi { get; set; }

		[JsonPropertyName("clouds")]
		public int Clouds { get; set; }

		[JsonPropertyName("visibility")]
		public int Visibility { get; set; }

		[JsonPropertyName("wind_speed")]
		public decimal WindSpeed { get; set; }

		[JsonPropertyName("wind_deg")]
		public int WindDeg { get; set; }

		[JsonPropertyName("weather")]
		public List<Weather> Weather { get; set; }

		[JsonPropertyName("pop")]
		public decimal Pop { get; set; }

		[JsonPropertyName("rain")]
		public Rain Rain { get; set; } 

		[JsonPropertyName("snow")]
		public Snow Snow { get; set; } 
	}

	public class Minutely    {
		[JsonPropertyName("dt")]
		public int Dt { get; set; }

		[JsonPropertyName("precipitation")]
		public int Precipitation { get; set; } 
	}    

	public class Rain: Dictionary<string, decimal> {}

	public class Snow: Dictionary<string, decimal> {}

	// public class Hourly    {
	// 	[JsonPropertyName("dt")]
	// 	public int Dt { get; set; }

	// 	[JsonPropertyName("temp")]
	// 	public decimal Temp { get; set; }

	// 	[JsonPropertyName("feels_like")]
	// 	public decimal FeelsLike { get; set; }

	// 	[JsonPropertyName("pressure")]
	// 	public int Pressure { get; set; }

	// 	[JsonPropertyName("humidity")]
	// 	public int Humidity { get; set; }

	// 	[JsonPropertyName("dew_point")]
	// 	public decimal DewPoint { get; set; }

	// 	[JsonPropertyName("uvi")]
	// 	public decimal Uvi { get; set; }

	// 	[JsonPropertyName("clouds")]
	// 	public int Clouds { get; set; }

	// 	[JsonPropertyName("visibility")]
	// 	public int Visibility { get; set; }

	// 	[JsonPropertyName("wind_speed")]
	// 	public decimal WindSpeed { get; set; }

	// 	[JsonPropertyName("wind_deg")]
	// 	public int WindDeg { get; set; }

	// 	[JsonPropertyName("weather")]
	// 	public List<Weather> Weather { get; set; }

	// 	[JsonPropertyName("pop")]
	// 	public decimal Pop { get; set; }

	// 	[JsonPropertyName("rain")]
	// 	public Rain Rain { get; set; } 
	// }

	public class Temperature {
		[JsonPropertyName("day")]
		public decimal Day { get; set; }

		[JsonPropertyName("min")]
		public decimal Min { get; set; }

		[JsonPropertyName("max")]
		public decimal Max { get; set; }

		[JsonPropertyName("night")]
		public decimal Night { get; set; }

		[JsonPropertyName("eve")]
		public decimal Eve { get; set; }

		[JsonPropertyName("morn")] 
		public decimal Morn { get; set; } 
	}

	// public class FeelsLike    {
	// 	public decimal day { get; set; } 
	// 	public decimal night { get; set; } 
	// 	public decimal eve { get; set; } 
	// 	public decimal morn { get; set; } 
	// }

 	public class Daily    {
		[JsonPropertyName("dt")]
		public int Dt { get; set; }

		[JsonPropertyName("sunrise")]
		public int Sunrise { get; set; }

		[JsonPropertyName("sunset")]
		public int Sunset { get; set; }

		[JsonPropertyName("temp")]
		public Temperature Temp { get; set; }

		[JsonPropertyName("feels_like")]
		public Temperature FeelsLike { get; set; }

		[JsonPropertyName("pressure")]
		public int Pressure { get; set; }

		[JsonPropertyName("humidity")]
		public int Humidity { get; set; }

		[JsonPropertyName("dew_point")]
		public decimal DewPoint { get; set; }

		[JsonPropertyName("wind_speed")]
		public decimal WindSpeed { get; set; }

		[JsonPropertyName("wind_gust")]
		public decimal WindGust { get; set; }

		[JsonPropertyName("wind_deg")]
		public int WindDeg { get; set; }

		[JsonPropertyName("weather")]
		public List<Weather> Weather { get; set; }

		[JsonPropertyName("clouds")]
		public int Clouds { get; set; } 
		
		[JsonPropertyName("pop")]
		public decimal Pop { get; set; }

		[JsonPropertyName("uvi")] 
		public decimal Uvi { get; set; } 
		
		[JsonPropertyName("rain")]
		public decimal? Rain { get; set; }

		[JsonPropertyName("snow")] 
		public decimal? Snow { get; set; } 
	}    
}