using KpiNew.Entities;
namespace KpiNew.Dtos
{
    public class KpiDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public ICollection<DepartmentKpiDto> DepartmentKpis { get; set; } = new List<DepartmentKpiDto>();
        public ICollection<EmployeeKpiDto> EmployeeKpis { get; set; } = new List<EmployeeKpiDto>();
    }

    public class CreateKpiRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public IList<int> DepartmentIds { get; set; } = new List<int>();
    }

    public class UpdateKpiRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }


}