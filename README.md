# weather-service
Weather microservice

Run service
http://localhost:1984/Weather

Create image
docker build -t weather-service:latest .

Run image
docker run -p 1984:1984 --name weather weather-service

Run image:
docker run --network host -d weather-service

Stop container
docker

Remove image
docker rm weather

