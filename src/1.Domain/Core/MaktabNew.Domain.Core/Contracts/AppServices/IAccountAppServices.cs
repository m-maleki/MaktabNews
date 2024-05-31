using Microsoft.AspNetCore.Identity;

namespace MaktabNews.Domain.Core.Contracts.AppServices;
public interface IAccountAppServices
{
    Task<List<IdentityError>> Register(string email, string password,bool isReporter , bool isVisitor,string phoneNumber);
    Task<bool> Login(string email, string password);
}