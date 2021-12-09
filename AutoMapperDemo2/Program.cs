//Below is a example of how to map two properties when names are different using automapper.

using System;
using AutoMapper;

namespace AutoMapperDemo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialize the mapper
            var config = new MapperConfiguration(cfg =>cfg.CreateMap<Employee, EmployeeDTO>()
                                                    .ForMember(dest => dest.FullName, act=> act.MapFrom(src => src.FirstName + " "+ src.LastName))
                                                    .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department)));

            //Creating the source object
            Employee emp = new Employee
            {
                FirstName = "XYZ",
                LastName = "PQR",
                Salary = 30000,
                Address = "Mumbai",
                Department = "Finance"
            };

            //using automapper
            var mapper = new Mapper(config);
            var empDTO = mapper.Map<EmployeeDTO>(emp);

            Console.WriteLine("Name:" +empDTO.FullName +", Salary:" +empDTO.Salary +", Address:" + empDTO.Address +", Department:" +empDTO.Dept);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Salary {get;set;}
        public string Address {get;set;}
        public string Department {get;set;}
    }

    public class EmployeeDTO
    {
        public string FullName {get;set;}
        public int Salary {get;set;}
        public string Address {get;set;}
        public string Dept {get;set;}
    }
}
