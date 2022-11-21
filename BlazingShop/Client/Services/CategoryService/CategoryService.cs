using System;
using System.Net.Http.Json;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadCategories()
        {
            Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/v1/category").ConfigureAwait(false);
        }
    }
}

