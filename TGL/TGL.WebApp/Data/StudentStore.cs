using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();
        public StudentStore()
        {
            Students.Add(new Student
            {
                Id=Guid.NewGuid(),
                Age = 21,
                Name = "Sergio",
                LastName = "Garcia",
                Nit = "0001"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 19,
                Name = "Juan",
                LastName = "Perez",
                Nit = "0002"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 23,
                Name = "Andres",
                LastName = "Lopez",
                Nit = "0003"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Laura",
                LastName = "Gaviria",
                Nit = "0004"
            });
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }

    }
}
