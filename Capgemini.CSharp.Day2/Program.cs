﻿using System;
namespace Capgemini.CSharp.Day2
{
    public class StructureExample
    {
        int id;
        string name;
        double salary;
        public void store()
        {
            id = 2513;
            name = "Ratnesh";
            salary = 50000;
        }
        public static void Main3(string[] args)
        {
            StructureExample obj = new StructureExample();
            obj.store();
            Console.WriteLine($"Id:{obj.id}\tName:{obj.name}\tSalary:{obj.salary}");
        }

    }



}