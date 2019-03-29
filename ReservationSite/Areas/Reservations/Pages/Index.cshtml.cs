using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReservationSite.Data;

namespace ReservationSite.Areas.Reservations.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Services.IReservationDataService dataService;

        public IndexModel(Services.IReservationDataService dataService)
        {
            this.dataService = dataService;
        }

        public List<Reservation> Reservations { get; set; }

        public void OnGet()
        {
            var data = (from Reservations in dataService.GetReservationAll() select Reservations);
            this.Reservations = data.ToList<Reservation>();
        }

        public void OnPost()
        {

        }
    }
}