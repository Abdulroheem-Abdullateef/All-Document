using KpiNew.Dtos;
namespace KpiNew.Interface.Service
{
    public interface IEmployeeService
    {
        Task<BaseRespond<EmployeeDto>> AddEmployeeAsync(CreateEmployeeRequestModel model);
        Task<BaseRespond<EmployeeDto>> UpdateEmployeeAsync(int id, UpdateEmployeeRequestModel model);
        Task<BaseRespond<EmployeeDto>> DeleteEmployeeAsync(int id);
        Task<BaseRespond<EmployeeDto>> GetEmployeeByIdAsync(int id);
        Task<BaseRespond<ICollection<EmployeeDto>>> GetAllEmployeeDepartmentAsync( int departmentId);
        Task<BaseRespond<ICollection<EmployeeDto>>> GetAllEmployeeAsync();

    }
}