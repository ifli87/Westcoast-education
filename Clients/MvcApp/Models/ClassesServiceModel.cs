using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class ClassesServiceModel
    {
    private readonly string _baseUrl;
    private readonly JsonSerializerOptions _options;
    private readonly IConfiguration _config;

      public ClassesServiceModel(IConfiguration config)
    {
      _config = config;
      _baseUrl = $"{_config.GetValue<string>("baseUrl")}/classes";

      _options = new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      };
    }

    public async Task<List<ClassesViewModel>> ListAllClasses()
    {
      var url = $"{_baseUrl}/list";

      using var http = new HttpClient();
      var response = await http.GetAsync(url);

      if (!response.IsSuccessStatusCode)
      {
        throw new Exception("Det gick inget vidare");
      }

      var classes = await response.Content.ReadFromJsonAsync<List<ClassesViewModel>>();
     

      return classes ?? new List<ClassesViewModel>();
    }

    public async Task<ClassesViewModel> FindClasses(int id)
    {
      var baseUrl = _config.GetValue<string>("baseUrl");
      var url = $"{baseUrl}/classes/{id}";

      using var http = new HttpClient();
      var response = await http.GetAsync(url);

      if (!response.IsSuccessStatusCode)
      {
        Console.WriteLine("Det gick inte att hitta bilen");
      }

      var vehicle = await response.Content.ReadFromJsonAsync<ClassesViewModel>();

      return vehicle ?? new ClassesViewModel();
    }

    public async Task<bool> CreateVehicle(CreateClassViewModel classes)
    {
      using var http = new HttpClient();
      var baseUrl = _config.GetValue<string>("baseUrl");
      var url = $"{baseUrl}/classes";

      var response = await http.PostAsJsonAsync(url, classes);

      if (!response.IsSuccessStatusCode)
      {
        string reason = await response.Content.ReadAsStringAsync();
        Console.WriteLine(reason);
        return false;
      }

      return true;
    }
}
}