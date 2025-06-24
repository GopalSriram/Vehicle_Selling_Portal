using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSellingPortal.Application.Contracts.Persistance;
using VehicleSellingPortal.Domain.Entities;
using VehicleSellingPortal.Infrastructure.Common;

namespace VehicleSellingPortal.Infrastructure.Repositories
{
    public class WatchlistService : IWatchlistService
    {
        private readonly ApplicationDbContext _db;
        private readonly IVehicleRepository _vehicleRepo;

        public WatchlistService(ApplicationDbContext db, IVehicleRepository vehicleRepo)
        {
            _db = db;
            _vehicleRepo = vehicleRepo;
        }

        public async Task<List<Vehicle>> GetWatchlistAsync(string userId)
        {
            var ids = await _db.Watchlist
                .Where(w => w.UserId == userId)
                .Select(w => w.VehicleId)
                .ToListAsync();

            var all = await _vehicleRepo.GetAllAsync();
            return all.Where(v => ids.Contains(v.Id)).ToList();
        }

        public async Task AddToWatchlistAsync(string userId, int vehicleId)
        {
            var exists = await _db.Watchlist.AnyAsync(w => w.UserId == userId && w.VehicleId == vehicleId);
            if (!exists)
            {
                _db.Watchlist.Add(new WatchlistItem { UserId = userId, VehicleId = vehicleId });
                await _db.SaveChangesAsync();
            }
        }

        public async Task RemoveFromWatchlistAsync(string userId, int vehicleId)
        {
            var item = await _db.Watchlist.FirstOrDefaultAsync(w => w.UserId == userId && w.VehicleId == vehicleId);
            if (item != null)
            {
                _db.Watchlist.Remove(item);
                await _db.SaveChangesAsync();
            }
        }
    }
}
