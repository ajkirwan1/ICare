using ICare.Domain;

namespace ICare.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any()) return;

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Adam",
                    Password = "password",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Kasia",
                    Password = "password",
                }
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}
