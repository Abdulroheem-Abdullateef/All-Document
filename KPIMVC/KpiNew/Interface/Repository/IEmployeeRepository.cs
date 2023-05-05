using KpiNew.Entities;
using System;
using System.Linq.Expressions;

namespace KpiNew.Interface.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        public Task<Employee> GetEmployeeById(int id);
        public Task<Employee> Get(Expression<Func<Employee, bool>> expression);
        public Task<IList<Employee>> GetAll();
        public Task<IList<Employee>> GetSelected(IList<int> ids);
        public Task<IList<Employee>> GetSelected(Expression<Func<Employee, bool>> expression);
       public Task<ICollection<Employee>> GetAllEmployeeDepartmentAsync( int departmentId);



    }
}