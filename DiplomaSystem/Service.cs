using Data;
using Data.Models;
using DiplomaSystem.TempModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiplomaSystem
{
    public class Service
    {
        private Context _context;
        public Service()
        {
            _context = Context.GetContext();
        }

        public IEnumerable<Student> GetStudents() //1
        {
            return _context.People
                .Where(p => p is Student)
                .Select(p => (Student)p);
        }
        public IEnumerable<Teacher> GetTeachers()
        {
            return from p in _context.People
                   where p is Teacher
                   select (Teacher)p;
        }
        public IEnumerable<StudentFullInfo> GetStudentsFullInfo() //2
        {
            var students = GetStudents();

            return from student in students
                   join department in _context.Departments on student.DepartmentId equals department.Id
                   join _group in _context.Groups on student.GroupId equals _group.Id
                   select new StudentFullInfo()
                   {
                       Student = student,
                       GroupName = _group.ToString(),
                       DepartmentNameAbbreviation = department.NameAbbreviation
                   };
        }
        public IEnumerable<TeacherFullInfo> GetTeacherFullInfo()
        {
            var teachers = GetTeachers();

            return from teacher in teachers
                   join department in _context.Departments on teacher.DepartmentId equals department.Id
                   join rank in _context.Ranks on teacher.RankId equals rank.Id
                   select new TeacherFullInfo()
                   {
                       Teacher = teacher,
                       RankName = rank.ToString(),
                       DepartmentNameAbbr = department.NameAbbreviation
                   };
        }
        public Dictionary<string, List<StudentsAndTeachersInfo>> GetStudentsAndTeachersInfo() //3
        {
            var students = GetStudents();
            var teachers = GetTeachers();

            var satfi = from sat in _context.StudentsAndTeachers
                        join teacher in teachers on sat.TeacherId equals teacher.Id
                        join student in students on sat.StudentId equals student.Id
                        select new StudentsAndTeachersInfo()
                        {
                            Student = student,
                            Teacher = teacher,
                        };

            var q = from sat in satfi
                    group sat by sat.Student.ToString() into g
                    select g;

            return q.ToDictionary(x => x.Key, x => x.ToList());
        }
        public Dictionary<string, List<StudentsAndTeachersInfo>> GetTeachersAndStudentsInfo()
        {
            var students = GetStudents();
            var teachers = GetTeachers();

            var satfi = from sat in _context.StudentsAndTeachers
                        join teacher in teachers on sat.TeacherId equals teacher.Id
                        join student in students on sat.StudentId equals student.Id
                        select new StudentsAndTeachersInfo()
                        {
                            Student = student,
                            Teacher = teacher,
                        };

            var q = from sat in satfi
                    group sat by sat.Teacher.ToString() into g
                    select g;

            return q.ToDictionary(x => x.Key, x => x.ToList());
        }
        public IEnumerable<ResourcesFullInfo> GetResourcesFullInfo() //4
        {
            return _context.Resources.Join(
                    _context.ResourceTypes,
                     r => r.ResourceTypeId,
                     rt => rt.Id,
                     (r, rt) => new ResourcesFullInfo
                     { Resource = r, ResourceTypeName = rt.ToString() });
        }
        public Dictionary<string, List<StudentsAndResourcesInfo>> GetStudentsAndResourcesInfo() //5
        {
            var students = GetStudents();

            var sarfi = from sar in _context.StudentsAndResources
                        join student in students on sar.StudentId equals student.Id
                        join resource in _context.Resources on sar.ResourceId equals resource.Id into lj
                        from subres in lj.DefaultIfEmpty()
                        select new StudentsAndResourcesInfo()
                        {
                            Student = student,
                            ResourceName = subres?.ToString() ?? String.Empty,
                        };
            var q = from item in sarfi
                    group item by item.Student.ToString() into g
                    select g;

            return q.ToDictionary(x => x.Key, x => x.ToList());
        }
        public IEnumerable<Student> GetStudentsSortedByNameThenByBirthDate() //6
        {
            return _context.People
                .Where(p => p is Student)
                .Select(p => (Student)p)
                .OrderBy(p => p.ToString())
                .ThenBy(p => p.BirthDate);
        }
        public IEnumerable<Student> GetStudentsSortedByDefenceDateThenByName()
        {
            return _context.People
                .Where(p => p is Student)
                .Select(p => (Student)p)
                .OrderBy(p => p.DateOfDefence)
                .ThenBy(p => p.ToString());
        }
        public IEnumerable<Student> GetStudentsFromDateOfDefense(DateTime dt) //7
        {
            var students = GetStudents();
            return from student in students
                   where dt <= student.DateOfDefence
                   orderby student.DateOfDefence
                   select student;
        }
        public IEnumerable<Student> GetStudentsTopicsByFaculty(string name)
        {
            var students = GetStudents();

            return from student in students
                   join department in _context.Departments on student.DepartmentId equals department.Id
                   where name == department.Name || name == department.NameAbbreviation
                   select student;
        }
        public Dictionary<DateTime, List<Student>> GetGroupOfStudentsByDateOfDefense() //8
        {
            var q = _context.People
                    .Where(p => p is Student)
                    .Select(p => (Student)p)
                    .OrderBy(p => p.DateOfDefence)
                    .GroupBy(p => p.DateOfDefence);
            return q.ToDictionary(x => x.Key, x => x.ToList());
        }
        public IEnumerable<NameNumber> GetTeacherWithCountStudents() //9
        {
            var students = GetStudents();
            var teachers = GetTeachers();

            var satfi = from sat in _context.StudentsAndTeachers
                        join teacher in teachers on sat.TeacherId equals teacher.Id
                        join student in students on sat.StudentId equals student.Id
                        select new
                        {
                            TeacherFullName = teacher.ToString()
                        };


            return from temp in satfi
                   group temp by temp.TeacherFullName into g
                   select new NameNumber { Name = g.Key, Number = g.Count() };
        }
        public bool GetFaculty(string name) //10
        {
            return _context.Departments.Any(n => n.Name == name ||
                    n.NameAbbreviation == name);
        }

        public IEnumerable<NameNumber> GetMaxAverageGPAByDepartments() //11
        {
            var students = GetStudents();

            var q = from student in students
                    join department in _context.Departments on student.DepartmentId equals department.Id
                    group student by department.NameAbbreviation into g
                    let average = decimal.Round((from item in g select item.GPA).Average(), 2) 
                    select new NameNumber
                    {
                        Name = g.Key,
                        Number = average
                    };
            return q.Where(n => n.Number == q.Max(n => n.Number));
        }
        public IEnumerable<Resource> GetDistinctStudentsResources() //12
        {
            return _context.StudentsAndResources
                    .Join(_context.Resources,
                          shr => shr.ResourceId,
                          res => res.Id,
                          (shr, res) => new Resource { Name = res.ToString() }
                          ).Distinct();
        }
        public IEnumerable<Student> GetStudentsWithTopGPAAndMoreThanInputResources(int gpa, int resNum) //13
        {
            var students = GetStudents();
            var topGPAStudents = from student in students
                                 where student.GPA >= gpa
                                 select student;

            var studentsResNumbers = from shr in _context.StudentsAndResources
                                     join student in students on shr.StudentId equals student.Id
                                     join resource in _context.Resources on shr.ResourceId equals resource.Id
                                     group shr by shr.StudentId into g
                                     select new { StudentId = g.Key, Number = g.Count() };

            var topResNumbers = from srn in studentsResNumbers
                                where srn.Number > resNum
                                select srn.StudentId into studentsId
                                join student in students on studentsId equals student.Id
                                select student;

            return topGPAStudents.Intersect(topResNumbers);
        }
        public IEnumerable<Student> GetTopGPAStudents() //14
        {
            return _context.People
                .Where(p => p is Student)
                .Select(p => (Student)p)
                .OrderByDescending(p => p.GPA)
                .TakeWhile(p => p.GPA > 95);
        }
        public Dictionary<string, List<StudentsAndTeachersInfo>> GetAllTeachersWithStudentsDateOfDefense(DateTime dod) //15
        {
            var sat = GetTeachersAndStudentsInfo();
            var q = from item in sat
                    where item.Value.All(x => x.Student.DateOfDefence > dod)
                    select item;
            return q.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
