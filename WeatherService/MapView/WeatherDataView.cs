using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherService.OpenWeather.MapView
{
    public class WeatherDataView {
		[JsonPropertyName("lat")]
		public decimal Lat { get; set; }

		[JsonPropertyName("lon")]
		public decimal Lon { get; set; }

		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }

		[JsonPropertyName("timezone_offset")]
		public int TimezoneOffset { get; set; }

		[JsonPropertyName("current")]
		public WeatherInfoView Current { get; set; }

		[JsonPropertyName("minutely")]
		public ICollection<MinutelyView> Minutely { get; set; }

		[JsonPropertyName("hourly")]
		public ICollection<WeatherInfoView> Hourly { get; set; }
		
		[JsonPropertyName("daily")]
		public ICollection<DailyView> Daily { get; set; } 
	}

	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class WeatherView
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("main")]
		public string Main { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("icon")]
		public string Icon { get; set; } 
 	}

	public class WeatherInfoView {
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }

		[JsonPropertyName("sunrise")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public DateTime Sunrise { get; set; }

		[JsonPropertyName("sunset")]
		public DateTime Sunset { get; set; }

		[JsonPropertyName("temperature")]
		public decimal Temperature { get; set; }

		[JsonPropertyName("feels_like")]
		public decimal FeelsLike { get; set; }

		[JsonPropertyName("pressure")] 
		public int Pressure { get; set; }

		[JsonPropertyName("humidity")] 
		public int Humidity { get; set; }

		[JsonPropertyName("uv_index")]
		public decimal UvIndex { get; set; }

		[JsonPropertyName("clouds_percents")]
		public int CloudsPercents { get; set; }

		[JsonPropertyName("visibility_meters")]
		public int VisibilityMeters { get; set; }

		[JsonPropertyName("wind_speed_meters")]
		public decimal WindSpeedMeters { get; set; }

		[JsonPropertyName("wind_degrees")]
		public int WindDegrees { get; set; }

		[JsonPropertyName("weather")]
		public ICollection<WeatherView> Weather { get; set; }

		[JsonPropertyName("probability_of_precipitation")]
		public decimal ProbabilityOfPrecipitation { get; set; }

		[JsonPropertyName("rain")]
		public RainView Rain { get; set; }
	}

	public class MinutelyView {
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }

		[JsonPropertyName("precipitation_mm")]
		public int PrecipitationMm { get; set; } 
	}    

	public class RainView: Dictionary<string, decimal> {}

	// public class HourlyView    {
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
	// 	public List<WeatherView> Weather { get; set; }

	// 	[JsonPropertyName("pop")]
	// 	public decimal Pop { get; set; }

	// 	[JsonPropertyName("rain")]
	// 	public RainView Rain { get; set; } 
	// }

	public class TemperatureView {
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

 	public class DailyView    {
		[JsonPropertyName("dt")]
		public int Dt { get; set; }

		[JsonPropertyName("sunrise")]
		public int Sunrise { get; set; }

		[JsonPropertyName("sunset")]
		public int Sunset { get; set; }

		[JsonPropertyName("temp")]
		public TemperatureView Temp { get; set; }

		[JsonPropertyName("feels_like")]
		public TemperatureView FeelsLike { get; set; }

		[JsonPropertyName("pressure")]
		public int Pressure { get; set; }

		[JsonPropertyName("humidity")]
		public int Humidity { get; set; }

		[JsonPropertyName("dew_point")]
		public decimal DewPoint { get; set; }

		[JsonPropertyName("wind_speed")]
		public decimal WindSpeed { get; set; }

		[JsonPropertyName("wind_deg")]
		public int WindDeg { get; set; }

		[JsonPropertyName("weather")]
		public List<WeatherView> Weather { get; set; }

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