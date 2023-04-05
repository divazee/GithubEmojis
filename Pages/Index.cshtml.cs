using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GithubEmojis.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private IGithubEmojiService _emojiService;

    public IndexModel(ILogger<IndexModel> logger, IGithubEmojiService emojiService)
    {
        _logger = logger;
        _emojiService = emojiService;
    }

    public IList<Emoji> Emojis { get; set; }

    public async Task OnGet()
    {
        Emojis = await _emojiService.GetEmojis();
    }
}

