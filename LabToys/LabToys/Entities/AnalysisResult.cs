using System.Diagnostics;

namespace LabToys.Entities
{
    public class AnalysisResult : EntityBase
    {
        public string Value { get; set; } //wynik testu jako string czy zmiennoprzecinkowe??

        public int AnalysisParameterId { get; set; }
        public AnalysisParameter AnalysisParameter { get; set; }

        public int SampleId { get; set; }

        public Sample Sample { get; set; }
    }
}
