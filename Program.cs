using System;
namespace israr
{

    class A
    {
        static void Main(String[] args)
        {
            A a = new A();
            System.Console.WriteLine(a.sum(20, 60));
            System.Console.WriteLine(a.sum(20, 30, 40));
            System.Console.WriteLine(a.sub(200, 100));
            System.Console.WriteLine(a.sub(500, 200, 100));
            System.Console.WriteLine(a.mul(20, 30));
            System.Console.WriteLine( a.mul(20,60,20));

        }
        public int sum(int a, int b)
        {
            return (a + b);
        }
        public int sum(int a, int b, int c)
        {
            return (a + b + c);
        }
        public int sub(int a, int b)
        {
            return (a - b);
        }
        public int sub(int a, int b, int c)
        {
            return (a - b - c);
        }
         public int mul(int a, int b)
        {
            return (a * b);
        }
        public int mul(int a, int b, int c)
        {
            return (a * b * c);
        }
        
        
        
        
    }
    
}
