namespace KpiNew.Entities
{
    public class DepartmentKpi : BaseEntity
    {
        public int KpiId {get; set;}
        public Kpi Kpi {get; set;}
        public Department Department {get; set;}
        public int DepartmentId{get; set;}

    }
}