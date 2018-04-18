# Steeltoe Sample.

## Introduce.

Steeltoe is an open source project that enables .NET developers to implement industry standard best practices when building resilient microservices for the cloud. The Steeltoe client libraries enable .NET Core and .NET Framework apps to easily leverage Netflix Eureka, Hystrix, Spring Cloud Config Server, and Cloud Foundry services.

https://steeltoe.io

If you plan to develop with .NET Core or ASP.NET Core and do not already know them well, we recommend you first spend time working through some of the following tutorials from Microsoft:

+ [Getting Started with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/getting-started)
+ [Getting Started with C#](https://www.microsoft.com/net/tutorials/csharp/getting-started)

Note: Many of the Steeltoe packages can also be used with .NET Framework and ASP.NET 4 based applications. You are not required to target .NET/ASP.NET Core when using Steeltoe.

---

## About this sample.
The steeltoe-demo-server is provide API and registered itself in SCS in PCF. The steeltoe-demo-client call the API, and display the result on broswer. The server is an .NET Core Web API,  the client is an ASP .NET CORE MVC.

---

## How to use this sample.
We can create Eureka service using Apps Manager or Cli. The following shows how to use the Cli.
Use the Cloud Foundry CLI to create a service instance of the Spring Cloud Eureka Server on Cloud Foundry, as follows:

Create a Eureka Server instance on Cloud Foundry
> cf create-service p-service-registry standard myDiscoveryService

 Wait for the service to be ready
> cf services

Push both server and client to PCF
>cf push serverName/clientName 

Bind the service to both server and client  `serverName/clientName`
> cf bind-service serverName/clientName myDiscoveryService

 Restage the apps to pick up change
> cf restage serverName/clientName

Then open the route of scs-demo-client in browser, then you will get information from scs-demo-server.

---
## Settings.

By changing the appsettings.json, we can control the overall behavior of the client. The `spring:application:name` is the name of the application to be registered with Eureka. We need pay attention to how App register itself to Eurake server.The `registrationMethod` controls ow to register service on Cloud Foundry. Can be `route`, `direct`, or `hostname`.
```json
"cloud" : {
       "discovery" : {
         "registrationMethod" : "route"
              }
     }
```
Whole configuration settings can be found here: https://steeltoe.io/docs/steeltoe-discovery/#1-2-2-eureka-client-settings

---

## References:

Documents:
https://steeltoe.io/docs/steeltoe-introduction/

Videos: 

[Intro to Pivotal Cloud Foundry & Steeltoe by Zach Brown](https://www.youtube.com/watch?v=GRG0Y7iMEUg)

[Introducing Steeltoe RC1, A Microservices Toolkit for .NET](https://content.pivotal.io/blog/introducing-steeltoe-rc1-a-microservices-toolkit-for-net) 

[Steeltoe and the Open Source .NET Renaissance - Beth Massi, Zach Brown, Dave Tillman](https://www.youtube.com/watch?v=ImOHUa_a6lg)