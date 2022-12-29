using System;
namespace ListDS;

    
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        private int _size;
        public int count{get{return count;}}
        public int Capacity{get{return _capacity;}}
        private Type[] _array;
       
        //indexers - similar like property used to use list object as an array
        public Type this[int position]
        {
            get{return _array[position];}
            set{_array[position] = value;}
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        
        public void Add(Type data)
        {
            if(count == Capacity)
            {
                GrowSize();
            }
            else
            {
                _array[_count] = data;
                _capacity++;
            }
           
        }

        void GrowSize()
        {
            _capacity = _capacity*2;
            Type[] temp = new Type[_capacity];
            for(int i = 0;i<_count;i++)
            {
                temp[i] = _array[i];
            }
        }

        public void AddRange(CustomList<Type> dataList)
        {
            _capacity = _count + dataList._count+4;
            Type[] temp = new Type[_capacity];

        }
        public void insert(int index,Type item)
        {
            _capacity = _count+4;
            Type [] temp = new Type[_capacity];
            for(int i= 0;i<_count;i++)
            {
                if(i<index)
                {
                    temp[i] = _array[i];
                }
                else if(i == index)
                {
                    temp[i] = item;
                }
                else
                {
                    temp[i] = _array[i+1];
                }
            }
            _array = temp;
            _count++;
        }

        public bool RemoveAt(int position)
        {
            if(position < count && position > 0)
            {

                for(int i = 0;i<count;i++)
                {
                    if(i > position)
                    {
                        _array[i-1] = _array[i];
                    }
                }
                _count--;
                return true;
            }
            return false;
        }

        public int IndexOf(Type data)
        {
            int position = -1;
            for(int i = 0;i < _count;i++ )
            {
                if(data.Equals(_array[i]))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public bool Remove(Type data)
        {
            int position = IndexOf(data);
            if(position > 0)
            {
                return RemoveAt(position);
            }
            else 
            {
                return false;
            }
        }
    }