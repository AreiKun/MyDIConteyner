using System;
using System.Collections.Generic;
using System.Text;

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
