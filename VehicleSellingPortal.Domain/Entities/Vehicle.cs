using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSellingPortal.Domain.Common;
using VehicleSellingPortal.Domain.Enum;

namespace VehicleSellingPortal.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        [Required(ErrorMessage = "Vehicle name is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Make is required")]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1900, 2100, ErrorMessage = "Enter a valid year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Damage status is required")]
        public DamageStatus DamageStatus { get; set; }

        [Required(ErrorMessage = "Mileage is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Mileage must be 0 or more")]
        public int Mileage { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required(ErrorMessage = "Available date is required")]
        public DateTime AvailableDate { get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string ImageUrl { get; set; }

        public bool IsRepossessed { get; set; }
    }
}
