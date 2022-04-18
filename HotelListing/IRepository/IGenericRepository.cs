using HotelListing.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);

    }
    public interface ICountriesInterface : IGenericRepository<Country>
    {

    }
}