namespace Interfaces
{
    public interface Icalculate
    {
        int number { get; set; }
        int claculate();
    }
    public class Square :Icalculate
    {
        private int _number;
        public int Number {get{return _number;}set{_number = value}}

        public int claculate()
        {
            _number *= _number;
            return _number;
        }
        
    }

}