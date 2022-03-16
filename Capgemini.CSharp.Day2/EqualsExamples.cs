using System;

namespace Capgemini.CSharp.Day2
{
    
    Piclass EqualsExample
    { 
    public void Store()
    {
            Id = 1001;
            Name = "Ratnesh";
            Salary = 4555.66;
    }

    }
    struct StructExample
    {
        public int Id;
        public string Name; 
        public string Salary;   

        public StructExample(int id,string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
    class ExecuteClass
    {
        static void Main2(string[] args)
        {
            ClassExample obj;

            StructExample obj2;
            obj2.Id = 1002;
            obj2.Name = "Bathri";
            obj2.Salary = 7888;
             
            Console.WriteLine(Id :{obj2.Id}\tName : {obj2.Name}\tSalary : {obj2.Salary}");
        }
    }
}
