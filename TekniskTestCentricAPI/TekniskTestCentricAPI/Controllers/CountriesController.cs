using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TekniskTestCentricAPI.DomainModels;
using TekniskTestCentricAPI.Repositories;

namespace TekniskTestCentricAPI.Controllers
{

    [ApiController]
    public class CountriesController : Controller
    {
        private readonly ICountriesRepository countriesRepository;
        private readonly IMapper mapper;

        public CountriesController(ICountriesRepository countriesRepository, IMapper mapper)
        {
            this.countriesRepository = countriesRepository;
            this.mapper = mapper;
        }



        [HttpGet]
        [Route("Countries")] 
        public async Task <IActionResult> GetAllCountries()
        {
            var countriesList = await countriesRepository.GetCountriesAsync();

            if (countriesList == null || !countriesList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Country>>(countriesList));

        }

        [HttpPost]
        [Route("Countries/Add")]
        public async Task <IActionResult> AddCountry([FromBody] Country request)
        {
            var country = await countriesRepository.AddCountry(mapper.Map<DataModels.Country>(request));
            return Ok(mapper.Map<Country>(country));
        }

      

    }
}
