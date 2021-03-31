using System;
using System.Collections.Generic;
using System.Text;

namespace MyDIConteyner
{
    public class Welcom : IWelcom
    {
        private IWriter writer;

        public Welcom(IWriter writer)
        {
            this.writer = writer;
        }

        public void HelloTo(string name)
        {
            writer.Write($"Hello {name}!");
        }
    }
}
