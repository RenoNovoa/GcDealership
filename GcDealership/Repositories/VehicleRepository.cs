using GcDealership.Context;
using GcDealership.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GcDealership.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> vehicleList = new List<Vehicle>
        {
            new Vehicle { Id = 1, Make = "Tesla", Model = "Cyber Truck", Year = 2022, Color = "Silver"},
            new Vehicle { Id = 2, Make = "Honda", Model = "Civic", Year = 2010, Color = "Black"},
            new Vehicle { Id = 3, Make = "Ford", Model = "Fusion", Year = 2019, Color = "Red" },
        };

        private readonly GCDelershipDbContext _context;

        // Dependecy Inject DbContext
        public VehicleRepository(GCDelershipDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Vehicle>> GetVehiclesAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Vehicle> GetVehiclesByIdAsync(int id)
        {
            return await _context.Cars.FirstOrDefaultAsync(_ => _.Id == id);
        }
    }
}
