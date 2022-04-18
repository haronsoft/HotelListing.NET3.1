using HotelListing.Data;
using HotelListing.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly ApplicationDbContext _context;

        public CountriesRepository( ApplicationDbContext context): base(context)
        {
            _context = context;
        }


    /*    public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(q => q.Id == id);
        }
*/
       async Task<Country> ICountriesRepository.GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}