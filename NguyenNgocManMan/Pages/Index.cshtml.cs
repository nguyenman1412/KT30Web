using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NguyenNgocManMan.Pages;

public class IndexModel : PageModel
{
    private readonly NewsAppContext _context;

    public IndexModel(NewsAppContext context)
    {
        _context = context;
    }

    public IList<NguyenNgocManMan.Models.News> News { get; set; }

    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }
}
