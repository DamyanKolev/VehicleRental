using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRental.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

    }
}