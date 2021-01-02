using System;
using System.Collections.Generic;
using System.Linq;
using WeatherService.OpenWeather.Classes;
using WeatherService.OpenWeather.MapView;

namespace WeatherService.MapView
{
    public class ViewMapper
    {
        public WeatherDataView Map(WeatherData data)
		{
			return new WeatherDataView {
				Lat = data.Lat,
				Lon = data.Lon,
				Timezone = data.Timezone,
				TimezoneOffset = data.TimezoneOffset,
				Current = MapWeatherInfo(data.Current),
				Minutely = MapMinutely(data.Minutely),
				Hourly = MapHourly(data.Hourly)
			};
		}

		private ICollection<WeatherInfoView> MapHourly(ICollection<WeatherInfo> hourly)
		{
			return hourly.Select(f => 
				MapWeatherInfo(f)
			).ToArray();
		}

		private ICollection<MinutelyView> MapMinutely(ICollection<Minutely> minutely)
		{
			return minutely.Select(f => 
				new MinutelyView {
					Date = GetTime(f.Dt),
					PrecipitationMm = f.Precipitation
				}
			).ToArray();
		}

		private WeatherInfoView MapWeatherInfo(WeatherInfo current)
		{
			return new WeatherInfoView {
				Date = GetTime(current.Dt),
				Sunrise = GetTime(current.Sunrise),
				Sunset = GetTime(current.Sunset),
				Temperature = current.Temp,
				FeelsLike = current.FeelsLike,
				Pressure = current.Pressure,
				Humidity = current.Humidity,
				UvIndex = current.Uvi,
				CloudsPercents = current.Clouds,
				VisibilityMeters = current.Visibility,
				WindSpeedMeters = current.WindSpeed,
				WindDegrees = current.WindDeg,
				Weather = MapWeather(current.Weather),
				ProbabilityOfPrecipitation = current.Pop,
				Rain = MapRain(current.Rain)
			};
		}

		private RainView MapRain(Rain rain)
		{
			throw new NotImplementedException();
		}

		private ICollection<WeatherView> MapWeather(List<Weather> weather)
		{
			return weather.Select(f => 
				new WeatherView {
					Id = f.Id,
					Description = f.Description,
					Icon = f.Icon,
					Main = f.Main
				}
			).ToArray();
		}

		private DateTime GetTime(long unixTime)
		{
			var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTime);
			return dateTimeOffset.UtcDateTime;
		}
	}
}