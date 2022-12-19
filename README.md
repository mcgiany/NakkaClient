# Nakka Client

Nakka client is a simple .NET library that provides communication with [Nakka](https://nakka.com/n01/menu/) API.

With this client you can get information about leagues, tournaments and matches from Nakka.

## Usage

Add nuget package `Mcgiany.NakkaClient` to your .NET project.

```cs
using var client = new ApiClient("https://tk2-228-23746.vs.sakura.ne.jp/n01");
var league = await client.GetLeagueAsync("league_id");
```
