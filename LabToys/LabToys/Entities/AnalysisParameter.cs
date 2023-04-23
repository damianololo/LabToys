namespace LabToys.Entities
{
    public class AnalysisParameter : EntityBase
    {
        public int Name { get; set; }

        public string DataType { get; set; }  //typ danych

        public string DefaultValue { get; set; }

        public string Units { get; set; }

        public string Formula { get; set; }

        public int AnalysisSectionId { get; set; }

        public AnalysisSection AnalysisSection { get; set; }
    }
}
