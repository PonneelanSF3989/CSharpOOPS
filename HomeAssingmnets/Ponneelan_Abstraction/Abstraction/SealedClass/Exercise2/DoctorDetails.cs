

namespace Exercise2
{
    public class DoctorInfo:PatientDetails
    {
        //getting error while inherit a sealed class
        public int DoctorId  { get; set; }
        public string DoctorName { get; set; }
        public string FatherName { get; set; }
    }
}