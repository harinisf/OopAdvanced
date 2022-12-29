using System.Collections;
namespace MetroCardManagement
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
         int i;
        public IEnumerator GetEnumerator()
        {
            i = -1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i < _count-1)
            {
                ++i;
                return true;
            }
            Reset();//Reset position value if no element in list
            return false;
        }

        public void Reset()//Reset i for next turn 
        {
            i = -1;
        }

        public object Current //Returns current array position value
        {
            get { return _array[i];} //for start from i=0 i++;
        }
    }
}