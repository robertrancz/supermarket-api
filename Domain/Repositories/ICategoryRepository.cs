using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
         Task AddAsync(Category category);
         Task<Category> FindByIdAsync(int id);
         // Update is not async since Entity Framework API is not async for update 
         void Update(Category category);
         void Remove(Category category);
    }
}