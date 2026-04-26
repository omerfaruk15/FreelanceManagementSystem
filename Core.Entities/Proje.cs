namespace Core.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ? ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Budget { get; set; }
        public bool IsCompleted { get; set; }
    }
}