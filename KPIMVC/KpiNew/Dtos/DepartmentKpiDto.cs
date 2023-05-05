using KpiNew.Entities;
namespace KpiNew.Dtos
{
    public class DepartmentKpiDto
    {
         public int Id { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int KpiId { get; set; }
        public Kpi Kpis { get; set; }
        public double Percentage { get; set; }
        public string Comment {get; set;}
    }

  
}