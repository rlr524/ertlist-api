using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedDataLocation(DataContext context)
        {
            if (context.Locations.Any()) return;

            var locations = new List<Location>
            {
                new Location
                {
                    Id = default,
                    Abbreviation = "0360",
                    Name = "Fashion Valley",
                    Street = "6997 Friars Road",
                    City = "San Diego",
                    State = "CA",
                    Zip = "92108",
                    Phone = "(619) 295-4441",
                    Region = "Southern California",
                    Members = null,
                    Active = default
                }
            };
            
            await context.Locations.AddRangeAsync(locations);
            await context.SaveChangesAsync();
        }
        
        public static async Task SeedDataMember(DataContext context)
        {
            if (context.Members.Any()) return;

            var members = new List<Member>
            {
                new Member
                {
                    Id = default,
                    EmployeeNumber = "1256601",
                    LastName = "Ranf",
                    FirstName = "Rob",
                    Title = "Title",
                    OfficePhone = null,
                    MobilePhone = "425-466-7561",
                    OtherPhone = null,
                    Location = null,
                    Active = default
                }
            };
            
            await context.Members.AddRangeAsync(members);
            await context.SaveChangesAsync();
        }
    }
}