using System;

namespace MyDIConteyner
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
