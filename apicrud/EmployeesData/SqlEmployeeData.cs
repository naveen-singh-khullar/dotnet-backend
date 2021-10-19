using apicrud.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace apicrud.EmployeesData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }


        public Employee AddEmployee(Employee employee)
        {
            if (employee.imageFile != null)
            {
                /*string uploadPath = Server.MapPath("~/uploads");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);*/
                Guid g = Guid.NewGuid();
                string GuidString = Convert.ToBase64String(g.ToByteArray());
                GuidString = GuidString.Replace("=", "");
                GuidString = GuidString.Replace("+", "") + Path.GetExtension(employee.Image);
                string base64 = employee.imageFile.Split(',')[1];
                byte[] bytes = Convert.FromBase64String(base64);
                //write the bytes to file:
                File.WriteAllBytes(Path.Combine("uploads", GuidString), bytes);
                employee.imageFile = "";
                employee.Image = GuidString;
                /*var data = employee.imageFile.Substring(0, 5);
                var extension = Extension(data);
                var imageName = string.Format(@"{0}", Guid.NewGuid()) + extension;
                string imgPath = Path.Combine(path, imageName);
                var imageBytes = Convert.FromBase64String(Image.base64Image);
                var imagefile = new FileStream(imgPath, FileMode.Create);
                imagefile.Write(imageBytes, 0, imageBytes.Length);
                imagefile.Flush();
                Image image = new Image
                {
                    base64Image = imageName
                };*/
            }


            employee.Id = Guid.NewGuid();
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
            
        }

        public void DeleteEmployee(Employee emlpoyee)
        {
           
            _employeeContext.Employees.Remove(emlpoyee);
            _employeeContext.SaveChanges();
            

        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _employeeContext.Employees.Find(id);
            return employee;
            //return _employeeContext.Employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
           return  _employeeContext.Employees.ToList();
        }
    }
}
