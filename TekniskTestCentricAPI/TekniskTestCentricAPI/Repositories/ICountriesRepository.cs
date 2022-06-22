using TekniskTestCentricAPI.DataModels;

namespace TekniskTestCentricAPI.Repositories
{
    public interface ICountriesRepository
    {

        Task<List<Continent>> GetContinentsAsync();

        Task<List<Country>> GetCountriesAsync();

        Task<Country> AddCountry(Country request);

        Task<Continent> AddContinent(Continent request);


    }
}
