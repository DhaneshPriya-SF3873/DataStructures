namespace HashTableManipulation
{
    public class HashTable:ObjectArray
    {
        public int Count;
        public int Size;
        public  ObjectArray [] tables {get; set; }

        public HashTable(int size)
        {
            if(size==0)
            {
                Size=3; Count=0;
               tables =new ObjectArray[Size];

            }
            else if(size>0)
            {
                tables=new ObjectArray[Size*2];
                Size=Size*2;Count=0;
            }
        }

            public ObjectArray this [int i] //indexers
            {
                get
                {
                    return tables[i];
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


            public void Add(object key,object value)
            {
                if(Size==Count)
                {
                    Expand();
                }
                ObjectArray entry=new  ObjectArray();
                 entry.Key=key; entry.Value=value;
                 tables[Count]=entry;
                 Count++;
            }

            public void Expand()
            {
                Size=Size*2;
                ObjectArray[] temp=new ObjectArray[Size];
                for(int i=0; i<tables.Length; i++)
                {
                    temp[i]=tables[i];

                }
                tables=temp;

            }

    }
}