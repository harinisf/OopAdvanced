using System;
namespace CollegeStudentAdmission
{
    public enum Gender{Select,Male,Female,TransGender}
    public class StudentDetails
    {
        private static int s_studentID = 3000;
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender{get; set;}
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

        public StudentDetails(string name,string fatherName,DateTime Date,Gender gender,int physicsMarks,int chemistryMarks,int mathsMarks)
        {
            s_studentID++;
            StudentID = "SF"+s_studentID;
            Name = name;
            FatherName = fatherName;
            DOB = Date;
            Gender = gender;
            PhysicsMark = physicsMarks;
            ChemistryMark = chemistryMarks;
            MathsMark = mathsMarks;
        }

         public StudentDetails(string data)
        {
            string []values = data.Split(",");
            s_studentID = int.Parse(values[0].Remove(0,2));
            StudentID = values[0];
            Name = values[1];
            FatherName = values[2];
            DOB = DateTime.Parse(values[3]);
            Gender = Enum.Parse<Gender>(values[4]);
            PhysicsMark = int.Parse(values[6]);
            ChemistryMark = int.Parse(values[7]);
            MathsMark = int.Parse(values[8]);
        }

        public bool CheckEligiblity(double mark)
        {
            if(mark >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}