namespace KpiNew.Entities

{
    public class Kpi : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate {get; set;}
        public ICollection<DepartmentKpi> DepartmentKpis {get; set;} = new List<DepartmentKpi>();
        public ICollection<EmployeeKpi> EmployeeKpis {get; set;} = new List<EmployeeKpi>();

       
    }
}