using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppCV_ProyectoWebRazor.Models;

namespace AppCV_ProyectoWebRazor.Pages.GradoEstudios
{
    public class EditModel : PageModel
    {
        private readonly AppCV_ProyectoWebRazor.Models.ApplicationDbContext _context;

        public EditModel(AppCV_ProyectoWebRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GradoEstudio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradoEstudioExists(GradoEstudio.IdCarrerarGradoEstudio))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GradoEstudioExists(int id)
        {
            return _context.GradosEstudios.Any(e => e.IdCarrerarGradoEstudio == id);
        }
    }
}
