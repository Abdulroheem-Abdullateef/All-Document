namespace KpiNew.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<DepartmentKpi> DepartmentKpis {get; set;} = new List<DepartmentKpi>();


    }
}