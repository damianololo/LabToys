namespace LabToys.Entities
{
    public class Sample : EntityBase
    {
        public DateTime TestDate { get; set; }

        public List<AnalysisResult> AnalysisResults { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
