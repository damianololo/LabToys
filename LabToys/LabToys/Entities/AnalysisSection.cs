namespace LabToys.Entities
{
    public class AnalysisSection : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int SequenceNumber { get; set; }

        public int AlanysisTemplateId { get; set; }

        public AnalysisTemplate AnalysisTemplate { get; set; }

        public List<AnalysisParameter> AnalysisParameters { get; set; }
    }
}
