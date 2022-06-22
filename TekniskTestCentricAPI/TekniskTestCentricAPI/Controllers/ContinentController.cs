using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TekniskTestCentricAPI.DomainModels;
using TekniskTestCentricAPI.Repositories;

namespace TekniskTestCentricAPI.Controllers

{
    [ApiController]
    public class ContinentController : Controller
    {

        private readonly ICountriesRepository countriesRepository;
        private readonly IMapper mapper;

        public ContinentController(ICountriesRepository countriesRepository, IMapper mapper)
        {
            this.countriesRepository = countriesRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        [Route("Continents")]
        public async Task<IActionResult> GetAllContinents()
        {
            var continentList = await countriesRepository.GetContinentsAsync();

            if (continentList == null || !continentList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Continent>>(continentList));
        }

        [HttpPost]
        [Route("Continents/Add")]
        public async Task<IActionResult> AddNewContinent([FromBody] Continent request) 
         {
            var continent = await countriesRepository.AddContinent(mapper.Map<DataModels.Continent>(request));
            return Ok(mapper.Map<Continent>(continent));
         }

    }
}
