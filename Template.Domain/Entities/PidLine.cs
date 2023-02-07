
namespace Template.Domain.Entities
{
    public class PidLine : Entity
    {
        public string PipelineTag { get; set; }
        public string Fluid { get; set; }
        public string TagNumber { get; set; }
        public string Line_Spec { get; set; }
        public string InsulPurpose { get; set; }
        public string InsulThk { get; set; }
        public string Fluid_Description { get; set; }
        public string FluidState { get; set; }
        public string LL_From { get; set; }
        public string LL_To { get; set; }
        public float OperMinTemp { get; set; }
        public float OperNormTemp { get; set; }
        public float OperMaxTemp { get; set; }
        public float OperMinPress { get; set; }
        public float OperNormPress { get; set; }
        public float OperMaxPress { get; set; }
        public float OperNormSpecGrav { get; set; }
        public float DesignMinTemp { get; set; }
        public float DesignMaxTemp { get; set; }
        public float DesignMinPress { get; set; }
        public float DesignMaxPress { get; set; }
        public float TestMaxPress { get; set; }
        public float AltOperMinTemp { get; set; }
        public float AltOperMaxTemp { get; set; }
        public float AltOperMinPress { get; set; }
        public float AltOperMaxPress { get; set; }
        public string FluidService { get; set; }
        public string InspectionClass { get; set; }
        

    }
}
}
