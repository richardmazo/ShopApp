namespace ShopAppWeb.Data
{
    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {

            this.context = context;
            UserHelper = userHelper;
            this.random = new Random();
        }

        public IUserHelper UserHelper { get; }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.UserHelper.GetUserByEmailAsync("richard.mazo.15.11@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Richard",
                    LastName = "Mazo",
                    Email = "richard.mazo.15.11@gmail.com",
                    UserName = "richard.mazo.15.11@gmail.com"
                };

                var result = await this.UserHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Products.Any())
            {
                this.AddProduct("iPhone X", user);
                this.AddProduct("Magic Mouse", user);
                this.AddProduct("iWatch Series 4", user);
                await this.context.SaveChangesAsync();
            }

        }

        private void AddProduct(string name, User user)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(100),
                IsAvailabe = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}
