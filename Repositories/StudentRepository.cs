using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using JobApplicationPoster.Data;
using JobApplicationPoster.Models;
using Microsoft.EntityFrameworkCore;


namespace JobApplicationPoster.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.StudentTable.ToList();
        }

        public IEnumerable<Application> GetApplications(int id)
        {

            var result = (from appli in _context.ApplicationTable
                          where appli.StudentId == id

                          select new Application
                          {
                              Identy = appli.Identy,
                              StudentId = appli.StudentId,
                              Company = appli.Company,
                              Title = appli.Title,
                              Location = appli.Location,
                              Sticker = appli.Sticker
                          }).ToList();

            return result;
        }

        public Student GetStudentById(int id)
        {
            return _context.StudentTable.SingleOrDefault(c => c.AutoId == id);
        }

        public Application GetApplicationById(int id)
        {
            return _context.ApplicationTable.SingleOrDefault(c => c.Identy == id);
        }

        public void AddStudent(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
        }

        public void AddApplication(Application application)
        {
            _context.Add(application);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var selectStudent = _context.StudentTable.SingleOrDefault(c => c.AutoId == id);

            // need to delete this selected 
            var selectedApplication = from x in _context.ApplicationTable
                         where x.StudentId == id
                         select x;

            _context.StudentTable.Remove(selectStudent);
            _context.SaveChanges();
        }

        public void DeleteApplication(int id)
        {
            var selectApplication = _context.ApplicationTable.SingleOrDefault(c => c.Identy == id);
            _context.ApplicationTable.Remove(selectApplication);
            _context.SaveChanges();
        }

        // Update total value in Student class
        public void UpdateTotalApplication(int id)
        {
            int result = (int)(from appli in _context.ApplicationTable                          
                          where appli.StudentId == id
                          select appli.Sticker).Sum();

            var student = new Student { AutoId = id };
            student.Total = result;
            _context.Entry(student).Property("Total").IsModified = true;
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        // creates sorted collection 
        public IQueryable<Student> PopulateStudentsDropDownList()
        {
            var students = from stu in _context.StudentTable
                           orderby stu.FullName
                           select stu;
            return students;
        }
    }
}
