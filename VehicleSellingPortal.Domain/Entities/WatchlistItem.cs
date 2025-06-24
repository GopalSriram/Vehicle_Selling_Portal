using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSellingPortal.Domain.Common;

namespace VehicleSellingPortal.Domain.Entities
{
    public class WatchlistItem : BaseEntity
    {
        public string UserId { get; set; } = string.Empty;
        public int VehicleId { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;
    }
}
