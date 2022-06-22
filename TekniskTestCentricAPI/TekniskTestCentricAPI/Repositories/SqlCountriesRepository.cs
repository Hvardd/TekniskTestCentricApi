using Microsoft.EntityFrameworkCore;
using TekniskTestCentricAPI.DataModels;

namespace TekniskTestCentricAPI.Repositories
{
    public class SqlCountriesRepository : ICountriesRepository
    {
        private readonly ContinentAdminContext context;

        public SqlCountriesRepository(ContinentAdminContext context)
        {
            this.context = context;
        }

        public async Task<List<Continent>> GetContinentsAsync()
        {
            return await context.Continent.ToListAsync();
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await context.Country.Include(nameof(Continent)).ToListAsync();
        }

        public async Task<Continent> AddContinent(Continent request)
        {
            request.Id = Guid.NewGuid();  
            var continent = await context.Continent.AddAsync(request);
            await context.SaveChangesAsync();
            return continent.Entity;
        }



        public async Task<Country> AddCountry(Country request)
        {
            request.Id = Guid.NewGuid();
            var country = await context.Country.AddAsync(request);
            await context.SaveChangesAsync();
            return country.Entity;
        }
    }
}
