﻿using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student("Павел", "Леонидович", "Ефимов", 4,10,2001, "К3120", "ФИКТ");
            p.WriteFullInfo();
        }
    }
}
