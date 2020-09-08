using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelAppInterfaceBackend.Services
{
    public class BookingService : IService<Booking>
    {
        HttpClient Http;
        public BookingService(HttpClient _http)
        {
            Http = _http;
            Http.BaseAddress = new Uri("https://localhost:44341/");
        }
        public bool AddItem(Booking item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(string id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(string id, Booking item)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAllItems()
        {
            HttpResponseMessage message = Http.GetAsync("api/Booking").Result;
            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsAsync<List<Booking>>().Result;
            }
            return null;
        }

        public Booking GetItem(string id)
        {
            throw new NotImplementedException();
        }
    }
}