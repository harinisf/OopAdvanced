using System;
namespace Multilevel
{
    public class PersonalDetails
    {
        static private int s_aadharID = 100;
        public int AadharID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        //default constructor
        //public PersonalDetails(){}

        public PersonalDetails(string name,string fatherName,string gender,DateTime dob)
        {
            s_aadharID++;
            AadharID = AadharID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }
        public PersonalDetails(int aadharID,string name,string fatherName,string gender,DateTime dob)
        {
            s_aadharID++;
            AadharID = AadharID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }

    }
}