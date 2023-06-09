
using KpiNew.Dtos;
using KpiNew.Entities;
using KpiNew.Interface.Repository;
using KpiNew.Interface.Service;

namespace KpiNew.Implementation.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository,
        IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }


        public async Task<BaseRespond<EmployeeDto>> AddEmployeeAsync(CreateEmployeeRequestModel model)
        {
            var employeeExist = await _employeeRepository.Get(e => e.Email == model.Email);
            if (employeeExist != null)
            {
                return new BaseRespond<EmployeeDto>
                {
                    Message = $"Employee with {model.Email} already exist",
                    Success = false,
                };
            }

            else
            {
                var user = new User
                {
                    Email = model.Email,
                    Password = model.Password,
                };
              var roles = await _roleRepository.GetSelected(model.Roles);
                
                foreach (var role in roles)
                {
                    var userRole = new UserRole 
                    {
                        User = user,
                        Role = role,
                        UserId = user.Id,
                        RoleId = role.Id,
                    };
                    
                    user.UserRoles.Add(userRole);

                }
                
                await _userRepository.Create(user);
                
                var employee = new Employee
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    City = model.City,
                    Email = model.Email,
                    Gender = model.Gender,
                    EmployeeImage = model.EmployeeImage,
                    User = user,
                    UserId = user.Id,
                    DateOfBirth = model.DateOfBirth,
                    DepartmentId = model.DepartmentId,
                    Department = await _departmentRepository.GetDepartmentById(model.DepartmentId),
                    PhoneNumber = model.PhoneNumber,

                };

                var employees = await _employeeRepository.Create(employee);

                return new BaseRespond<EmployeeDto>
                {
                    Success = true,
                    Message = "Employee Create Successfully",
                    Data = new EmployeeDto
                    {
                        FirstName = employees.FirstName,
                        LastName = employees.LastName,
                        Address = employees.Address,
                        DateOfBirth = employees.DateOfBirth,
                        City = employees.City,
                        DepartmentId = employees.DepartmentId,
                        EmployeeImage = employees.EmployeeImage,
                        Gender = employees.Gender,
                        Email = employees.Email,
                        PhoneNumber = employees.PhoneNumber,

                    }
                };
            }

        }

        public async Task<BaseRespond<EmployeeDto>> DeleteEmployeeAsync(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return new BaseRespond<EmployeeDto>
                {
                    Success = false,
                    Message = "employee not found",
                };
            }

            employee.IsDeleted = true;
            _employeeRepository.SaveChanges();

            return new BaseRespond<EmployeeDto>
            {
                Success = true,
                Message = $"Employee with {employee.Email} was delete successfully",
            };

        }

        public async Task<BaseRespond<ICollection<EmployeeDto>>> GetAllEmployeeAsync()
        {
            var employee = await _employeeRepository.GetAll();
            var employees = employee.Select(a => new EmployeeDto
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Address = a.Address,
                DateOfBirth = a.DateOfBirth,
                City = a.City,
                EmployeeImage = a.EmployeeImage,
                Gender = a.Gender,
                Email = a.Email,
                PhoneNumber = a.PhoneNumber,

                Department = new DepartmentDto
                {
                    Id = a.Department.Id,
                    Name = a.Department.Name,
                    Description = a.Department.Description,
                },
                EmployeeKpis = a.EmployeeKpis.Select(b => new EmployeeKpiDto
                {
                    Year = b.Year,
                    Date = b.Date,
                    Month = b.Month,
                    TotalPercentage = b.TotalRating,
                    Comment = b.Comment,

                }).ToList(),




            }).ToList();


            return new BaseRespond<ICollection<EmployeeDto>>
            {
                Success = true,
                Data = employees,
                Message = "Employee Retrieved"
            };

        }

        public async Task<BaseRespond<ICollection<EmployeeDto>>> GetAllEmployeeDepartmentAsync( int departmentId)
        {
            var employee = await _employeeRepository.GetAllEmployeeDepartmentAsync(departmentId);

             var employees = employee.Select(a => new EmployeeDto
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Address = a.Address,
                DateOfBirth = a.DateOfBirth,
                City = a.City,
                EmployeeImage = a.EmployeeImage,
                Gender = a.Gender,
                Email = a.Email,
                PhoneNumber = a.PhoneNumber,

                Department = new DepartmentDto
                {
                    Id = a.Department.Id,
                    Name = a.Department.Name,
                    Description = a.Department.Description,
                },
                EmployeeKpis = a.EmployeeKpis.Select(b => new EmployeeKpiDto
                {
                    Year = b.Year,
                    Date = b.Date,
                    Month = b.Month,
                    TotalPercentage = b.TotalRating,
                    Comment = b.Comment,

                }).ToList(),




            }).ToList();


            return new BaseRespond<ICollection<EmployeeDto>>
            {
                Success = true,
                Data = employees,
                Message = "Employee Retrieved"
            };




            
        }

        public async Task<BaseRespond<EmployeeDto>> GetEmployeeByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return new BaseRespond<EmployeeDto>
                {
                    Success = false,
                    Message = $"department doesnot exist"
                };

            }

            else
            {
                return new BaseRespond<EmployeeDto>
                {
                    Success = true,
                    Data = new EmployeeDto
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Address = employee.Address,
                        DateOfBirth = employee.DateOfBirth,
                        City = employee.City,
                        DepartmentId = employee.DepartmentId,
                        EmployeeImage = employee.EmployeeImage,
                        Gender = employee.Gender,
                        Email = employee.Email,
                        PhoneNumber = employee.PhoneNumber,
                        Department = new DepartmentDto
                        {
                            Name = employee.Department.Name,
                            Description = employee.Department.Description,
                        },
                        EmployeeKpis = employee.EmployeeKpis.Select(b => new EmployeeKpiDto
                        {
                            Year = b.Year,
                            Date = b.Date,
                            Month = b.Month,
                            TotalPercentage = b.TotalRating,
                            Comment = b.Comment,

                        }).ToList(),

                    },
                    Message = "Employee Retrived successfully",
                };
            }

        }

        public async Task<BaseRespond<EmployeeDto>> UpdateEmployeeAsync(int id, UpdateEmployeeRequestModel model)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return new BaseRespond<EmployeeDto>
                {
                    Success = false,
                    Message = $" Employee was not found",
                };

            }

            else
            {
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.Address = model.Address;
                employee.City = model.City;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Email = model.Email;
                employee.EmployeeImage = model.EmployeeImage;
                employee.Gender = model.Gender;
                employee.PhoneNumber = model.PhoneNumber;


                await _employeeRepository.Update(employee);

                return new BaseRespond<EmployeeDto>
                {
                    Success = true,
                    Message = "Employee Update Successfully",
                    Data = new EmployeeDto
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Address = employee.Address,
                        DateOfBirth = employee.DateOfBirth,
                        Gender = employee.Gender,
                        EmployeeImage = employee.EmployeeImage,
                        Email = employee.Email,
                        PhoneNumber = employee.PhoneNumber,
                        City = employee.City,


                    }
                };
            }
        }
    }
}