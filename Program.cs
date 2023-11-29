using System.Net.Http.Headers;
using Newtonsoft.Json;
using Questao2;

public class Program
{
    static async Task Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team "+ teamName +" scored "+ totalGoals.ToString() + " goals in "+ year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    public static int getTotalScoredGoals(string team, int year)
    {
       
        return 0;
    }

    public static async Task GetAsync(int year, string team)
    {
        HttpClient client = new HttpClient();

        string url = String.Format(
            "https://jsonmock.hackerrank.com/api/football_matches?year={0}&team1={1}",
                year, team);
        using HttpResponseMessage response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();

    }
}