using KpiNew.Enum;
namespace KpiNew.Entities
{
    public class EmployeeKpi : BaseEntity
    {
        public Kpi Kpi {get; set;} 
        public int KpiId {get; set;}   
        public Employee Employee {get; set;}
        public int EmployeeId {get; set;}
        public Month Month {get; set;}
        public int Year {get; set;}
        public DateTime Date {get; set;}
        public double TotalRating { get; set;}
        public string Comment {get; set;}
        
    }
}