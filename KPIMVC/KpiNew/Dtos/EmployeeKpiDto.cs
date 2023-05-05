using KpiNew.Entities;
using KpiNew.Enum;
namespace KpiNew.Dtos
{
    public class EmployeeKpiDto
    {
        public int Id { get; set; }
        public ICollection<KpiDto> Kpis { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public double TotalPercentage { get; set; }
         public string Comment { get; set; }

    }

    public class CreateEmployeeKpiRequestModel
    {
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public double TotalRating { get; set; }
        public string Comment { get; set; }


    }

    public class UpdateEmployeeKpiRequestModel
    {
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public double TotalRating { get; set; }
        public string Comment { get; set; }



    }
}