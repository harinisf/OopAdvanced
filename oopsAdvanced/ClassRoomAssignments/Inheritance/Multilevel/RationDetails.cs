using System;
namespace Multilevel
{
    public class RationDetails:PersonalDetails
    {
        private static int s_cardID = 100;
        public string CardID{ get;}
        public string[] FamilyMembers{get;set;}

        public RationDetails(int aadharID,string name,string fatherName,string gender,DateTime dob,string[] familyDetails):base(aadharID,name,fatherName,gender,dob)
        {
            CardID = "TN"+s_cardID++;
            FamilyMembers = familyDetails;
        }
    }
}