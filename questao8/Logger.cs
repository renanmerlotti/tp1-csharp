﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    internal class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File: " + message);
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine("DataBase: " + message);
        }
    }
}
