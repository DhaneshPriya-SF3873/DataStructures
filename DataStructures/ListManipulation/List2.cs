namespace ListManipulation
{
    public partial class List<T>
        {
        public void BubbleSort()
     {
          T temp;
         for(int i=0; i<Array.Length-2; i++)
         {
             for(int j=0; j<Array.Length-2; j++)
             {
               if(CompareGreater(Array[i],Array[i+1]))
             {
                  temp=Array[i+1];
                 Array[i+1]=Array[i];
                 Array[i]=temp;

             }
             }
         }
        }

 public bool CompareGreater(T value1, T value2)
 {
     var result= Comparer<T>.Default.Compare(value1,value2);
     if(result>=0)
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