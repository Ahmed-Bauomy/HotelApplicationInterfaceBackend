using HotelAppInterfaceBackend.Services;
using HotelWebApi.Models;
using System.Net.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace HotelAppInterfaceBackend
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<HttpClient>();
            container.RegisterType<IService<Room>, RoomsService>();
            container.RegisterType<IService<Branch>, BranchService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}