using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesSw.API.Data.Entities;

namespace VehiclesSw.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await CheckVehiclesTypesAsync();
        }
    
        private async Task CheckVehiclesTypesAsync()
        {
            if (!_context.vehicleTypes.Any())
            {
                _context.vehicleTypes.Add(new VehicleType { Description = "Carro" });
                _context.vehicleTypes.Add(new VehicleType { Description="Moto"});
            }
        }
    }

    }

