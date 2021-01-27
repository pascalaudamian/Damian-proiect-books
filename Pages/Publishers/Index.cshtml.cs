using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Damian.Data;
using Damian.Models;

namespace Damian.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Damian.Data.DamianContext _context;

        public IndexModel(Damian.Data.DamianContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
