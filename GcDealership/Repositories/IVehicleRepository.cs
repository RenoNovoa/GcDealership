using GcDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GcDealership.Repositories
{
    public interface IVehicleRepository
    {
        // Calls to the DATABASE
        Task<IList<Vehicle>> GetVehiclesAsync();
        Task<Vehicle> GetVehiclesByIdAsync(int id);
    }
}
