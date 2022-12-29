using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        MyDctionary<long,string> dict = new MyDctionary<long, string>();
        dict.Add(8978987898,"harini");
        dict.Add(7656768767,"kannan");
        dict.Add(2343234323,"harishnni");
        dict.Add(765665645,"rajam");
        dict.Add(765665645,"rajam");//Identical keys throw exception
        
        foreach(dynamic Keyvalue in dict)//(foreach(KeyValue<TKey,Tvalue> in dict))
        {
            System.Console.WriteLine("Key"+value.Key+"Value"+value.value);
            System.Console.WriteLine(dict[765668758]);//print value of the key
            dict[4565453454] = "Harini";//update value of key
        }
        if(dict.ContainsKey(8767568798))
        {
            System.Console.WriteLine(dict[6576783876]);
        }
        if(dict.ContainsValue("Harini"))
        {
                System.Console.WriteLine("harini is present");
            dict.Remove(7656765676);
        dict.clear();
        }
        string result;
        if(dict.TryGetValue(7867876787,out result))
        {
            System.Console.WriteLine(result);
        }
        for(int i = 0;i<dict._count;i++)
        {
            System.Console.WriteLine("Key: {0},Value: {1}",);
        }
        public TValue this[TKey key]
        {
            get
            {
                if(LinearSearch(key,out int position,out value1))
                {
                    return value1;
                }
            }
            set
            {
                int position;
                LinearSearch(KeyValue,out position,out TValue value1);
                if(position >= 0 && position < _count)
                {
                    _array[position].Value = value;
                }
            }
        }
    }
}