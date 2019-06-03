using DotNetCoreArchitecture.Domain;
using DotNetCoreArchitecture.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreArchitecture.Database
{
    public static class DatabaseContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUsers();
        }

        private static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(x =>
            {
                x.HasData(new
                {
                    UserId = 1L,
                    Roles = Roles.User | Roles.Admin,
                    Status = Status.Active
                });

                x.OwnsOne(y => y.FullName).HasData(new
                {
                    UserEntityUserId = 1L,
                    Name = "Administrator",
                    Surname = "Administrator"
                });

                x.OwnsOne(y => y.Email).HasData(new
                {
                    UserEntityUserId = 1L,
                    Address = "administrator@administrator.com"
                });


                x.OwnsOne(y => y.SignIn).HasData(new
                {
                    UserEntityUserId = 1L,
                    Login = "admin",
                    Password = "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw=="
                });
            });
        }
    }
}
