using KpiNew.Enum;
using KpiNew.Entities;
using System.ComponentModel.DataAnnotations;
namespace KpiNew.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeImage { get; set; }
        public UserDto User { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<KpiDto> Kpis { get; set; } = new List<KpiDto>();
        public ICollection<EmployeeKpiDto> EmployeeKpis { get; set; } = new List<EmployeeKpiDto>();


    }

    public class CreateEmployeeRequestModel
    {
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "")]
        public string Password { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "")]
        public string PhoneNumber { get; set; }

        public string EmployeeImage { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IList<int> Roles { get; set; } = new List<int>();

    }

    public class UpdateEmployeeRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeImage { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }

    public class LoginRespondeModel : BaseRespond<UserDto>
    {
        public string Token { get; set; }
    }


}