using exerciseTracker.Model;
using System.Net.Http.Json;

namespace exerciseTracker.Services;

public class ExerciseService
{
    HttpClient httpClient;

    public ExerciseService() 
    {
        httpClient = new HttpClient();
    }

    List<Exercises> exercisesList = new();    

    public async Task<List<Exercises>> GetExercises()
    {
        if (exercisesList?.Count > 0)
            return exercisesList;

        var url = "https://github.coventry.ac.uk/raw/singhh48/fitnessTrackerData/main/data.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            exercisesList = await response.Content.ReadFromJsonAsync<List<Exercises>>();
        }
        return exercisesList;
    }

}
