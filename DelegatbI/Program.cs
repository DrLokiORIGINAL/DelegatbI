using System;

namespace DelegatbI
{
    public delegate string HelloDelegeate(string name);
    class SomeClass
    {
        public string SayHello(string s)
        {
            return $"привет, {s}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            HelloDelegeate hD = new HelloDelegeate(someClass.SayHello);
            Console.WriteLine(hD.Invoke("Antoun"));
            Console.ReadKey();
        }
    }

}
