namespace LabToys.Entities
{
    public class AnalysisTemplate : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserId { get; set; } //powiązać z userem

        public DateTime LastModifiedDate { get; set;}

        public int LastModifiedByUserId { get; set; } //powiązać z userem

        public User User { get; set; }

        public List<AnalysisSection> AnalysisSections { get; set; }


    }
}
