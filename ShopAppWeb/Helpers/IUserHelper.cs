namespace ShopAppWeb.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using ShopAppWeb.Data.Entities;
    using System.Threading.Tasks;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
