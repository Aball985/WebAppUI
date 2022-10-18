using AustinWebAPI.API.Models.Domains;

namespace AustinWebAPI.API.Repos
{
    public interface IRegionRepo
    {
       IEnumerable<Region> GetAll();
    }
}
