using Microsoft.AspNetCore.Mvc.RazorPages;
namespace WeatherSite.Pages;
public class IndexModel : PageModel
{
    public string Location { get; set; }
    public WeatherForecast[] Items { get; set; }
    public string Message { get; set; }
    private readonly ILogger<IndexModel> _logger;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public async Task OnGet()
    {
        try
        {
            var apiUrl = new
           ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["WeatherAPI"];


            Location = Request.Query["location"].FirstOrDefault() ?? "Dallas";
            var client = new HttpClient() { BaseAddress = new Uri(apiUrl) };
            var response = await
           client.GetAsync($"WeatherForecast?location={Location}");
            response.EnsureSuccessStatusCode();
            var items = await
           response.Content.ReadFromJsonAsync<WeatherForecast[]>();
            Items = items;
            Message = $"{Items.Count()} forecast records found ";
        }
        catch (HttpRequestException ex)
        {
            Message = ex.Message;
        }
    }
}