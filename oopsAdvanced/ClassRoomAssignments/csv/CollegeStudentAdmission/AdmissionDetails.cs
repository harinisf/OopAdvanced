using System;
namespace CollegeStudentAdmission
{
    public enum AdmissionStatus{Select,Admitted,Cancelled};
    public class AdmissionDetails
    {
        private static int s_admissionID = 1001;
        public string  AdmissionID { get; set; }
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }
        //public AdmissionDetails();
        public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID = "AID"+s_admissionID;
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }

    }
}