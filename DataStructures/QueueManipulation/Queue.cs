namespace QueueManipulation
{
    public class Queue<T>
    {
        protected int Front;
        protected int Rear;
        protected int Size;
        public T[] Items{get;set;}

        public Queue(int value)
        {
            Items=new T[value];
            Front=0;
            Rear=-1;
            Size=value;
        }

        public void Enqueue(T value)
        {
            ++Rear;
            if(Rear==Size)
            {
                System.Console.WriteLine("Queue is full");
            }
            else
            {
                Items[Rear]=value;
            }
        }

        public T Dequeue()
        {
            T value=default(T);
            if(Rear<Front)
            {
             System.Console.WriteLine("Queue is empty");
            }
            else
            {
                
                System.Console.WriteLine("Output from queue"+" "+Items[Front]);
                value=Items[Front];
                Front++;
            }
            return value;
        }

    }
}