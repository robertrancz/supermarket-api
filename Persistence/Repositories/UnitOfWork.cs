using System.Threading.Tasks;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    // only save all changes into the database after you finish modifying it using your repositories
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}