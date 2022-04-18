using HotelListing.Data;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}