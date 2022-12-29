using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace CollegeStudentAdmission
{
    public static class Files
    {
        public static void create()
        {
            if(!Directory.Exists("CollegeAdmission"))
            {
                Directory.CreateDirectory("CollegeAdmission");
                System.Console.WriteLine("Folder created");
            }
            else{
                System.Console.WriteLine("Folder found");
            }
            if(!File.Exists("CollegeAdmission/Student.json"))
            {
                File.Create("CollegeAdmission/Student.json").Close();
            }
            if(!File.Exists("CollegeAdmission/Admission.json"))
            {
                File.Create("CollegeAdmission/Admission.json").Close();
            }
            if(!File.Exists("CollegeAdmission/DepartmentDetails.json"))
            {
                File.Create("CollegeAdmission/DepartmentDetails.json").Close();
            }
        }
        public static void WriteToJSON()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            StreamWriter writestudents = new StreamWriter("CollegeAdmission/Student.json");
            StreamWriter writeadmission = new StreamWriter("CollegeAdmission/Admission.json");
            StreamWriter writedepartment = new StreamWriter("CollegeAdmission/DepartmentDetails.json");

            writestudents.WriteLine(JsonSerializer.Serialize(Operatons.studentlist,options));
            writeadmission.WriteLine(JsonSerializer.Serialize(Operatons.admissionlist,options));
            writedepartment.WriteLine(JsonSerializer.Serialize(Operatons.departmentlist,options));

            writestudents.Close();
            writeadmission.Close();
            writedepartment.Close();
        }

        public static void ReadFromJSON()
        {
            Operatons.studentlist = JsonSerializer.Deserialize<List<StudentDetails>>(File.ReadAllText("CollegeAdmission/Student.json"));
            Operatons.admissionlist = JsonSerializer.Deserialize<List<AdmissionDetails>>(File.ReadAllText("CollegeAdmission/Admission.json"));
            Operatons.departmentlist = JsonSerializer.Deserialize<List<DepartmentDetails>>(File.ReadAllText("CollegeAdmission/DepartmentDetails.json"));
        }
    }
}