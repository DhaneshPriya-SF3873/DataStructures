namespace DictionaryManipulation
{
    public class DictionaryDS<TKey,TValue>:Dictionary<TKey,TValue>
    {
        public int Count=0;
        public int Size=0;
        public Dictionary<TKey,TValue> [] Array{get; set; }

        public DictionaryDS(int size)
        {
            if(size==0)
            {
                Size=3; Count=0;
                Array=new Dictionary<TKey,TValue>[Size];
            }
            else if(size>0)
            {
                Array=new Dictionary<TKey,TValue>[Size*2];
                Size=Size*2;Count=0;
            }
        }

            public Dictionary<TKey,TValue> this [int i] //indexers
            {
                get
                {
                    return Array[i];
                }
                /*
                set
                {
                    if(Array!=null)
                    {
                        Array[i]=value;
                    }
                }*/

                
            }


            public void Add(TKey key,TValue value)
            {
                if(Size==Count)
                {
                    Expand();
                }
                 Dictionary<TKey,TValue> entry=new  Dictionary<TKey,TValue>();
                 entry.Key=key; entry.Value=value;
                 Array[Count]=entry;
                 Count++;
            }

            public void Expand()
            {
                Size=Size*2;
                Dictionary<TKey,TValue> [] temp=new Dictionary<TKey,TValue>[Size];
                for(int i=0; i<Array.Length; i++)
                {
                    temp[i]=Array[i];

                }
                Array=temp;

            }

    }
}