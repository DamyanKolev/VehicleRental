using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VehicleRental.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DatabaseContext _dbContext;
    public string HideShowDialog { get; set; }

    public IndexModel(DatabaseContext databaseContext, ILogger<IndexModel> logger)
    {
        _dbContext = databaseContext;
        _logger = logger;
    }

    public void OnGet()
    {
        HideShowDialog = "fd-dialog--active";
    }

    public void OnPostCheckEmail()
    {
        //here we need to check the email address. 
        //If have an account with the email address then the use need to write his password -> return true
        //if does not have an account with the given email then the user need to create a new account -> return false
    }

    public void OnPostLogin()
    {
        //here we need to check email/username and password 
        //if the email/username and password are matched then return 200 code response and message "successfull login in"
        //if the email/username and password are not matched then return 403 code response and message "wrong email/username or password"
    }

    public void OnPostSignIn()
    {
        //here we need to check 
        // 1. is have an account with that email address
        // 2. is the username is free -> optional, because maybe the app does not need it an username for sign in
        //if the check is true, then return 200 code and message "successfull registration"
        //if the check is false, then return bad request code and message "the registration is failed"
    }
}
