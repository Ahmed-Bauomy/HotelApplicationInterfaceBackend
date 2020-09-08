using HotelAppInterfaceBackend.Services;
using HotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HotelAppInterfaceBackend.Controllers
{
    public class BookingCommunicatorController : Controller
    {
        private readonly IService<Booking> BookingService;
        public BookingCommunicatorController(IService<Booking> _service)
        {
            BookingService = _service;
        }
        // GET: BookingCommunicator
        public ActionResult Index()
        {
            var BookingList = BookingService.GetAllItems();
            if (BookingList == null)
            {
                BookingList = new List<Booking>();
            }
            return View(BookingList);
        }
    }
}