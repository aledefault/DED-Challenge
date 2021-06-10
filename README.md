# DED Challenge
Devices Management System challenge. It's been implemented using Vertical Slice Architecture and CQRS. 

## Requirements
1. Docker
2. Net 5 SDK

## Run
Run docker compose in the root of the project. 
 
```
docker-compose up -d --build --force-recreate --remove-orphans
```
## Urls
* API Swagger: https://localhost:44445/swagger
* Web Blazor: https://localhost:44447

## TODO
* Implement Integration Tests.
* Add SignalR to prevent of using long polling.

## Stack Used 
* Net 5.0
* NServiceBus
* ASP.Net Core 5 Web Api
* ASP.Net Core Blazor Server Side
* MongoDB
* RabbitMQ
* Docker 