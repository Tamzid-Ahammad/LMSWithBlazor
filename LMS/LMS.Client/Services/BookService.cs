using LMS.Client.Pages;
using LMS.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS.Client.Services
{
    public class BookService
    {
        private readonly HttpClient http;

        private string apiLink = "/api/Students";

        public BookService(HttpClient http, NavigationManager nav)
        {
            http.BaseAddress = new Uri(nav.BaseUri);
            this.http = http;
        }

        public async Task<IList<Student>?> GetAll()
        {
            var data = await this.http.GetFromJsonAsync<IList<Student>>(apiLink);
            return data;
        }
        public async Task<Student?> GetById(int id)
        {
            return await this.http.GetFromJsonAsync<Student>(apiLink + $"/{id}");
        }
        public async Task<HttpResponseMessage?> Save(Student data)
        {
            return await this.http.PostAsJsonAsync<Student>(apiLink, data);
        }
        public async Task<HttpResponseMessage?> Update(Student data)
        {
            return await this.http.PutAsJsonAsync<Student>(apiLink + $"/{data.StudentId}", data);
        }

        public async Task<HttpResponseMessage?> Delete(int id)
        {
            return await this.http.DeleteAsync(apiLink + $"/{id}");
        }
    }
}