using System.Security.Claims;
using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<IdentityError>> Register(string email, string password, bool isReporter, bool isVisitor, string phoneNumber)
    {


        var role = string.Empty;
        var user = CreateUser();

        user.UserName = email;
        user.Email = email;
        user.PhoneNumber = phoneNumber;

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

        if (isReporter)
        {
            var userReporterId = user.Reporter!.Id;
            await _userManager.AddClaimAsync(user, new Claim("userReporterId", userReporterId.ToString()));
        }


        if (isVisitor)
        {
            var userVisitorId = user.Visitor!.Id;
            await _userManager.AddClaimAsync(user, new Claim("userVisitorId", userVisitorId.ToString()));
        }


        if (result.Succeeded)
            await _userManager.AddToRoleAsync(user, role);

        return (List<IdentityError>)result.Errors;
    }

    public async Task<bool> Login(string email, string password)
    {

        var user = await _userManager.Users
            .Include(u => u.Reporter)
            .Include(x=>x.Visitor)
            .FirstOrDefaultAsync(u => u.Email == email);


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
