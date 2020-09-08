using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelAppInterfaceBackend.Services
{
    public class RoomsService:IService<Room>
    {
        private readonly HttpClient Http;
        public RoomsService(HttpClient _http)
        {
            Http = _http;
            Http.BaseAddress = new Uri("https://localhost:44341/");
        }
        public bool AddItem(Room room)
        {
            HttpResponseMessage message = Http.PostAsJsonAsync("api/Room", room).Result;
            var httpStatusCode = message.StatusCode;
            if (message.IsSuccessStatusCode)
            {
                 
                return true;
            }
            return false;
        }

        public bool DeleteItem(string id)
        {
            HttpResponseMessage message = Http.DeleteAsync("api/Room/" + id).Result;
            if (message.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool EditItem(string id,Room item)
        {
            HttpResponseMessage message = Http.PutAsJsonAsync("api/Room/" + id, item).Result;
            if (message.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public List<Room> GetAllItems()
        {
            HttpResponseMessage message = Http.GetAsync("api/Room").Result;
            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsAsync<List<Room>>().Result;
            }
            return null;
        }

        public Room GetItem(string id)
        {
            HttpResponseMessage message = Http.GetAsync("api/Room" + id).Result;
            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsAsync<Room>().Result;
            }
            return null;
        }
    }
}