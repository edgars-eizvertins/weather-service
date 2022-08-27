# weather-service
Weather microservice

Run service
http://localhost:1984/Weather

Create image
docker build -t weather-service:latest .

Run image
docker run -p 1984:1984 weather-service open_weather_key_is_here

Run image:
docker run --network host -d weather-service open_weather_key_is_here

Stop container
docker stop

Remove image
docker rm weather-service