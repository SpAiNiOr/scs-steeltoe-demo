#This is demo for how to use the Steeltoe.

Steeltoe is an open source project that enables .NET developers to implement industry standard best practices when building resilient microservices for the cloud. The Steeltoe client libraries enable .NET Core and .NET Framework apps to easily leverage Netflix Eureka, Hystrix, Spring Cloud Config Server, and Cloud Foundry services.

https://steeltoe.io

---

If you plan to develop with .NET Core or ASP.NET Core and do not already know them well, we recommend you first spend time working through some of the following tutorials from Microsoft:

[Getting Started with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/getting-started)

[Getting Started with C#](https://www.microsoft.com/net/tutorials/csharp/getting-started)
Note: Many of the Steeltoe packages can also be used with .NET Framework and ASP.NET 4 based applications. You are not required to target .NET/ASP.NET Core when using Steeltoe.

---

The steeltoe-demo-server is provide API and registered itself in Eurake in PCF.
The steeltoe-demo-client read the API, and display it on webpage.

The steeltoe-demo-server is an .NET Core Web API, steeltoe-demo-client is an ASP .NET CORE MVC.


If there are any merge conflicts, the last provider added to the Configuration takes precedence and overrides all others

---

References:

Documents: https://steeltoe.io/docs/steeltoe-introduction/

Videos: 

[Intro to Pivotal Cloud Foundry & Steeltoe by Zach Brown](https://www.youtube.com/watch?v=GRG0Y7iMEUg)

[Introducing Steeltoe RC1, A Microservices Toolkit for .NET](https://content.pivotal.io/blog/introducing-steeltoe-rc1-a-microservices-toolkit-for-net) 

[Steeltoe and the Open Source .NET Renaissance - Beth Massi, Zach Brown, Dave Tillman](https://www.youtube.com/watch?v=ImOHUa_a6lg)