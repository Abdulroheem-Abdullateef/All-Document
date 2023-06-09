using System.Linq.Expressions;
using KpiNew.Entities;
using KpiNew.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace KpiNew.Implementation.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public async Task<User> Get(Expression<Func<User, bool>> expression)
        {
          
            return await _context.Users
            .Include(a =>a.UserRoles)
            .ThenInclude(r => r.Role)
            .Where(a => a.IsDeleted == false)
            .SingleOrDefaultAsync(expression);
                
        }

        public async Task<IList<User>> GetAll()
        {
            return await _context.Users
            .Include(u => u.UserRoles)
            .ThenInclude(r => r.Role)
            .Where(a => a.IsDeleted == false)
            .ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
             return await _context.Users.Include(a => a.UserRoles)
                .ThenInclude(u => u.Role)
                .Where(a => a.IsDeleted == false)
                .Where(a => a.Email == email)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<User>> GetSelected(IList<int> ids)
        {
             return await _context.Users
              .Include(a => a.UserRoles)
              .ThenInclude(u => u.Role)
                 .Where(a => a.IsDeleted == false)
              .Where(a => ids.Contains(a.Id))
              .ToListAsync();
        }

        public async Task<IList<User>> GetSelected(Expression<Func<User, bool>> expression)
        {
            return await _context.Users
              .Include(a => a.UserRoles)
              .ThenInclude(u => u.Role)
                 .Where(a => a.IsDeleted == false)
              .Where(expression)
              .ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
             return await _context.Users.Include(e =>e.Employee)
                .Include(a => a.UserRoles)
                .ThenInclude(u => u.Role)
                 .Where(a => a.IsDeleted == false)
                .SingleOrDefaultAsync(i => i.Id == id);
        }
    }
}