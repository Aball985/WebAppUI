using AustinWebAPI.API.Data;
using AustinWebAPI.API.Models.Domains;

namespace AustinWebAPI.API.Repos
{
    public class RegionRepo : IRegionRepo
    {
        private readonly DBContext dBContext;

        public RegionRepo(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return dBContext.Regions.ToList();
        }
    }
}
