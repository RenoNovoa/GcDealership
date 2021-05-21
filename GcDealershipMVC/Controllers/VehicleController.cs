using GcDealershipMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GcDealershipMVC.Controllers
{
    public class VehicleController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44385/")
            };

            var vehicleViewModel = await client.GetFromJsonAsync<IList<VehicleViewModel>>($"api/vehicle");

            return View(vehicleViewModel);
        }

        public async Task<IActionResult> GetCarByIdAsync(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44385/")
            };

            var vehicleViewModel = await client.GetFromJsonAsync<VehicleViewModel>($"api/vehicle/{id}");

            return View(vehicleViewModel);
        }
    }
}
