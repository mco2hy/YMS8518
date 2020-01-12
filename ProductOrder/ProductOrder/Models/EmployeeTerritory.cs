namespace ProductOrder.Models
{
    public class EmployeeTerritory
    {
        public int Id { get; set; }

        public int TerritorryID { get; set; }
        public Territory Territory { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
