using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationPoster.Models;


namespace JobApplicationPoster.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Application> GetApplications(int id);
        Student GetStudentById(int id);
        Application GetApplicationById(int id);
        void AddStudent(Student student);
        void AddApplication(Application application);      
        void DeleteStudent(int id);
        void DeleteApplication(int id);
        void UpdateTotalApplication(int id);
        void SaveChanges();
        IQueryable<Student> PopulateStudentsDropDownList();
    }
}
