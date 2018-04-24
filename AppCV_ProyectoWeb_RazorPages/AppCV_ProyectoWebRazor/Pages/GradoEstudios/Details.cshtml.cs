using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppCV_ProyectoWebRazor.Models;

namespace AppCV_ProyectoWebRazor.Pages.GradoEstudios
{
    public class DetailsModel : PageModel
    {
        private readonly AppCV_ProyectoWebRazor.Models.ApplicationDbContext _context;

        public DetailsModel(AppCV_ProyectoWebRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public GradoEstudio GradoEstudio { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GradoEstudio = await _context.GradoEstudio.SingleOrDefaultAsync(m => m.IdCarrerarGradoEstudio == id);

            if (GradoEstudio == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
