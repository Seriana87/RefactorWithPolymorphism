using BackendDeveloper.Assignment3;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleTask2
{
    class Program
    {
        public static void Main(string[] args)
        {

            PersonParser pp = new PersonParser(PersonParser.SourceType.Bin);
            pp.Parse("");
        }
    }
}
