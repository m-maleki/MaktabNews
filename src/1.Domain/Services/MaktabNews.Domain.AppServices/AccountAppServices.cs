using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace MaktabNews.Domain.AppServices;
public class AccountAppServices : IAccountAppServices
{

    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public AccountAppServices(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<List<IdentityError>> Register(string email, string password, bool isReporter, bool isVisitor)
    {
        var role = string.Empty;

        var user = CreateUser();

        user.UserName = email;
        user.Email = email;

        if (isReporter)
        {
            role = "Reporter";
            user.Reporter = new Reporter()
            {
            };
        }

        if (isVisitor)
        {
            role = "Visitor";
            user.Visitor = new Visitor()
            {

            };
        }

        var result = await _userManager.CreateAsync(user, password);

        if (result.Succeeded)
            await _userManager.AddToRoleAsync(user, role);

        return (List<IdentityError>)result.Errors;
    }

    public async Task<bool> Login(string email, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(email, password, true, lockoutOnFailure: false);

        return result.Succeeded;
    }

    private ApplicationUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<ApplicationUser>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                                                $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
        }
    }
}
