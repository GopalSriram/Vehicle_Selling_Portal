using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSellingPortal.Domain.Entities;

namespace VehicleSellingPortal.Application.Contracts.Persistance
{
    public interface IWatchlistService
    {
        Task<List<Vehicle>> GetWatchlistAsync(string userId);
        Task AddToWatchlistAsync(string userId, int vehicleId);
        Task RemoveFromWatchlistAsync(string userId, int vehicleId);
    }
}
