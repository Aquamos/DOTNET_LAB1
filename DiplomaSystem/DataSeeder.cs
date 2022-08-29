using Data;
using Data.Models;


namespace DiplomaSystem
{
    public class DataSeeder
    {
        private Context _context;
        public DataSeeder(){
            _context = Context.GetContext();

            SeedRanks();
            SeedDepartments();
            SeedGroups();
            SeedPerson();
            SeedResourceTypes();
            SeedResources();
            SeedStudentsAndResources();
            SeedStudentsAndTeachers();
        }
        private void SeedRanks()
        {
            _context.Ranks.Add(new Rank() { Name = "Assistant Lecturer" });
            _context.Ranks.Add(new Rank() { Name = "Senior Instructor" });
            _context.Ranks.Add(new Rank() { Name = "Associate Professor" });
            _context.Ranks.Add(new Rank() { Name = "Professor" });
            for (int i = 0; i < _context.Ranks.Count; i++)
            {
                _context.Ranks[i].Id = i + 1;
            }
        }
        private void SeedDepartments(){

            _context.Departments.Add(new Department() 
            { 
                Name = "Faculty of Informatics and Computer Science", 
                NameAbbreviation = "FICT"
            });
            _context.Departments.Add(new Department()
            {
                Name = "Faculty of Applied Mathematics",
                NameAbbreviation = "FAM"
            });
            _context.Departments.Add(new Department()
            {
                Name = "Faculty of Physics and Mathematics",
                NameAbbreviation = "FPM"
            });
            for (int i = 0; i < _context.Departments.Count; i++)
            {
                _context.Departments[i].Id = i + 1;
            }
        }
        private void SeedGroups()
        {
            _context.Groups.Add(new Group(){ Name = "IK", Number = 71});
            _context.Groups.Add(new Group(){ Name = "RT", Number = 73});
            _context.Groups.Add(new Group(){ Name = "IS", Number = 72});
            _context.Groups.Add(new Group(){ Name = "RK", Number = 73});
            _context.Groups.Add(new Group(){ Name = "BT", Number = 72});
            _context.Groups.Add(new Group(){ Name = "FE", Number = 71});
            _context.Groups.Add(new Group(){ Name = "FH", Number = 71});
            _context.Groups.Add(new Group(){ Name = "FE", Number = 73});
            for (int i = 0; i < _context.Groups.Count; i++)
            {
                _context.Groups[i].Id = i + 1;
            }
        }
        private void SeedPerson() {
            _context.People.Add(new Student()
            {
                FirstName = "Sherlok",
                LastName = "Tkachuk",
                BirthDate = new DateTime(2000, 7, 13),
                DepartmentId = 3,
                GroupId = 7,
                GPA = 90.66M,
                Topic = "Possibilities of using cloud storage",
                DateOfDefence = new DateTime(2022, 6, 16)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Ustym",
                BirthDate = new DateTime(2000, 3, 19),
                LastName = "Kholodnyi",
                DepartmentId = 2,
                GroupId = 4,
                GPA = 76.27M,
                Topic = "Entropy solutions of model equations of hydromechanics",
                DateOfDefence = new DateTime(2022, 5, 23)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Yevlampii",
                LastName = "Sterniuk",
                BirthDate = new DateTime(2000, 10, 21),
                DepartmentId = 3,
                GroupId = 6,
                GPA = 97.73M,
                Topic = "Finding of heat, contrast and other characteristics of images",
                DateOfDefence = new DateTime(2022, 6, 5)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Chestyslav",
                LastName = "Butko",
                BirthDate = new DateTime(2000, 1, 2),
                DepartmentId = 1,
                GroupId = 3,
                GPA = 99.27M,
                Topic = "Modern trends in the development of computer-oriented learning technologies",
                DateOfDefence = new DateTime(2022, 6, 10)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Yulian",
                LastName = "Syrovatskyi",
                BirthDate = new DateTime(2000, 2, 26),
                DepartmentId = 1,
                GroupId = 1,
                GPA = 96.55M,
                Topic = "Internet technologies in electronic commerce",
                DateOfDefence = new DateTime(2022, 6, 12)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Iryna",
                LastName = "Limnychenko",
                BirthDate = new DateTime(2000, 6, 15),
                DepartmentId = 2,
                GroupId = 5,
                GPA = 87.35M,
                Topic = "Analysis and programming of one-dimensional optimization algorithms",
                DateOfDefence = new DateTime(2022, 5, 20)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Tetiana",
                LastName = "Otkovych",
                BirthDate = new DateTime(2000, 8, 30),
                DepartmentId = 1,
                GroupId = 1,
                GPA = 99.31M,
                Topic = "Optimization of the firmware " +
                    "of mobile devices based on the AOS",
                DateOfDefence = new DateTime(2022, 6, 12)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Tereza",
                LastName = "Telezhynska",
                BirthDate = new DateTime(2000, 8, 5),
                DepartmentId = 3,
                GroupId = 8,
                GPA = 85.91M,
                Topic = "Creating a Problem Situation" +
                    "in Physics Lessons ACA of Primary School Students",
                DateOfDefence = new DateTime(2022, 6, 7)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Uliana",
                LastName = "Konoplenko",
                BirthDate = new DateTime(2000, 11, 11),
                DepartmentId = 2,
                GroupId = 2,
                GPA = 95.32M,
                Topic = "Matrix game models",
                DateOfDefence = new DateTime(2022, 5, 20)
            });
            _context.People.Add(new Student()
            {
                FirstName = "Daryna",
                LastName = "Hvozdyk",
                BirthDate = new DateTime(2000, 12, 19),
                DepartmentId = 1,
                GroupId = 3,
                GPA = 88.66M,
                Topic = "Design of a client-server " +
                    "application interface on the WordPress platform",
                DateOfDefence = new DateTime(2022, 6, 14)
            });

            _context.People.Add(new Teacher()
            {
                FirstName = "Ihor",
                LastName = "Kovbasiuk",
                BirthDate = new DateTime(1970, 3, 4),
                DepartmentId = 2,
                RankId = 4
            });
            _context.People.Add(new Teacher()
            {
                FirstName = "Yevhenii",
                LastName = "Savka",
                BirthDate = new DateTime(1994, 5, 20),
                DepartmentId = 1,
                RankId = 1
            });
            _context.People.Add(new Teacher()
            {
                FirstName = "Daryna",
                LastName = "Kalytovska",
                BirthDate = new DateTime(1968, 9, 9),
                DepartmentId = 1,
                RankId = 3
            });
            _context.People.Add(new Teacher()
            {
                FirstName = "Zhanna",
                LastName = "Topiha",
                BirthDate = new DateTime(1987, 12, 1),
                DepartmentId = 2,
                RankId = 2
            });
            _context.People.Add(new Teacher()
            {
                FirstName = "Yehor",
                LastName = "Liashchuk",
                BirthDate = new DateTime(1985, 1, 20),
                DepartmentId = 3,
                RankId = 3
            });
            for (int i = 0; i < _context.People.Count; i++)
            {
                _context.People[i].Id = i + 1;
            }
        }
        private void SeedResourceTypes()
        {
            _context.ResourceTypes.Add(new ResourceType() { Name = "Text book" });
            _context.ResourceTypes.Add(new ResourceType() { Name = "Film" });
            _context.ResourceTypes.Add(new ResourceType() { Name = "Digital learning resource" });
            _context.ResourceTypes.Add(new ResourceType() { Name = "Lecture" });
            _context.ResourceTypes.Add(new ResourceType() { Name = "Speeche" });
            for (int i = 0; i < _context.ResourceTypes.Count; i++)
            {
                _context.ResourceTypes[i].Id = i + 1;
            }
        }
        private void SeedResources()
        {
            _context.Resources.Add(new Resource()
            {
                Name = "Cloud Computing from Beginning to End by Ray J Rafaels",
                ResourceTypeId = 1
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Cloud Computing: Concepts, Technology & Architecture",
                ResourceTypeId = 1
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Cloud Storage on Happy Coding web-site",
                ResourceTypeId = 3
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Large time behavior of entropy solutions",
                ResourceTypeId = 4
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Two-velocity hydrodynamics in fluid mechanics",
                ResourceTypeId = 3
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Heat Transfer, Specific Heat, and Heat Capacity",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Thermal Imaging - an overview on ScienceDirectTopics web-site",
                ResourceTypeId = 3
            });
            _context.Resources.Add(new Resource()
            {
                Name = "New Trends and Technologies " +
                    "in Computer-Aided Learning",
                ResourceTypeId = 1
            });
            _context.Resources.Add(new Resource()
            {
                Name = "LIMITLESS (2011)",
                ResourceTypeId = 2
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Web Programming and Internet Technologies: An E-commerce Approach",
                ResourceTypeId = 1
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Digital Innovation at Dow with CVP/CIO/CDO Melanie Kalmar",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource()
            {
                Name = "The eCommerceFuel Podcast",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource()
            {
                Name = "INTERNET TECHNOLOGY IN ELECTRONIC COMMERCE",
                ResourceTypeId = 3
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Mod-03 Lec-04 One Dimensional Optimization - Optimality Conditions",
                ResourceTypeId = 4
            });
            _context.Resources.Add(new Resource()
            {
                Name = "One-Dimensional Optimization on SpringerLink web-site",
                ResourceTypeId = 3
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Mod-01 Lec-07 FIRMWARE DESIGNING FOR ANDROID MOBILE",
                ResourceTypeId = 4
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Customization and Installation of Android Podcast",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Organising the Process of Physics Students " +
                    "Cognitive Activity Podcast",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Students’ regulation of cognition in physics problem-solving",
                ResourceTypeId = 2
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Model View Matrix",
                ResourceTypeId = 2
            });
            _context.Resources.Add(new Resource()
            {
                Name = "Fuzzy Mathematical Programming " +
                    "and Fuzzy Matrix Games Podcast",
                ResourceTypeId = 5
            });
            _context.Resources.Add(new Resource() //22
            {
                Name = "Building Web Apps With Wordpress on Climb web-site",
                ResourceTypeId = 3
            });
            for (int i = 0; i < _context.Resources.Count; i++)
            {
                _context.Resources[i].Id = i + 1;
            }
        }
        private void SeedStudentsAndResources()
        {
            _context.StudentsAndResources.Add(new StudentsAndResources(){ StudentId = 1, ResourceId = 1});
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 1, ResourceId = 2 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 1, ResourceId = 3 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 2, ResourceId = 4 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 2, ResourceId = 5 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 3, ResourceId = 6 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 3, ResourceId = 7 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 4, ResourceId = 8 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 4, ResourceId = 9 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 5, ResourceId = 10 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 5, ResourceId = 11 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 5, ResourceId = 12 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 5, ResourceId = 13 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 6, ResourceId = 12 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 6, ResourceId = 14 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 6, ResourceId = 15 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 7, ResourceId = 16 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 7, ResourceId = 17 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 8, ResourceId = 18 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 8, ResourceId = 19 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 9, ResourceId = 20 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 9, ResourceId = 21 });
            _context.StudentsAndResources.Add(new StudentsAndResources() { StudentId = 10 });
            for (int i = 0; i < _context.StudentsAndResources.Count; i++)
            {
                _context.StudentsAndResources[i].Id = i + 1;
            }
        }
        private void SeedStudentsAndTeachers()
        {
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 1, TeacherId = 15 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 3, TeacherId = 15 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 2, TeacherId = 11 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 4, TeacherId = 12 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 5, TeacherId = 13 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 6, TeacherId = 14 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 7, TeacherId = 12 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 8, TeacherId = 15 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 9, TeacherId = 11 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 10, TeacherId = 13 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 7, TeacherId = 13 });
            _context.StudentsAndTeachers.Add(new StudentsAndTeachers() { StudentId = 2, TeacherId = 14 });
            for (int i = 0; i < _context.StudentsAndTeachers.Count; i++)
            {
                _context.StudentsAndTeachers[i].Id = i + 1;
            }
        }
    }
}
