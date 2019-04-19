using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReservationSite.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public string EmailLink { get; private set; }

        public string Email { get; private set; }

        public void OnGet()
        {
            Message = "Please contact us with any questions.";
            EmailLink = "mailto:VermontCamp@gmail.com?Subject=Vermont%20Camp%20Question";
            Email = "VermontCamp@gmail.com";
        }
    }
}
