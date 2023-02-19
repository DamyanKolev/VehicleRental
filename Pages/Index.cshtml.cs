using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VehicleRental.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string HideShowDialog { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        HideShowDialog = "fd-dialog--active";
    }

    public void OnGetCloseDialogWindow()
    {
        HideShowDialog = "";
        //fd-dialog--active

    }
}
