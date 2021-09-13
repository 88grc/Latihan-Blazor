using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages {
    public partial class EmployeePage {
        public IEnumerable<Employee> Employees{ get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Gracia Zerlinda",
                LastName="Puspita",
                Email="gracia.zerlinda@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2001,07,20),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,DepartmentName="SI"},
                PhotoPath = "image/zerlinda.jpg"
            };

            Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Rosalia",
                LastName="Natasha",
                Email="rosalia.natasha@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2002,01,11),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,DepartmentName="SI"},
                PhotoPath = "image/rosa.jpg"
            };

            Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Haniel",
                LastName="Obed",
                Email="haniel.obed@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2000,12,11),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="TI"},
                PhotoPath = "image/obed.jpg"
            };

            Employee e4 = new Employee{
                EmployeeId=4,
                FirstName="Anthony",
                LastName="Edrick",
                Email="anthony.edrick@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2001,10,11),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="TI"},
                PhotoPath = "image/edrick.jpg"
            };

            Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }
}