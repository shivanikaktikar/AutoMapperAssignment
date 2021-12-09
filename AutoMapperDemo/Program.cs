using System;
using AutoMapper;

namespace AutoMapperDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialize the mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());

            //Creating the source object
            Employee emp = new Employee
            {
                Name = "ABC",
                Salary = 15000,
                Address = "Pune",
                Department = "Healthcare"
            };

            //using Automapper
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<EmployeeDTO>(emp);

            Console.WriteLine("Name:" +empDTO.Name + ", Salary:" +empDTO.Salary +",Address:" +empDTO.Address +", Department" + empDTO.Department);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name {get; set;}
        public int Salary {get; set;}
        public string Address {get;set;}
        public string Department {get;set;}
    }

    public class EmployeeDTO
    {
        public string Name {get; set;}
        public int Salary {get; set;}
        public string Address {get;set;}
        public string Department {get;set;}
    }
}