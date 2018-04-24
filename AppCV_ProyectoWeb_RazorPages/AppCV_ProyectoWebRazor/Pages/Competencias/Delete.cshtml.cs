using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppCV_ProyectoWebRazor.Models;

namespace AppCV_ProyectoWebRazor.Pages.Competencias
{
    public class DeleteModel : PageModel
    {
        private readonly AppCV_ProyectoWebRazor.Models.ApplicationDbContext _context;

        public DeleteModel(AppCV_ProyectoWebRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Competencia Competencia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Competencia = await _context.Competencias.SingleOrDefaultAsync(m => m.IdCompetenciaDet == id);

            if (Competencia == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Competencia = await _context.Competencias.FindAsync(id);

            if (Competencia != null)
            {
                _context.Competencias.Remove(Competencia);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
