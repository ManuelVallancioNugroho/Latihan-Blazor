using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Manuel",
                LastName="Vallancio",
                Email="manuelvallancio@gmail.com",
                DateOfBirth = new DateTime(2001,05,01),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/allan.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Marieta",
                LastName="Valencia",
                Email="manrietavalencia@gmail.com",
                DateOfBirth = new DateTime(1996,05,28),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="Human Resource"},
                PhotoPath = "images/ellen.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Yotam",
                LastName="Adiel",
                Email="yotamadiel@gmail.com",
                DateOfBirth = new DateTime(1999,07,06),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/yotam.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}