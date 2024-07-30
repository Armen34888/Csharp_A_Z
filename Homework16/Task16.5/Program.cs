namespace Task16._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyInterface @interface = new MyClass();
            @interface.GetHashCode();
            Console.WriteLine(@interface.GetHashCode());
           

            
            
        }
    }

    interface MyInterface
    {
        void Foo()
        {
            Console.WriteLine("ndvibevbidv");
        }
        
              
    }

    class MyClass : MyInterface
    {
        public void Foo()
        {
         Console.WriteLine("nxaaaaaaaaaaaaaa");
        }
    }
}
