using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenNgocManMan.Models;

namespace NguyenNgocManMan.Pages_News
{
    public class IndexModel : PageModel
    {
        private readonly NewsAppContext _context;

        public IndexModel(NewsAppContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }

        public async Task OnGetAsync()
        {
            News = await _context.News.ToListAsync();
        }
    }
}
