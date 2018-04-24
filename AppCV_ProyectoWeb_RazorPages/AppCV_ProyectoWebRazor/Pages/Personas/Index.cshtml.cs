using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppCV_ProyectoWebRazor.Models;

namespace AppCV_ProyectoWebRazor.Pages.Personas
{
    public class IndexModel : PageModel
    {
        private readonly AppCV_ProyectoWebRazor.Models.ApplicationDbContext _context;

        public IndexModel(AppCV_ProyectoWebRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Persona> Persona { get;set; }

        public async Task OnGetAsync()
        {
            Persona = await _context.Persona.ToListAsync();
        }
    }
}
