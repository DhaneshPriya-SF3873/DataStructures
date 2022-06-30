using System;
namespace UniCastDelegate
{
    delegate int NumberChanger(int n); // Can add methods having int return type &  1 int arg
    public class TestDelegate
    {
        static int num=10;

        public static int AddNum(int p)
        {
            num +=p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *=q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
        

        
    }
}