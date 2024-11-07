using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Data;

namespace dotnet_react_example.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly CommentContext _context;

    public IndexModel(ILogger<IndexModel> logger, CommentContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IList<Comment> Comments { get; set; } = new List<Comment>();

    public async void OnGetAsync()
    {
        Comments = await _context.Comments.ToListAsync();
    }
}
