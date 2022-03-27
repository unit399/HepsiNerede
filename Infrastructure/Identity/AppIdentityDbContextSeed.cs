using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Okan",
                    Email = "okan@okan.com",
                    UserName = "okan@okan.com",
                    Address = new Address
                    {
                        FirstName = "Okan",
                        LastName = "Çilingiroğlu",
                        Street = "adres1",
                        City = "Ankara",
                        State = "Çankaya",
                        ZipCode = "06550"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
