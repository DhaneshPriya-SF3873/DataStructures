using System.Collections;
namespace ListManipulation
{
    
        public partial class List<T>:IEnumerable,IEnumerator
    {
        private int position=-1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position<Array.Length-1)
            {
                ++position;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position=-1;
        }
            public object Current
            {
                get
                {
                    return Array[position];
                }
            }
        }
    }

