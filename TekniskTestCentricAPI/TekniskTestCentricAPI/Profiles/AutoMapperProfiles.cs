using AutoMapper;
using TekniskTestCentricAPI.DomainModels;

namespace TekniskTestCentricAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {

            CreateMap<DataModels.Continent, Continent>()
                .ReverseMap();

            CreateMap<DataModels.Country, Country>()
                .ReverseMap();

        }
    }
}
