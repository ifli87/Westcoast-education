using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MvcApp.ViewModels;

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
            _baseUrl = $"{_config.GetValue<string>("baseUrl")}/category";
            _options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
        }

       

         public async Task <List<CategoryWithClassViewModel>> ListAllClassesWithCategory()
        {
            var url = $"{_baseUrl}";
            using var http = new HttpClient();
            var response = await http.GetAsync(url);
             if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Detta fungerar inte ") ; 
            }
            var result = await response.Content.ReadAsStringAsync();
            var classesWithCategory = JsonSerializer.Deserialize<List<CategoryWithClassViewModel>>(result, _options);

            return classesWithCategory ?? new List<CategoryWithClassViewModel>();
        }
             public async Task <List<ClassesViewModel>> ListAllClasses()
        {
            var url = $"{_baseUrl}";
            using var http = new HttpClient();
            var response = await http.GetAsync(url);
             if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Detta fungerar inte ") ; 
            }
            var result = await response.Content.ReadAsStringAsync();
            var classes = JsonSerializer.Deserialize<List<ClassesViewModel>>(result, _options);

            return classes ?? new List<ClassesViewModel>();
        }
    }
}