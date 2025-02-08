# Nakka Client

Nakka client is a simple .NET library that provides communication with [Nakka](https://nakka.com/n01/menu/) API.

With this client you can get information about leagues, tournaments and matches from Nakka.

Library also provides some useful features, like build complete RoundRobinGroup with player ranks or calculate player double attempts in match.

## Inject

Add nuget package `Mcgiany.NakkaClient` to your .NET project.

Inject NakkaClient via dependency injection.
```cs
services.AddNakkaClient();
```

Then use `INakkaClient` interface in your code.