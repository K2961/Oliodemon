using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11.Model
{
    /// <summary>
    /// This class holds employee properties.
    /// </summary>
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public EmployeeImage Image { get; set; }

        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    
    }
    /// <summary>
    /// This class holds employee view model data.
    /// </summary>
    public class EmployeeViewModel
    {
        public void AddEmployee(string firstnameTextBox, string lastnameTextBox, string jobTitleTextBox, EmployeeImage image)
        {
            
        }
        //private List<Employee> employees = new List<Employee>();
        //public List<Employee> Employees { get { return employees; } }

        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public EmployeeViewModel()
        {
            // generate some dummy data for testing purposes
           
        }
    }
    /// <summary>
    /// This class holds path to image object.
    /// </summary>
    public class EmployeeImage
    {
        public string Path { get; set; }
    }

    /// <summary>
    /// This class holds all Employee Image objecs in a collections.
    /// </summary>
    public class EmployeeImageViewModel
    {
        private List<EmployeeImage> images;
        public List<EmployeeImage> Images { get { return images; } }

        public EmployeeImageViewModel()
        {
            images = new List<EmployeeImage>();
            images.Add(new EmployeeImage { Path = "Assets/Images/employee01.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee02.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee03.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee04.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee05.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee06.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee07.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee08.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee09.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee10.png" });
        }
    }
}

