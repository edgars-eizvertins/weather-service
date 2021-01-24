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
				Hourly = MapHourly(data.Hourly),
				Daily = MapDaily(data.Daily),
				Alerts = MapAlerts(data.Alerts)
			};
		}

		private ICollection<AlertView> MapAlerts(ICollection<Alert> alerts)
		{
			return alerts.Select(f => MapAlert(f)).ToArray();
		}

		private AlertView MapAlert(Alert alert)
		{
			if (alert == null)
				return null;

			return new AlertView {
				SenderName = alert.SenderName,
				Event = alert.Event,
				Start = GetTime(alert.Start),
				End = GetTime(alert.End),
				Description = alert.Description
			};
		}

		private ICollection<DailyView> MapDaily(ICollection<Daily> daily)
		{
			return daily.Select(f => MapDaily(f)).ToArray();
		}

		private DailyView MapDaily(Daily daily)
		{
			return new DailyView {
				Date = GetTime(daily.Dt),
				Sunrise = GetTime(daily.Sunrise),
				Sunset = GetTime(daily.Sunset),
				Temperature = MapTemperature(daily.Temp),
				FeelsLike = MapTemperature(daily.FeelsLike),
				Pressure = daily.Pressure,
				Humidity = daily.Humidity,
				DewPoint = daily.DewPoint,
				WindSpeedMeters = daily.WindSpeed,
				WindGust = daily.WindGust,
				WindDegrees = daily.WindDeg,
				CloudsPercents = daily.Clouds,
				Uvi = daily.Uvi,
				ProbabilityOfPrecipitation = daily.Pop,
				RainVolume = daily.Rain,
				SnowVolume = daily.Snow,
				Weather = MapWeather(daily.Weather)
			};
		}

		private TemperatureView MapTemperature(Temperature temperature)
		{
			return new TemperatureView {
				Morning = Round(temperature.Morn),
				Day = Round(temperature.Day),
				Evening = Round(temperature.Eve),
				Night = Round(temperature.Night),
				Min = Round(temperature.Min),
				Max = Round(temperature.Max)
			};
		}

		private decimal Round(decimal number)
		{
			return Math.Round(number, 0);
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
				Temperature = Round(current.Temp),
				FeelsLike = Round(current.FeelsLike),
				Pressure = current.Pressure,
				Humidity = current.Humidity,
				UvIndex = current.Uvi,
				CloudsPercents = current.Clouds,
				VisibilityMeters = current.Visibility,
				WindSpeedMeters = current.WindSpeed,
				WindDegrees = current.WindDeg,
				Weather = MapWeather(current.Weather),
				ProbabilityOfPrecipitation = current.Pop,
				Rain = MapPrecipitation<RainView>(current.Rain),
				Snow = MapPrecipitation<SnowView>(current.Snow)
			};
		}

		private T MapPrecipitation<T>(Dictionary<string, decimal> percipations) where T: Dictionary<string, decimal>, new()
		{
			var result = new T();
			if (percipations == null)
				return null;

			foreach (var element in percipations) {
				result[element.Key] = element.Value;
			}
			return result;
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