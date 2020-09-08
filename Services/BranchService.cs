using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelAppInterfaceBackend.Services
{
    public class BranchService : IService<Branch>
    {
        HttpClient Http;
        public BranchService(HttpClient _http)
        {
            Http = _http;
            Http.BaseAddress = new Uri("https://localhost:44341/");
        }
        public bool AddItem(Branch item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(string id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(string id, Branch item)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAllItems()
        {
            HttpResponseMessage message = Http.GetAsync("api/Branch").Result;
            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsAsync<List<Branch>>().Result;
            }
            return new List<Branch>();
        }

        public Branch GetItem(string id)
        {
            throw new NotImplementedException();
        }
    }
}