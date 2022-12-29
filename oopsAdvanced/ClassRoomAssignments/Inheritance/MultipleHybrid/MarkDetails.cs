namespace MultipleHybrid
{
    public interface IMarkDetails
    {
        //property declaration
        int Mark1 { get; set; }
        int Mark2 {get;set;}
        int Mark3 {get;set;}
        double Average{get;set;}
        //method declaration
        void GetMarks(int Mark1,int Mark2,int Mark3);
        void Calculate();
    }
}