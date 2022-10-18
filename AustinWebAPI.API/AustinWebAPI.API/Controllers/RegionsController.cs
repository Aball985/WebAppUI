using AustinWebAPI.API.Models.Domains;
using AustinWebAPI.API.Models.DTO;
using AustinWebAPI.API.Repos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AustinWebAPI.API.Controllers
{
    [ApiController]
    [Route("regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepo regionRepo;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepo regionRepo,IMapper mapper)
        {
            this.regionRepo = regionRepo;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            try
            {
                List<Region> regions = regionRepo.GetAll().ToList();
                List<RegionDTO> regionDTO = new List<RegionDTO>();

                //foreach (var item in regions)
                //{
                //    RegionDTO regionDTO = new RegionDTO()
                //    {
                //        Id = item.Id,
                //        Code = item.Code,
                //        Latitude = item.Latitude,
                //        Longitude = item.Longitude,
                //        Name = item.Name,
                //        Population = item.Population,
                //        Walks = item.Walks
                //    };

                //    regionsDTO.Add(regionDTO);
                //}

                //Maps to DTO
                regionDTO = mapper.Map<List<RegionDTO>>(regions);

                if (regions is not null)
                {
                    return Ok(regions);
                }

                return NotFound(regions);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
