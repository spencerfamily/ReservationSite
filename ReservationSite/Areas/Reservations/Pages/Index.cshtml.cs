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
        private readonly ReservationSite.Data.ReservationsDbContext _context;

        public IndexModel(ReservationSite.Data.ReservationsDbContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservations { get; set; }

        public async Task OnGetAsync()
        {
            Reservations = await _context.Reservations.ToListAsync();
        }
    }
}
