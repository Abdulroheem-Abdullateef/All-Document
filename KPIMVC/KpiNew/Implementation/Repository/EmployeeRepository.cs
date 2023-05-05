using System.Linq.Expressions;
using KpiNew.Context;
using KpiNew.Entities;
using KpiNew.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace KpiNew.Implementation.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Employee> Get(Expression<Func<Employee, bool>> expression)
        {

            return await _context.Employees
                  .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(e => e.EmployeeKpis)
                   .Where(b => b.IsDeleted == false)
                  .SingleOrDefaultAsync(expression);

        }

        public async Task<IList<Employee>> GetAll()
        {
             return await _context.Employees
                .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(a => a.EmployeeKpis)
               .Where(b => b.IsDeleted == false)
                .ToListAsync();   
        }

        public async Task<ICollection<Employee>> GetAllEmployeeDepartmentAsync(int departmentId)
        {
            return await _context.Employees
             .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(a => a.EmployeeKpis)
               .Where(d => d.DepartmentId == departmentId).ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees
                .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(a => a.EmployeeKpis)
               .Where(b => b.IsDeleted == false)
                .SingleOrDefaultAsync(a => a.Id==id);
        }
        public async Task<IList<Employee>> GetSelected(IList<int> ids)
        {
             return await _context.Employees
                  .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(a => a.EmployeeKpis)
                   .Where(b => b.IsDeleted == false)
                  .Where(a => ids.Contains(a.Id)).ToListAsync();
        }

        public async Task<IList<Employee>> GetSelected(Expression<Func<Employee, bool>> expression)
        {
             return await _context.Employees
                  .Include(a => a.Department)
               .ThenInclude(k => k.DepartmentKpis).ThenInclude(e => e.Kpi)
               .ThenInclude(a => a.EmployeeKpis)
                   .Where(b => b.IsDeleted == false)
                  .Where(expression).ToListAsync();
        }
    }
}