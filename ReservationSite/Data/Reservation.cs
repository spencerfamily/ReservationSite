using System;
using System.ComponentModel.DataAnnotations;

namespace ReservationSite.Data
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required(ErrorMessage ="Enter StartDate")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Enter EndDate")]
        public DateTime EndDate { get; set; }
    }
}