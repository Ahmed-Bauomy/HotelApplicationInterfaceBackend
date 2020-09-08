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
    public class RoomsCommunicatorController : Controller
    {
        private readonly IService<Room> RoomService;
        private readonly IService<Branch> BranchService;
        public RoomsCommunicatorController(IService<Room> _service , IService<Branch> _BService)
        {
            RoomService = _service;
            BranchService = _BService;
        }
        // GET: RoomsCommunicator
        public ActionResult Index()
        {
            var roomList = RoomService.GetAllItems();
            if(roomList == null)
            {
                roomList = new List<Room>();
            }
            return View(roomList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.list = new SelectList(BranchService.GetAllItems(), "BranchId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            if (!ModelState.IsValid)
            {
                return View(room);
            }
            bool Succeded = RoomService.AddItem(room);
            if (Succeded)
            {
                return RedirectToAction("Index");
            }
            ViewBag.list = new SelectList(BranchService.GetAllItems(), "BranchId", "Name");
            return View();
        }
    }
}